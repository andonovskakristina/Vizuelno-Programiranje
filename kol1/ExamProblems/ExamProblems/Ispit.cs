using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProblems
{
    public class Ispit
    {
        public string Mesec { get; set; }
        public int Godina { get; set; }
        public Zadaca Zadaca1 { get; set; }
        public Zadaca Zadaca2 { get; set; }

        public Ispit()
        {
            Zadaca1 = new Zadaca();
            Zadaca2 = new Zadaca();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Mesec, Godina);
        }
    }
}
