using System;

namespace Mid_Assingment
{
    class Program
    {

        static void Main(string[] args)
        {
            Department d = new Department("CS");
            Course C1 = new Course();
            d.AddCourse(C1)

            d.ShowAllCourse();
            Department d2 = new Department();

            d2.ShowAllCourse();
            Section s = new Section("df","ds");
            s.Section();
            s.ShowInfo();

            string[] section = { "parana", "thams", " jupiter", " pluto" }
            double[] teachingHour = { 4, 1, 2 };

            ob.courselist = new Course[15];
            for (int i = 0; i < 10; i++)
            {
                ob.courselist[i] = new Course
                {
                    Name = "cse " + (i + 1),
                    TeachingHour = teachingHour[i],
                    numOfSec = seclist[i]
                };
            }
            string[] facultyList = { "Aditto", "MIM", "Mahinur", "Kamal" }

            Faculty[] facultyArray = new Faculty[2];
            for (int i = 0; i < 10; i++)
            {
                facultyArray[i] = new Faculty
                {
                    FacultyName = facultyList[i],
                    FacultyId = facultyIdList[i]
                };
            }

            for (int i = 0; i < 4; i++)
            {

                {
                    if (facultyArray[i].HourperWeek < 21)
                    {
                        facultyArray[i].HourperWeek = facultyArray[i].HourperWeek + C.courselist[i].TeachingHour;
                        C.courselist[i].Section[j].teacher = new Faculty
                        {
                            FacultyName = facultyArray[i].FacultyName,
                            FacultyId = facultyArray[i].FacultyId;
                    };
                }

            }
        }
    }
}
}
