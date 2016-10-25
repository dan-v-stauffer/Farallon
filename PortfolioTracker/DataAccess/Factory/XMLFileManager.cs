using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using DataAccess.Models;

namespace DataAccess.Factory
{
    //class to manage deserialization of xml portfolio  file into model objects
    public class XMLFileManager
    {
        #region Members
        private string _filepath;
        #endregion

        #region Constructor
        public XMLFileManager(String filePath)
        {
            _filepath = filePath;
        }
        #endregion

        #region Public Methods
        public Portfolio GetPortfolio()
        {
            Portfolio portfolio;

            validateXml();

            using (FileStream stream = new FileStream(_filepath, FileMode.Open, FileAccess.Read))
            {
                portfolio = SerializationHelper<Portfolio>.Deserialize(stream);
            }

            return portfolio;
         }
        #endregion

        #region Private Methods
        private void validateXml()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            XmlReaderSettings settings = new XmlReaderSettings();

            Assembly myAssembly = Assembly.GetExecutingAssembly();

            using (Stream schemaStream = myAssembly.GetManifestResourceStream("DataAccess.Models.portfolioSchema.xsd"))
            {
                XmlSchema schema = XmlSchema.Read(schemaStream, null);
                settings.Schemas.Add(schema);
                settings.ValidationType = ValidationType.Schema;
            }
            XmlReader reader = XmlReader.Create(_filepath, settings);
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(reader);
            }
            catch(Exception ex)
            {
                throw new XmlException("Invalid portfolio file.");
            }
            ValidationEventHandler eventHandler = new ValidationEventHandler(settings_ValidationEventHandler);
            document.Validate(eventHandler);
        }

        private void settings_ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
                throw new XmlException("Invalid portfolio file.");
        }
        #endregion
    }
}

