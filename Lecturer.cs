using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261019_w02
{
    class Lecturer
    {
        private string lecturerName;
        private string lecturerSurname;
        private string lecturerPosition;

        public string LecturerName
        {
            get { return lecturerName; }
            set { lecturerName = value; }
        }
        public string LecturerSurname
        {
            get { return lecturerSurname; }
            set { lecturerSurname = value; }
        }
        public string LecturerPosition
        {
            get { return lecturerPosition; }
            set { lecturerPosition = value; }
        }

        public Lecturer() { }
        public Lecturer(string ln, string ls, string lp)
        {
            this.lecturerName = ln;
            this.lecturerSurname = ls;
            this.lecturerPosition = lp;
        }

        public override string ToString()
        {
            return this.lecturerName + this.lecturerSurname
                + this.lecturerPosition ;
        }

    }
}
