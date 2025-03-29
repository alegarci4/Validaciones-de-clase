using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{

    public class Trailer : Vehiculo
    {
        private string Chasis = " El Trailer posee Chasis de carga";
        public Trailer(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> { "A" };
        }

        protected override int VelocidadMaxima { get; set; } = 135;
        protected override int CapacidadTanque { get; set; } = 120;
        protected override double ConsumoCombustible { get; set; } = 7.45;



        public void VerChasis()
        {
            Console.WriteLine("{0}", Chasis);

        }


        public override void acelerar(int cuanto)
        {
            if (velocidad + cuanto <= VelocidadMaxima)
            {
                velocidad += cuanto;
                Console.WriteLine("Has acelerado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede exceder la velocidad máxima de {0} km/h.", VelocidadMaxima);
            }
        }

        public override void Frenar(int cuanto)
        {
            if (velocidad - cuanto >= 0)
            {
                velocidad -= cuanto;
                Console.WriteLine("Has frenado a {0} km/h.", velocidad);
            }
            else
            {
                Console.WriteLine("No se puede frenar más.");
            }
        }

        public override string TipoLicencia()
        {
            return "Licencia tipo A requerida para conducir Trailer.";
        }

    }
}
