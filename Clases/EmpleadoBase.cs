using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clases
{
    public abstract class EmpleadoBase: IEmpleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public abstract int SueldoBase { get; }

        public abstract decimal CalcularSueldo();
        
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}, Puesto: {Puesto}, Sueldo Base: {SueldoBase}");
            //Console.WriteLine("Nombre:");
            //Console.WriteLine(Nombre);
        }

        public void ObtenerDatos (int IdEmpleadoX, string NombreX, string PuestoX)
        {
            IdEmpleado = IdEmpleadoX;
            Nombre = NombreX;
            Puesto = PuestoX;
        }
    }
}
