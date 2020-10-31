using System;

namespace labTask3
{
    using System;

    namespace labTask3
    {
        class TestStudent
        {
            public static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.student("Aditto Al Ashir", "19-40049-1", "CS", 2.99);
                s1.ShowInfo();
                Triangle t1 = new Triangle();
                t1.triangle(11, 12, 10);
                t1.display();
                t1.TestTriangle();
                Account a1 = new Account();
                a1.account("Aditto Al Ashir", "701-701-5315782", 1000);
                a1.output();
                a1.Deposit(500);
                a1.Withdraw(200);
                Course c1 = new Course();
                c1.course("Object Oriented Programming 2", "c#", 3);
                c1.ShowCourseInfo();


            }
        }
    }
}