using Examen02.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02.Clases
{
    public class Gerente : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override int SueldoBase => 8000;
        public decimal CalcularBonificacion()
        {
            int Bonificacion = 1000;
            return Bonificacion;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase+CalcularBonificacion()-DescontarSueldo();
            //return SueldoBase;
        }

        public decimal DescontarSueldo()
        {
            return SueldoBase*Constantes.DescuentoGerente;
        }
    }
}
