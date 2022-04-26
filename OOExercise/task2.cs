using System;

namespace OOTest
{
    class Task2
    {
        public void runTask2() {
            Person person1 = new Person("John","Doe", "1st of april, 2003", 182);
            Person person2 = new Person("Jane","Doe", "1st of april, 2003", 156);
            Person person3 = new Person("Jack","Sutton", "13th of september, 2003", 177);
            System.Console.WriteLine(person1.GetFullName());
            System.Console.WriteLine(person2.GetFullName());
            System.Console.WriteLine(person3.GetFullName());
            System.Console.WriteLine(person1.GetHeightDifference(person2));
            System.Console.WriteLine(person2.GetHeightDifference(person3));
            System.Console.WriteLine(person3.GetHeightDifference(person1));
            Subject Eng = new Subject("english", 2022);
            Subject Math = new Subject("Maths", 2022);
            Subject Sci = new Subject("Science", 2022);
            Subject PE = new Subject("Physical Education", 2022);
            Subject RE = new Subject("Religion", 2022);
            person1.Enrol(Eng);
            person1.Enrol(Math);
            person1.Enrol(Sci);
            person1.Enrol(PE);
            person1.Enrol(RE);
            foreach(Subject sub in person1.getSubjects()) {
                Console.Write(" {0},", sub.SubjectName );

            }




        }
        public Task2() {
            runTask2();
        }
    }
}