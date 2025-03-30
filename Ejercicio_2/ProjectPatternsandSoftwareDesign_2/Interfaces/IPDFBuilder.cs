using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPatternsandSoftwareDesign_2.Interfaces
{
    public interface IPDFBuilder
    {
        void AddTable(string data);
        void AddText(string text);
        void SetStyle(string style);
    }
}
