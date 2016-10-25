using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

using PortfolioTracker.ViewModels;

namespace PortfolioTracker
{
    public partial class Main : Form
    {
        #region Members
        private PortfolioViewModel model;
        private Boolean _internetBlackoutAcknowledge = false;
        private delegate void SetDataBindingCallback(Control ctl, BindingSource source, String property, String dataMember);
        private delegate void SetDataControlBindingCallback(DataGridView dgv, BindingSource source);
        private delegate void SetDataGridViewCellStyleCallback(DataGridViewCell cell);
        #endregion

        #region Constructor
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        #region DataMethods
        private void getData(String filename)
        {
            try
            {
                DataAccess.Models.Portfolio portfolio =
                           DataAccess.Factory.PortfolioFactory.Instance.GetPortfolio(filename);

                model = new PortfolioViewModel(filename);
                model.ViewModelChanged += new ViewModelChangedEventHandler(ViewModelChanged);
                model.InternetBlackout += new HttpBlackoutEventHander(InternetBlackout);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error Opening Portfolio", MessageBoxButtons.OK);
            }
        }

        private void setDataBinding(Control ctl, BindingSource source, String property, String dataMember)
        {
            if (ctl.InvokeRequired)
            {
                SetDataBindingCallback d = new SetDataBindingCallback(setDataBinding);
                this.Invoke(d, new object[] { ctl, source, property, dataMember });
            }
            else
                ctl.DataBindings.Add(property, source, dataMember);
        }

        private void setDataGridViewControlBinding(DataGridView dgv, BindingSource source)
        {
            if (dgv.InvokeRequired)
            {
                SetDataControlBindingCallback d = new SetDataControlBindingCallback(setDataGridViewControlBinding);
                this.Invoke(d, new object[] { dgv, source });
            }
            else
            {
                dgv.AutoGenerateColumns = false;
                dgv.DataSource = source;
                source.ResetBindings(false);
            }
        }

        private void bindData()
        {
            if (model != null)
            {
                // bind header labels to portfolio meta-data
                setDataBinding(lbl_OwnerName, model.PortfolioBindingSource, "Text", "Owner");
                setDataBinding(lbl_OwnerPhone, model.PortfolioBindingSource, "Text", "Phone");
                setDataBinding(lbl_OwnerEmail, model.PortfolioBindingSource, "Text", "Email");
                setDataBinding(lbl_PortfolioName, model.PortfolioBindingSource, "Text", "PortfolioName");
                setDataBinding(lbl_PortfolioNumber, model.PortfolioBindingSource, "Text", "PortfolioNumber");
                model.PortfolioBindingSource.ResetBindings(false);

                //bind datagridview to equity values
                setDataGridViewControlBinding(dgv_Positions, model.EquityBindingSource);
                setDataGridViewControlBinding(dgv_PortfolioFooter, model.PortfolioBindingSource);
            }
        }

        private void ViewModelChanged(object sender, EventArgs e)
        {
            //bubble up event if underlying data changes to update datagridviews

            setDataGridViewControlBinding(dgv_Positions, model.EquityBindingSource);
            setDataGridViewControlBinding(dgv_PortfolioFooter, model.PortfolioBindingSource);
            _internetBlackoutAcknowledge = false; //if we're here, then the internet is back up! Reset this acknlowledgement flag.

        }

        private void InternetBlackout(object sender, EventArgs e)
        {
            if (!_internetBlackoutAcknowledge)
            {
                MessageBox.Show("Unable to connect with web services. Please check internet connections.", "Connection Problem", MessageBoxButtons.OK);
                _internetBlackoutAcknowledge = true; //prevent nuisance warnings.
            }
        }
        #endregion

        #region UI Methods
        private void tsbOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Portfolio file:";
                dlg.Filter = "XML Files|*.xml";
                dlg.InitialDirectory = Application.StartupPath;
                dlg.AddExtension = true;
                dlg.CheckFileExists = true;
                dlg.CheckPathExists = true;

                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    Task.Factory.StartNew(() => getData(dlg.FileName))
                    .ContinueWith(_ => bindData());
                }
            }
        }
        
        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //after databinding - check values to peform formatting of cell forecolors and backcolors

            DataGridView dgv = (DataGridView)sender;

            if (dgv.RowCount == 0)
                return;

            Int32 height = 40;
            foreach(DataGridViewRow row in dgv.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if (cell.OwningColumn.HeaderText.Contains("Gain/Loss"))
                    {
                        Double value = 0;
                        if (Double.TryParse(cell.Value.ToString(), out value))
                        {
                            cell.Style.ForeColor = (value < 0) ? Color.Red : Color.Green;
                        }
                    }
                    if(cell.OwningColumn.HeaderText.Contains("Direction"))
                    {
                        lastTradeHightlightCheck(cell);
                    }
                }
                height += row.Height;
            }
            dgv.Height = height;
        }

        private void lastTradeHightlightCheck(DataGridViewCell cell)
        {
            //highlight last trade cells red, green, or white if last trade increases/decreases

            DataGridViewCell lastTrade = dgv_Positions[cell.ColumnIndex + 1, cell.RowIndex];
            Int32 direction;
            if (Int32.TryParse(cell.Value.ToString(), out direction))
            {
                DataGridViewCellStyle defaultStyle = lastTrade.Style.Clone();

                lastTrade.Style.BackColor = (direction < 0) ? Color.Red : (direction > 0) ? Color.Green : Color.White;
                lastTrade.Style.ForeColor = (direction == 0) ? Color.Black : Color.White;

                //async method to turn off highlighted background after 1 sec.
                Task.Delay(1000)
                    .ContinueWith(t => cellDefaultStyletRestore(lastTrade));
            }
        }

        private void cellDefaultStyletRestore(DataGridViewCell cell)
        {
            //restore white background and black text after highlighting

            if(dgv_Positions.InvokeRequired)
            {
                SetDataGridViewCellStyleCallback d = new SetDataGridViewCellStyleCallback(cellDefaultStyletRestore);
                this.Invoke(d, new object[] { cell });
            }
            else
            {
                cell.Style.BackColor = Color.White;
                cell.Style.ForeColor = Color.Black;
            }
            
        }
        #endregion
    }
}
