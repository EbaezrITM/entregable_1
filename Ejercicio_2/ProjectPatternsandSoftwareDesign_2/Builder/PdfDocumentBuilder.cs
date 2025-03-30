using ProjectPatternsandSoftwareDesign_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_2.Builder
{
    public class PdfDocumentBuilder : IPDFBuilder
    {

        private List<string> elements = new List<string>();

        public void AddTable(string data)
        {
            elements.Add("Tabla: " + data);
        }

        public void AddText(string text)
        {
            elements.Add("Texto: " + text);
        }

        public void SetStyle(string style)
        {
            elements.Add("Estilo: " + style);
        }

        public void ShowDocument()
        {
            Console.WriteLine("Documento PDF generado:");
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }

    }
}
