using ProjectPatternsandSoftwareDesign_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_2.DocumentReader
{
    public class ExcelReader : IDocumentReader
    {
        public string ReadData()
        {
            return "Documento leído de Excel";
        }
    }
}
