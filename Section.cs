using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace oop_6115261019_w02
{
    class Section
    {
        private string sectionClassroom;
        private string sectionBuilding;
        private string sectionCourse;
        private string sectionInstructor;
        private string sectionDay;
        private string sectionStarttime;
        private string sectionEndtime;

        public string SectionClassroom
        {
            get { return sectionClassroom; }
            set { sectionClassroom = value; }
        }
        public string SectionBuilding
        {
            get { return sectionBuilding; }
            set { sectionBuilding = value; }
        }
        public string SectionCourse
        {
            get { return sectionCourse; }
            set { sectionCourse = value; }
        }
        public string SectionInstructor
        {
            get { return sectionInstructor; }
            set { sectionInstructor = value; }
        }
        public string SectionDay
        {
            get { return sectionDay; }
            set { sectionDay = value; }
        }
        public string SectionStarttime
        {
            get { return sectionStarttime; }
            set { sectionStarttime = value; }
        }
        public string SectionEndtime
        {
            get { return sectionEndtime; }
            set { sectionEndtime = value; }
        }
        public Section() { }
        public Section(string scr, string sb, string sc, string si,string sd,string ss,string se)
        {
            this.sectionClassroom = scr;
            this.sectionBuilding = sb;
            this.sectionCourse = sc;
            this.sectionInstructor = si;
            this.sectionDay = sd;
            this.sectionStarttime = ss;
            this.sectionEndtime = se;
         
        }

        public override string ToString()
        {
            return this.SectionClassroom + this.SectionBuilding
                + this.SectionCourse + this.SectionInstructor + this.SectionDay + this.SectionStarttime + this.SectionEndtime;
        }

    }
}
