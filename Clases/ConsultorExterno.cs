using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clases
{
    public class ConsultorExterno : EmpleadoBase, ISueldoBonificable
    {
        public override int SueldoBase => 5000;

        public decimal CalcularBonificacion()
        {
            return 0;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase+CalcularBonificacion();
        }
    }
}
