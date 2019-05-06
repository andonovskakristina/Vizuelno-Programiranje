using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class Equation
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public char Operator { get; set; }
        public int Rezultat { get; set; }

        public char[] MozniOperatori = { '+', '-', '*', '/' };

        public Random Random;

        public Equation()
        {
            Random = new Random();

            int index = Random.Next(MozniOperatori.Length);
            Operator = MozniOperatori[index];

            Operand1 = Random.Next(1, 100);

            if (Operator == '-')
            {
                Operand2 = Random.Next(1, Operand1);
                Rezultat = Operand1 - Operand2;
            }
            else if (Operator == '/')
            {
                while (true)
                {
                    Operand2 = Random.Next(1, 100);
                    if (Operand1 % Operand2 == 0)
                        break;
                }
                Rezultat = Operand1 / Operand2;
            }
            else if (Operator == '+')
            {
                Operand2 = Random.Next(1, 100);
                Rezultat = Operand1 + Operand2;
            }
            else if (Operator == '*')
            {
                Operand2 = Random.Next(1, 100);
                Rezultat = Operand1 * Operand2;
            }
        }
    }
}
