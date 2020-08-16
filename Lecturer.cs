using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261003_w02
{
    class Lecturer
    {
        private string lecturerCode;
        private string lecturerName;
        private string lecturerLastname;
        private string lecturerPosition;

        public string LecturerCode
        {
            get { return lecturerCode; }
            set { lecturerCode = value; }
        }
        public string LecturerName
        {
            get { return lecturerName; }
            set { lecturerName = value; }
        }
        public string LecturerLastname
        {
            get { return lecturerLastname; }
            set { lecturerLastname = value; }
        }
        public string LecturerPosition
        {
            get { return lecturerPosition; }
            set { lecturerPosition = value; }
        }

        public Lecturer () { }
        public Lecturer (string lc,string ln,string ll,string lp)
        {
            this.lecturerCode = lc;
            this.lecturerName = ln;
            this.lecturerLastname = ll;
            this.lecturerPosition = lp;
        }

        public override string ToString()
        {
            return this.LecturerCode +
                this.LecturerName +
                this.LecturerLastname +
                this.LecturerPosition;
        }
    }
}
