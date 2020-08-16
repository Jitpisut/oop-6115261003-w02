using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261003_w02
{
    class Section
    {
        private string sectionCode;
        private string sectionRoom;
        private string sectionBuilding;
        private string sectionSubject;
        private string sectionLecturer;
        private string sectionDay;
        private string sectionStartTime;
        private string sectionLastTime;

        public string SectionCode
        {
            get { return sectionCode; }
            set { sectionCode = value; }
        }
        public string SectionRoom
        {
            get { return sectionRoom; }
            set { sectionRoom = value; }
        }
        public string SectionBuilding
        {
            get { return sectionBuilding; }
            set { sectionBuilding = value; }
        }
        public string SectionSubject
        {
            get { return sectionSubject; }
            set { sectionSubject = value; }
        }
        public string SectionLecturer
        {
            get { return sectionLecturer; }
            set { sectionLecturer = value; }
        }
        public string SectionDay
        {
            get { return sectionDay; }
            set { sectionDay = value; }
        }
        public string SectionStartTime
        {
            get { return sectionStartTime; }
            set { sectionStartTime = value; }
        }
        public string SectionLastTime
        {
            get { return sectionLastTime; }
            set { sectionLastTime = value; }
        }
        public Section () { }
        public Section (string sec,string ser,string seb,string ses,string sel,string sed,string sest,string selt)
        {
            this.sectionCode = sec;
            this.sectionRoom = ser;
            this.sectionBuilding = seb;
            this.sectionSubject = ses;
            this.sectionLecturer = sel;
            this.sectionDay = sed;
            this.sectionStartTime = sest;
            this.sectionLastTime = selt;
        }

        public override string ToString()
        {
            return this.SectionCode +
                this.SectionRoom +
                this.SectionBuilding +
                this.SectionSubject +
                this.SectionLecturer +
                this.SectionDay +
                this.SectionStartTime +
                this.SectionLastTime;
        }
    }
}
