using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261003_w02
{
    class Studygroup
    {
        private string studygroupCode;
        private string studygroupName;
        private string studygroupDegree;

        public string StudygroupCode
        {
            get { return studygroupCode; }
            set { studygroupCode = value; }
        }
        public string StudygroupName
        {
            get { return studygroupName; }
            set { studygroupName = value; }
        }
        public string StudygroupDegree
        {
            get { return studygroupDegree; }
            set { studygroupDegree = value; }
        }

        public Studygroup () { }
        public Studygroup (string sgc,string sgn,string sgd)
        {
            this.studygroupCode = sgc;
            this.studygroupName = sgn;
            this.StudygroupDegree = sgd;
        }

        public override string ToString()
        {
            return this.StudygroupCode +
                this.StudygroupName +
                this.studygroupDegree;
        }
    }
}
