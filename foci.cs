using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class foci
    {

        public int fordulo { get; set; }
        public int hazaigol { get; set; }
        public int vendeggol { get;  set; }
        public int hfelido { get;  set; }
        public int vfelido { get;  set; }
        public string hazai { get; set; }
        public string vendeg { get; set; }

        public foci(int fordulo, int hazaigol, int vendeggol, int hfelido, int vfelido, string hazai, string vendeg)
        {
            this.fordulo = fordulo;
            this.hazaigol = hazaigol;
            this.vendeggol = vendeggol;
            this.hfelido = hfelido;
            this.vfelido = vfelido;
            this.hazai = hazai;
            this.vendeg = vendeg;
        }

    }
}
