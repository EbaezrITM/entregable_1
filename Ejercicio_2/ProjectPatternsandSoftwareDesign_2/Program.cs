using ProjectPatternsandSoftwareDesign_2.Builder;
using ProjectPatternsandSoftwareDesign_2.Factory_Method;
using ProjectPatternsandSoftwareDesign_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el formato de documento de origen (xlsx, docx, xml): ");
            string format = Console.ReadLine();

            IDocumentReader reader = DocumentReaderFactory.GetReader(format);
            string data = reader.ReadData();

            IPDFBuilder builder = new PdfDocumentBuilder();
            DocumentDirector director = new DocumentDirector(builder);
            director.Construct(data);


            ((PdfDocumentBuilder)builder).ShowDocument();
        }
    }
}
