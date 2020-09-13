using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261019_w02
{
    class Programm
    {
        private string programmClassname;
        private string programmDegree;
        public string ProgrammClassname
        {
            get { return programmClassname; }
            set { programmClassname = value; }
        }
        public string ProgrammDegree
        {
            get { return programmDegree; }
            set { programmDegree = value; }
        }
        public Programm() { }
        public Programm(string pcn, string pdg)
        {
            this.programmClassname = pcn;
            this.programmDegree = pdg;
        }

        public override string ToString()
        {
            return this.ProgrammClassname + this.ProgrammDegree ;
        }

    }
}
