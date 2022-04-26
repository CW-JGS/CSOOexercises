using System;

namespace OOTest
{
    class Task1
    {
        public void runTask1() {
            Cookie cookie1 = new Cookie(10, "circular", new int[] {100,100,50});
            System.Console.WriteLine(" cookie 1 : {0}",cookie1.ToString());
            Cookie cookie2 = new Cookie(12, "circular", new int[] {50,100,50});
            System.Console.WriteLine(" cookie 2 : {0}",cookie2.ToString());
            Cookie cookie3 = new Cookie(13, "circular", new int[] {100,100,50});
            System.Console.WriteLine(" cookie 3 : {0}",cookie3.ToString());
            Cookie cookie4 = new Cookie(14, "circular", new int[] {50,100,50});
            System.Console.WriteLine(" cookie 4 : {0}",cookie4.ToString());
            System.Console.WriteLine(" 4 cookies created");

        }
        public Task1() {
            runTask1();
        }
    }
}