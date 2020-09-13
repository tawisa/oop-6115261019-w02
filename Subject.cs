using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace oop_6115261019_w02
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private string subjectCredit;
        private string subjectNumberoflectures;
        private string subjectNumberofpracticeperiods;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }
        public string SubjectCredit
        {
            get { return subjectCredit; }
            set { subjectCredit = value; }
        }
        public string SubjectNumberoflectures
        {
            get { return subjectNumberoflectures; }
            set { subjectNumberoflectures = value; }
        }
        public string SubjectNumberofpracticeperiods
        {
            get { return subjectNumberofpracticeperiods; }
            set { subjectNumberofpracticeperiods = value; }
        }
        public Subject() { }
        public Subject(string sc, string sn, string scd, string snl, string snp)
        {
            this.subjectCode = sc;
            this.subjectName = sn;
            this.subjectCredit = scd;
            this.subjectNumberoflectures = snl;
            this.subjectNumberofpracticeperiods = snp;
        }
        public override string ToString()
        {
            return this.SubjectCode + this.SubjectName
                + this.SubjectCredit + this.SubjectNumberoflectures + this.SubjectNumberofpracticeperiods;
        }
    }
}
