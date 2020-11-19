using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Assingment
{
    class Department
    {
        private string departmentName;
        private int departmentId;
        private int totalCourse;
        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        public int TotalCourse
        {
            get { return totalCourse; }
            set { totalCourse = value; }
        }
        public Department()
        {
            listOfcourses = new Course[100];

        }
        public Department(string departmentName)
        {
           DepartmentName = departmentName;
            listOfcourses = new Course[100];

        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + departmentName);
            Console.WriteLine("ID: " + departmentId);
            Console.WriteLine("Total : " + totalCourse);
        }
        public void addCourse(Course courseName)
        {
            this.CourseName[coursecount++] = courseName;
        }
        public void ShowAllCourse()
        {
            int i=0;
            do
            {
                listOfcourses[i].ShowInfo();
                i++;
            
            }while (i < totalCourse) ;
        }
    }
}