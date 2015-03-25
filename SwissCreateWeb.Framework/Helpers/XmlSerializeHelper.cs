using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
namespace SwissCreateWeb.Framework.Helpers
{
    public interface IXmlSerializeHelper
    {
        string XmlSerializeObject<T>(T obj) where T : class;

        string XmlSerializeObjectWithoutXmlHeader<T>(T obj) where T : class;

        T XmlDeserializeObject<T>(string xml) where T : class;
    }

    public class XmlSerializeHelper : IXmlSerializeHelper
    {
        public string XmlSerializeObject<T>(T obj) where T : class
        {
            StringBuilder XmlizedString = new StringBuilder();

            XmlSerializer xs = new XmlSerializer(typeof(T));

            XmlWriterSettings settings = new XmlWriterSettings() { };
            settings.OmitXmlDeclaration = true;
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;

            XmlWriter xmlTextWriter = XmlTextWriter.Create(XmlizedString, settings);

            xs.Serialize(xmlTextWriter, obj);

            string xmlDeclarationUTF8 = string.Empty; //string xmlDeclarationUTF8 = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
            return xmlDeclarationUTF8 + XmlizedString.ToString();
        }

        public string XmlSerializeObjectWithoutXmlHeader<T>(T obj) where T : class
        {
            StringBuilder XmlizedString = new StringBuilder();

            XmlSerializer xs = new XmlSerializer(typeof(T));

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;

            XmlSerializerNamespaces xmlnsEmpty = new XmlSerializerNamespaces();
            xmlnsEmpty.Add("", "");

            XmlWriter xmlTextWriter = XmlTextWriter.Create(XmlizedString, settings);
            xs.Serialize(xmlTextWriter, obj, xmlnsEmpty);

            return XmlizedString.ToString();
        }

        public T XmlDeserializeObject<T>(string xml) where T : class
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            XmlTextReader xmlTextReader = new XmlTextReader(new StringReader(xml));

            return (T)xs.Deserialize(xmlTextReader);
        }
    }
}
