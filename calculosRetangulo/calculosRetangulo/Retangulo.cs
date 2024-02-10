using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculosRetangulo
{
    public class Retangulo
    {
        public double Largura;
        public double Altura;



        public override string ToString()
        {
            return "AREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                + "\nPERIMETRO = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\nDIAGONAL = "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            double diag = Math.Pow(Largura, 2) + Math.Pow(Altura, 2);
            return Math.Sqrt(diag);
        }
    }
}
