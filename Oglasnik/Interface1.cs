using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oglasnik
{
    interface IPriklopnik
    {
        double MaxDolzinaKompozicije { get; set; }
        double MaxObremenitevOsi { get; set; }
        bool ZracneZavore { get; set; }
    }
}
