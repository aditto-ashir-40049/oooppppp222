using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Assingment
{
    class Course
    {
        private string courseName;
        private string courseId;
        private int addCourse;
        public void course(string CourseName, string CourseId, int AddCourse)
        {
            this.courseName = CourseName;
            this.courseId = CourseId;
            this.addCourse = AddCourse;
        }
        public string CourseName
        {
            set { courseName = value; }
            get { return courseName; }
        }
        public string  CourseId
        {
            set { courseId = value; }
            get { return courseId; }
        }
        public int AddCourse
        {
            set { addCourse = value; }
            get { return addCourse; }
        }
        public void ShowCourses()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Course Id: " + CourseId);
            Console.WriteLine("Added courses: " + AddCourse);
        }
        private Section[] Sections;
        private int totalSection;
        public void AddSection(int section)
        {
            this.AddCourse = section;
        }
        public int TotalSection
        {
            get { return TotalSection; }
            set { TotalSection = value; }
        }
        public Course()
        {
            listOfSection = new Section[100];
        }
        public Section(string SectionName)
        {
            this.SectionName = SectionName;
        }
        public int totalSection
        {
            set { TotalSection = value; }
            get { return TotalSection; }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Total section : " + TotalSection);
        }
        public void AddSection(params Section[] Section)
        {
            foreach (var Sections in Sections)

            {
                if (TotalSection < 100)
                    listOfSection[TotalSection++] = Section;
            }
        }
        public void ShowAllSection()
        {
            int i = 0;
            do
            {
                listOfSection[i].ShowInfo();
                i++;
               }while(i< TotalSection) ;
        }
    }
}