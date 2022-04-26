using System;

namespace OOTest
{
    class Person
    {
        Random rand = new Random();
        public string FirstName {get; set;}
        public string Surname {get;set;}
        public string DOB {get;set;}
        public int Height {get;set;}
        public int Id {get;}
        public List<Subject> SubjectsList = new List<Subject>();
        public Person (string pFirstName, string pSurname, string pDOB, int pHeight) {
            FirstName = pFirstName;
            Surname = pSurname;
            DOB = pDOB;
            Height = pHeight;
            this.Id = rand.Next(1001, 9999);
        }
        public string GetFullName(){
            return String.Format(" {0}, {1}", FirstName, Surname);
        }
        public string GetHeightDifference(Person otherPerson) {
            return String.Format(" The height Difference is {0} cm", (Height - otherPerson.Height));
        }
        public void Enrol(Subject newSubject) {
            SubjectsList.Add(newSubject);
            System.Console.WriteLine(" you are now enrolled in {0}",newSubject.SubjectName);
        }
        public List<Subject> getSubjects() {
            return SubjectsList;
        }
    }
}