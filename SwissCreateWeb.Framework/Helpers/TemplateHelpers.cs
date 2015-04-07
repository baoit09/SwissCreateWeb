using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissCreateWeb.Framework.Helpers
{
    public class TemplateHelpers
    {
        public static string GetXMLContent(string sFilePath)
        {
            string sXMLContent = File.ReadAllText(sFilePath);
            return sXMLContent;
        }

        public static List<string> GetTemplates(string sFolderPath)
        {
            DirectoryInfo di = new DirectoryInfo(sFolderPath);
            var files = di.GetFiles().Select(fi => fi.Name).ToList();
            return files;
        }
    }
}
