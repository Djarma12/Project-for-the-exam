using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static int unosBroja()
        {
            Console.WriteLine("Unesite broj: ");
            int broj = Convert.ToInt32(Console.ReadLine());
            return broj;
        }

        static double[] unosNiza(int broj)
        {
            double[] niz = new double[broj];
            for(int i=0; i < niz.Length; i++)
            {
                Console.WriteLine("Unesite decimalan broj: ");
                niz[i] = Convert.ToDouble(Console.ReadLine());
            }
            return niz;
        }

        static double najveciIznos(double[] niz)
        {
            double max = niz[0];
            for (int i=0; i<niz.Length; i++)
            {
                if (max < niz[i])
                {
                    max = niz[i];
                }
            }
            return max;
        }

        static void poziv()
        {
            int N1=unosBroja();
            Console.WriteLine("Unesite " + N1 + " iznosa novcanih priloga.");
            double[] niz1 = unosNiza(N1);
            double maxBr1 = najveciIznos(niz1);

            int N2 = unosBroja();
            Console.WriteLine("Unesite " + N2 + " iznosa novcanih priloga.");
            double[] niz2 = unosNiza(N2);
            double maxBr2 = najveciIznos(niz2);

            Console.WriteLine("Najveci novcani iznos prvog priloga je: " + maxBr1);
            Console.WriteLine("Najveci novcani iznos drugog priloga je: " + maxBr2);

            if (maxBr1 > maxBr2)
            {
                Console.WriteLine("Prvi novcani prilog je veci.");
            }else if(maxBr1 < maxBr2)
            {
                Console.WriteLine("Drugi novcani prilog je veci.");
            }
            else
            {
                Console.WriteLine("Novcani prilozi su jednaki.");
            }

        }

        static void Main(string[] args)
        {
            poziv();
            Console.ReadLine();
        }
    }
}