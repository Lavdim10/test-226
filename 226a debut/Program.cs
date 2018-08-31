using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _226a_debut
{
    class Program
    {
        #region private attributes
        private static char Add = '+';
        private static char Sous = '-';
        private static char Div = '/';
        private static char Multi = '*';
        private static int operande1= 4;
        private static int operande2 = 2;
        private static int resultatAdd = 0;
        private static int resultatSous = 0;
        private static int resultatdiv = 0;
        private static int resultatMulti = 0;
        #endregion private attributes

        /// <summary>
        /// This function is designes as entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           

            Console.WriteLine("Le résultat du calcul " + operande1 + Add + operande2 );
            resultatAdd = additionner(operande1, operande2);
            Console.Write(resultatAdd);
          

            Console.WriteLine("\n Le résultat du calcul " + operande1 + Sous + operande2);
            resultatSous = soustraction(operande1, operande2);
            Console.Write(resultatSous);

            if (operande1 == 0 || operande2 == 0)
            {
                Console.WriteLine("\n Le résultat du calcul " + operande1 + Div + operande2);
                Console.WriteLine("\n La division par 0 n'est pas possible");
            }
            else
            {
                Console.WriteLine("\n Le résultat du calcul " + operande1 + Div + operande2);
                resultatdiv = division(operande1, operande2);
                Console.Write(resultatdiv);
            }
            
           
                Console.WriteLine("\n Le résultat du calcul " + operande1 + Multi + operande2);
                resultatMulti = multiplication(operande1, operande2);
                Console.Write(resultatMulti);
                Console.ReadLine();
             

        }
        private static int additionner(int number1, int number2)
        {
            return number1 + number2;

        }
        private static int soustraction(int number1, int number2)
        {
            return number1 - number2;

        }
        private static int division(int number1, int number2)
        {
            if (operande1 == 0 || operande2 == 0)
            {
                return 0;
            }
            else
            {
                return number1 / number2;
            }
                

        }
        private static int multiplication(int number1, int number2)
        {
            return number1 * number2;

        }

    }
}

