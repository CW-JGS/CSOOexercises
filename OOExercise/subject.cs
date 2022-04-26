using System;
namespace OOTest
{
    class Subject 
    {
        public string SubjectName {get; set;}
        public int YearOfDelivery {get; set;}
        public Subject(string pSubjectName,int pYearOfDelivery) {
            this.SubjectName = pSubjectName;
            YearOfDelivery = pYearOfDelivery;
        }
    }
}