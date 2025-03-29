using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Automovil : Vehiculo
    {
        private int Gasolina;
        public Automovil(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tiposLicenciaAceptados = new List<string> {"B"};
        }

        protected override int VelocidadMaxima { get; set; } = 110;
        protected override int CapacidadTanque { get; set; } = 95;
        protected override double ConsumoCombustible { get; set; } = 4.8;

        public void NivelGasolina()
        {
            Gasolina = 82;
            Console.WriteLine("Nivel de Gasolina: {0}", Gasolina);
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
            return "Licencia tipo B requerida para conducir Automovil.";
        }
    }
}
