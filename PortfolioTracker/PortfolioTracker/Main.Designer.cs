namespace PortfolioTracker
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutOwner;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbl_PortfolioOwnerLabel = new System.Windows.Forms.Label();
            this.lbl_OwnerEmail = new System.Windows.Forms.Label();
            this.lbl_OwnerPhone = new System.Windows.Forms.Label();
            this.lbl_OwnerName = new System.Windows.Forms.Label();
            this.lbl_PortfolioNameLabel = new System.Windows.Forms.Label();
            this.lbl_PortfolioName = new System.Windows.Forms.Label();
            this.lbl_PortfolioNumber = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Positions = new System.Windows.Forms.DataGridView();
            this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyGainLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayGainLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayGainLossPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InceptionGainLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGainLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGainLossPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_PortfolioFooter = new System.Windows.Forms.DataGridView();
            this.Dummy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortfolioDayGainLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortfolioDayGainLossPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spacer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortfolioInceptionGainLoss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PortfolioInceptionGainLossPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tableLayoutOwner = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutOwner.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Positions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PortfolioFooter)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutOwner
            // 
            tableLayoutOwner.ColumnCount = 2;
            tableLayoutOwner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            tableLayoutOwner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutOwner.Controls.Add(this.lbl_PortfolioOwnerLabel, 0, 0);
            tableLayoutOwner.Controls.Add(this.lbl_OwnerEmail, 1, 2);
            tableLayoutOwner.Controls.Add(this.lbl_OwnerPhone, 1, 1);
            tableLayoutOwner.Controls.Add(this.lbl_OwnerName, 1, 0);
            tableLayoutOwner.Controls.Add(this.lbl_PortfolioNameLabel, 0, 3);
            tableLayoutOwner.Controls.Add(this.lbl_PortfolioName, 1, 3);
            tableLayoutOwner.Controls.Add(this.lbl_PortfolioNumber, 1, 4);
            tableLayoutOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutOwner.Location = new System.Drawing.Point(3, 3);
            tableLayoutOwner.Name = "tableLayoutOwner";
            tableLayoutOwner.RowCount = 5;
            tableLayoutOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutOwner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutOwner.Size = new System.Drawing.Size(842, 119);
            tableLayoutOwner.TabIndex = 0;
            // 
            // lbl_PortfolioOwnerLabel
            // 
            this.lbl_PortfolioOwnerLabel.AutoSize = true;
            this.lbl_PortfolioOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PortfolioOwnerLabel.Location = new System.Drawing.Point(3, 0);
            this.lbl_PortfolioOwnerLabel.Name = "lbl_PortfolioOwnerLabel";
            tableLayoutOwner.SetRowSpan(this.lbl_PortfolioOwnerLabel, 3);
            this.lbl_PortfolioOwnerLabel.Size = new System.Drawing.Size(125, 17);
            this.lbl_PortfolioOwnerLabel.TabIndex = 0;
            this.lbl_PortfolioOwnerLabel.Text = "Portfolio Owner:";
            // 
            // lbl_OwnerEmail
            // 
            this.lbl_OwnerEmail.AutoSize = true;
            this.lbl_OwnerEmail.Location = new System.Drawing.Point(149, 50);
            this.lbl_OwnerEmail.Name = "lbl_OwnerEmail";
            this.lbl_OwnerEmail.Size = new System.Drawing.Size(0, 13);
            this.lbl_OwnerEmail.TabIndex = 3;
            // 
            // lbl_OwnerPhone
            // 
            this.lbl_OwnerPhone.AutoSize = true;
            this.lbl_OwnerPhone.Location = new System.Drawing.Point(149, 25);
            this.lbl_OwnerPhone.Name = "lbl_OwnerPhone";
            this.lbl_OwnerPhone.Size = new System.Drawing.Size(0, 13);
            this.lbl_OwnerPhone.TabIndex = 1;
            // 
            // lbl_OwnerName
            // 
            this.lbl_OwnerName.AutoSize = true;
            this.lbl_OwnerName.Location = new System.Drawing.Point(149, 0);
            this.lbl_OwnerName.Name = "lbl_OwnerName";
            this.lbl_OwnerName.Size = new System.Drawing.Size(110, 13);
            this.lbl_OwnerName.TabIndex = 2;
            this.lbl_OwnerName.Text = "Open a portfolio file....";
            // 
            // lbl_PortfolioNameLabel
            // 
            this.lbl_PortfolioNameLabel.AutoSize = true;
            this.lbl_PortfolioNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PortfolioNameLabel.Location = new System.Drawing.Point(3, 75);
            this.lbl_PortfolioNameLabel.Name = "lbl_PortfolioNameLabel";
            tableLayoutOwner.SetRowSpan(this.lbl_PortfolioNameLabel, 2);
            this.lbl_PortfolioNameLabel.Size = new System.Drawing.Size(120, 17);
            this.lbl_PortfolioNameLabel.TabIndex = 4;
            this.lbl_PortfolioNameLabel.Text = "Portfolio Name:";
            // 
            // lbl_PortfolioName
            // 
            this.lbl_PortfolioName.AutoSize = true;
            this.lbl_PortfolioName.Location = new System.Drawing.Point(149, 75);
            this.lbl_PortfolioName.Name = "lbl_PortfolioName";
            this.lbl_PortfolioName.Size = new System.Drawing.Size(0, 13);
            this.lbl_PortfolioName.TabIndex = 5;
            // 
            // lbl_PortfolioNumber
            // 
            this.lbl_PortfolioNumber.AutoSize = true;
            this.lbl_PortfolioNumber.Location = new System.Drawing.Point(149, 95);
            this.lbl_PortfolioNumber.Name = "lbl_PortfolioNumber";
            this.lbl_PortfolioNumber.Size = new System.Drawing.Size(0, 13);
            this.lbl_PortfolioNumber.TabIndex = 6;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayout);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(848, 478);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(848, 503);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(tableLayoutOwner, 0, 0);
            this.tableLayout.Controls.Add(this.dgv_Positions, 0, 1);
            this.tableLayout.Controls.Add(this.dgv_PortfolioFooter, 0, 2);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 3;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(848, 478);
            this.tableLayout.TabIndex = 0;
            // 
            // dgv_Positions
            // 
            this.dgv_Positions.AllowUserToAddRows = false;
            this.dgv_Positions.AllowUserToDeleteRows = false;
            this.dgv_Positions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Positions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_Positions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Positions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Symbol,
            this.PurchaseDate,
            this.Quantity,
            this.PurchasePrice,
            this.Open,
            this.Direction,
            this.CurrentPrice,
            this.DailyGainLoss,
            this.DayGainLoss,
            this.DayGainLossPercentage,
            this.InceptionGainLoss,
            this.TotalGainLoss,
            this.TotalGainLossPercentage});
            this.dgv_Positions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Positions.Location = new System.Drawing.Point(3, 128);
            this.dgv_Positions.Name = "dgv_Positions";
            this.dgv_Positions.ReadOnly = true;
            this.dgv_Positions.Size = new System.Drawing.Size(842, 50);
            this.dgv_Positions.TabIndex = 1;
            this.dgv_Positions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // Symbol
            // 
            this.Symbol.DataPropertyName = "Symbol";
            this.Symbol.HeaderText = "Position";
            this.Symbol.Name = "Symbol";
            this.Symbol.ReadOnly = true;
            this.Symbol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Symbol.Width = 69;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.DataPropertyName = "PurchaseDate";
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            this.PurchaseDate.Width = 95;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 71;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle2.Format = "C3";
            dataGridViewCellStyle2.NullValue = null;
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.PurchasePrice.HeaderText = "Purchase Price";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            this.PurchasePrice.Width = 96;
            // 
            // Open
            // 
            this.Open.DataPropertyName = "OpenPrice";
            dataGridViewCellStyle3.Format = "C3";
            this.Open.DefaultCellStyle = dataGridViewCellStyle3;
            this.Open.HeaderText = "Open";
            this.Open.Name = "Open";
            this.Open.ReadOnly = true;
            this.Open.Width = 58;
            // 
            // Direction
            // 
            this.Direction.DataPropertyName = "Direction";
            this.Direction.HeaderText = "Direction";
            this.Direction.Name = "Direction";
            this.Direction.ReadOnly = true;
            this.Direction.Visible = false;
            this.Direction.Width = 74;
            // 
            // CurrentPrice
            // 
            this.CurrentPrice.DataPropertyName = "CurrentPrice";
            dataGridViewCellStyle4.Format = "C3";
            this.CurrentPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.CurrentPrice.HeaderText = "Last Trade";
            this.CurrentPrice.Name = "CurrentPrice";
            this.CurrentPrice.ReadOnly = true;
            this.CurrentPrice.Width = 77;
            // 
            // DailyGainLoss
            // 
            this.DailyGainLoss.DataPropertyName = "DayGainLoss";
            dataGridViewCellStyle5.Format = "C3";
            this.DailyGainLoss.DefaultCellStyle = dataGridViewCellStyle5;
            this.DailyGainLoss.HeaderText = "Today\'s Gain/Loss (per share)";
            this.DailyGainLoss.Name = "DailyGainLoss";
            this.DailyGainLoss.ReadOnly = true;
            this.DailyGainLoss.Width = 132;
            // 
            // DayGainLoss
            // 
            this.DayGainLoss.DataPropertyName = "DayGainLossTotal";
            dataGridViewCellStyle6.Format = "C3";
            this.DayGainLoss.DefaultCellStyle = dataGridViewCellStyle6;
            this.DayGainLoss.HeaderText = "Today\'s Total Gain/Loss";
            this.DayGainLoss.Name = "DayGainLoss";
            this.DayGainLoss.ReadOnly = true;
            this.DayGainLoss.Width = 135;
            // 
            // DayGainLossPercentage
            // 
            this.DayGainLossPercentage.DataPropertyName = "DayGainLossPercentage";
            dataGridViewCellStyle7.Format = "P";
            this.DayGainLossPercentage.DefaultCellStyle = dataGridViewCellStyle7;
            this.DayGainLossPercentage.HeaderText = "Today\'s Gain/Loss %";
            this.DayGainLossPercentage.Name = "DayGainLossPercentage";
            this.DayGainLossPercentage.ReadOnly = true;
            this.DayGainLossPercentage.Width = 111;
            // 
            // InceptionGainLoss
            // 
            this.InceptionGainLoss.DataPropertyName = "InceptionGainLoss";
            dataGridViewCellStyle8.Format = "C3";
            this.InceptionGainLoss.DefaultCellStyle = dataGridViewCellStyle8;
            this.InceptionGainLoss.HeaderText = "Inception Gain/Loss (per share)";
            this.InceptionGainLoss.Name = "InceptionGainLoss";
            this.InceptionGainLoss.ReadOnly = true;
            this.InceptionGainLoss.Width = 139;
            // 
            // TotalGainLoss
            // 
            this.TotalGainLoss.DataPropertyName = "InceptionGainLossTotal";
            dataGridViewCellStyle9.Format = "C3";
            this.TotalGainLoss.DefaultCellStyle = dataGridViewCellStyle9;
            this.TotalGainLoss.HeaderText = "Inception Total Gain/Loss";
            this.TotalGainLoss.Name = "TotalGainLoss";
            this.TotalGainLoss.ReadOnly = true;
            this.TotalGainLoss.Width = 141;
            // 
            // TotalGainLossPercentage
            // 
            this.TotalGainLossPercentage.DataPropertyName = "InceptionGainLossPercentage";
            dataGridViewCellStyle10.Format = "P";
            this.TotalGainLossPercentage.DefaultCellStyle = dataGridViewCellStyle10;
            this.TotalGainLossPercentage.HeaderText = "Total Gain/Loss %";
            this.TotalGainLossPercentage.Name = "TotalGainLossPercentage";
            this.TotalGainLossPercentage.ReadOnly = true;
            this.TotalGainLossPercentage.Width = 99;
            // 
            // dgv_PortfolioFooter
            // 
            this.dgv_PortfolioFooter.AllowUserToAddRows = false;
            this.dgv_PortfolioFooter.AllowUserToDeleteRows = false;
            this.dgv_PortfolioFooter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PortfolioFooter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dummy,
            this.PortfolioDayGainLoss,
            this.PortfolioDayGainLossPercent,
            this.Spacer,
            this.PortfolioInceptionGainLoss,
            this.PortfolioInceptionGainLossPercent});
            this.dgv_PortfolioFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PortfolioFooter.Location = new System.Drawing.Point(3, 184);
            this.dgv_PortfolioFooter.Name = "dgv_PortfolioFooter";
            this.dgv_PortfolioFooter.ReadOnly = true;
            this.dgv_PortfolioFooter.Size = new System.Drawing.Size(842, 291);
            this.dgv_PortfolioFooter.TabIndex = 2;
            this.dgv_PortfolioFooter.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // Dummy
            // 
            this.Dummy.HeaderText = "";
            this.Dummy.Name = "Dummy";
            this.Dummy.ReadOnly = true;
            this.Dummy.Width = 598;
            // 
            // PortfolioDayGainLoss
            // 
            this.PortfolioDayGainLoss.DataPropertyName = "PortfolioDayGainLoss";
            dataGridViewCellStyle11.Format = "C3";
            this.PortfolioDayGainLoss.DefaultCellStyle = dataGridViewCellStyle11;
            this.PortfolioDayGainLoss.HeaderText = "Portfoliio Daily Gain/Loss";
            this.PortfolioDayGainLoss.Name = "PortfolioDayGainLoss";
            this.PortfolioDayGainLoss.ReadOnly = true;
            this.PortfolioDayGainLoss.Width = 135;
            // 
            // PortfolioDayGainLossPercent
            // 
            this.PortfolioDayGainLossPercent.DataPropertyName = "PortfolioDayGainLossPercent";
            dataGridViewCellStyle12.Format = "P";
            this.PortfolioDayGainLossPercent.DefaultCellStyle = dataGridViewCellStyle12;
            this.PortfolioDayGainLossPercent.HeaderText = "Portfolio Daily Gain/Loss %";
            this.PortfolioDayGainLossPercent.Name = "PortfolioDayGainLossPercent";
            this.PortfolioDayGainLossPercent.ReadOnly = true;
            this.PortfolioDayGainLossPercent.Width = 111;
            // 
            // Spacer
            // 
            this.Spacer.HeaderText = "";
            this.Spacer.Name = "Spacer";
            this.Spacer.ReadOnly = true;
            this.Spacer.Width = 139;
            // 
            // PortfolioInceptionGainLoss
            // 
            this.PortfolioInceptionGainLoss.DataPropertyName = "PortfolioInceptionGainLoss";
            dataGridViewCellStyle13.Format = "C3";
            this.PortfolioInceptionGainLoss.DefaultCellStyle = dataGridViewCellStyle13;
            this.PortfolioInceptionGainLoss.HeaderText = "Portfolio Inception Gain/Loss";
            this.PortfolioInceptionGainLoss.Name = "PortfolioInceptionGainLoss";
            this.PortfolioInceptionGainLoss.ReadOnly = true;
            this.PortfolioInceptionGainLoss.Width = 141;
            // 
            // PortfolioInceptionGainLossPercent
            // 
            this.PortfolioInceptionGainLossPercent.DataPropertyName = "PortfolioInceptionGainLossPercent";
            dataGridViewCellStyle14.Format = "P";
            this.PortfolioInceptionGainLossPercent.DefaultCellStyle = dataGridViewCellStyle14;
            this.PortfolioInceptionGainLossPercent.HeaderText = "Portfolio Inception Gain/Loss %";
            this.PortfolioInceptionGainLossPercent.Name = "PortfolioInceptionGainLossPercent";
            this.PortfolioInceptionGainLossPercent.ReadOnly = true;
            this.PortfolioInceptionGainLossPercent.Width = 99;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpen,
            this.toolStripSeparator,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(134, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(110, 22);
            this.tsbOpen.Text = "&Open Portfolio File";
            this.tsbOpen.ToolTipText = "Open Portfolio File";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 503);
            this.Controls.Add(this.toolStripContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Farallon Code Project: Portfolio Tracker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            tableLayoutOwner.ResumeLayout(false);
            tableLayoutOwner.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Positions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PortfolioFooter)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label lbl_PortfolioOwnerLabel;
        private System.Windows.Forms.Label lbl_OwnerEmail;
        private System.Windows.Forms.Label lbl_OwnerPhone;
        private System.Windows.Forms.Label lbl_OwnerName;
        private System.Windows.Forms.Label lbl_PortfolioNameLabel;
        private System.Windows.Forms.Label lbl_PortfolioName;
        private System.Windows.Forms.DataGridView dgv_Positions;
        private System.Windows.Forms.Label lbl_PortfolioNumber;
        private System.Windows.Forms.DataGridView dgv_PortfolioFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dummy;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortfolioDayGainLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortfolioDayGainLossPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spacer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortfolioInceptionGainLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn PortfolioInceptionGainLossPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Open;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyGainLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayGainLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayGainLossPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn InceptionGainLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGainLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGainLossPercentage;
    }
}

