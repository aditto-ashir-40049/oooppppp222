using System;
using System.Collections.Generic;
using System.Text;

namespace Labtask6
{
    class Student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;
        public void student(String Name, String Id, String Department, float Cgpa)
        {
            name = Name;
            id = Id;
            department = Department;
            cgpa = Cgpa;
        }
        public void ShowStudent()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Id :" + id);
            Console.WriteLine("Department :" + department);
            Console.WriteLine("Cgpa :" + cgpa);
        }
    }
}