using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261003_w02
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private string subjectCredit;
        private string subjectLecture;
        private string subjectPractice;

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
        public string SubjectLecture
        {
            get { return subjectLecture; }
            set { subjectLecture = value; }
        }
        public string SubjectPractice
        {
            get { return subjectPractice; }
            set { subjectPractice = value; }
        }

        public Subject () { }
        public Subject (string sco,string sn,string scr,string sl,string sp)
        {
            this.subjectCode = sco;
            this.subjectName = sn;
            this.subjectCredit = scr;
            this.subjectLecture = sl;
            this.subjectPractice = sp;
        }

        public override string ToString()
        {
            return this.SubjectCode  +
                this.SubjectName +
                this.SubjectCredit +
                this.SubjectLecture +
                this.SubjectPractice;
        }
    }
}
