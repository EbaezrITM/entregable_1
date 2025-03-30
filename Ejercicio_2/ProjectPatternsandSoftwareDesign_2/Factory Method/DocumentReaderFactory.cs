using ProjectPatternsandSoftwareDesign_2.DocumentReader;
using ProjectPatternsandSoftwareDesign_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_2.Factory_Method
{
    public class DocumentReaderFactory
    {
        public static IDocumentReader GetReader(String format) {

            switch (format.ToLower())
            {
                case "xlsx":
                    return new ExcelReader();
                case "docx":
                    return new WordReader();
                case "xml":
                    return new XmlReader();
                default:
                    throw new NotSupportedException("Formato no soportado");
            }

        }
    }
}
