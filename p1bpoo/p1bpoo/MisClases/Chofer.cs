using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfaces;

namespace p1bpoo.MisClases
{
    public class Chofer : IPiloto
    {
        public string Nombre { get; set; }
        public int edad { get; set; }
        public string tipoLicencia { get; set; } // A, B, C, M

        string IPiloto.Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IPiloto.edad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IPiloto.tipoLicencia { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //constructor 
        public Chofer(string name, int edadPiloto, string tipo)
        {
            Nombre = name;
            edad = edadPiloto;
            tipoLicencia = tipo;
        }

        public bool ValidarLicencia()
        {
            switch (tipoLicencia.ToUpper())
            {
                case "A":
                    return edad >= 23;
                case "B":
                    return edad >= 21;
                case "C":
                    return edad >= 16;
                case "M":
                    return edad >= 16;
                default:
                    return false;
            }
        }

        public void MostrarValidacion()
        {
            if (ValidarLicencia())
            {
                Console.WriteLine($"{Nombre} tiene la edad adecuada para obtener la licencia tipo {tipoLicencia} y conducir este vehiculo.");
            }
            else
            {
                Console.WriteLine($"{Nombre} Lo siento, no tiene la edad adecuada para obtener la licencia {tipoLicencia}.");
            }
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: {0}",  this.Nombre);
            Console.WriteLine("Edad: {0}", this.edad);
            Console.WriteLine("Tipo de Licencia: {0}", this.tipoLicencia);
        }
    }
    
}
