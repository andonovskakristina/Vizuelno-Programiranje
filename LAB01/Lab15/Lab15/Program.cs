using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    enum PasswordStrenght
    {
        easy,
        normal,
        hard
    }
    class Program
    {
        static string generatePassword(PasswordStrenght passwordStrenght)
        {
            if(passwordStrenght == PasswordStrenght.easy)
            {
                var chars = "abcdefghijklmnopqrstuvwxyz";
                var random = new Random();

                int size = random.Next(1, 7);
                var stringChars = new char[size];
                
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                return new String(stringChars);
            } else if(passwordStrenght == PasswordStrenght.normal)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var random = new Random();

                int size = random.Next(6, 11);
                var stringChars = new char[size];

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                return new String(stringChars);
            } else
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz*$-+?_&=!%{}/";
                var random = new Random();

                int size = random.Next(10,31);
                var stringChars = new char[size];

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                return new String(stringChars);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Внесете произволен број на лозинки одделени со празно место.");
            //string passLine = "lozinka1 test2 pogodok";
            string passLine = Console.ReadLine();
            char[] delimiter = { ' ' };
            string[] parts = passLine.Split(delimiter);

            string[] genPass = new string[3];
            genPass[0] = generatePassword(PasswordStrenght.easy);
            genPass[1] = generatePassword(PasswordStrenght.normal);
            genPass[2] = generatePassword(PasswordStrenght.hard);

            foreach(string part in parts)
            {
                if(part == genPass[0])
                {
                    Console.WriteLine("Внесена е easy лозинката.");
                } else if (part == genPass[1])
                {
                    Console.WriteLine("Внесена е normal лозинката.");
                } else if (part == genPass[2])
                {
                    Console.WriteLine("Внесена е hard лозинката.");
                } else
                {
                    Console.WriteLine("Внесена е погрешна лозинка.");
                }
            }

            Console.ReadKey();
        }
    }
}
