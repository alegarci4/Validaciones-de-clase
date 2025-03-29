using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.Interfaces
{
    public interface IPiloto
    {
        string Nombre { get; set; }
        int edad { get; set; }
        string tipoLicencia { get; set; } // A, B, C, M
        void MostrarInformacion();
    }
}
