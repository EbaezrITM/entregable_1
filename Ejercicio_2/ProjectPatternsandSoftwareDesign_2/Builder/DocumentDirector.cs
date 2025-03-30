using ProjectPatternsandSoftwareDesign_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_2.Builder
{
    public class DocumentDirector
    {
        private readonly IPDFBuilder _builder;

        public DocumentDirector(IPDFBuilder builder)
        {
            _builder = builder;
        }

        public void Construct(string data)
        {
            _builder.AddText("Título del documento");
            _builder.AddTable(data);
            _builder.SetStyle("Negrita");
        }
    }
}
