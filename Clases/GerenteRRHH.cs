using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clases
{
    public class GerenteRRHH : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override int SueldoBase => 7500;

        public decimal CalcularBonificacion()
        {
            return 0;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase+CalcularBonificacion()-DescontarSueldo(); 
        }

        public decimal DescontarSueldo()
        {
            return SueldoBase*Constantes.DescuentoGerenteRHH;
        }
    }
}
