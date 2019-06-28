using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tria
{
    class Triangulo
    {
        private double ladoA;
        private double ladoB;
        private double ladoC;

        public double LadoA { get => ladoA; set => ladoA = value; }
        public double LadoB { get => ladoB; set => ladoB = value; }
        public double LadoC { get => ladoC; set => ladoC = value; }

        //Calcular a área do trinângulo.
        public double CalculaArea()
        {
            double p = (ladoA + ladoB + ladoC)/2;
            double area =  Math.Sqrt( ((p * p) - (p * ladoA)) * ((p * p - p * ladoC) - (ladoB * p) + (ladoB * ladoC)) );

            return (area);

        }

        //Calcular o perímetro do trinângulo.
        public double CalculaPerimetro()
        {
            return (this.ladoA + this.ladoB + this.ladoC);
        }
    }
}
