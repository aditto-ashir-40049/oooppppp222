using System;
using System.Collections.Generic;
using System.Text;

namespace Mid_Assingment
{
    class Section
    {

        private string sectionName;
        private string sectionId;
        public string SectionName
        {
            set { sectionName = value; }
            get { return sectionName; }
        }
        public string SectionId
        {
            set { sectionId = value; }
            get { return sectionId; }
        }
        public Section(string SectionName, string SectionId)
        {
            this.sectionName = SectionName;
            this.sectionId = SectionId;
        }
        private Faculty[] faculties;
        private int facultyCount;

        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }
        Faculty facultyName;
        public void AddFaculty(Faculty facultyName)
            
              if(facultyCount<21)
            {
                
                   this.facultyName= facultyName;
            }  
            else 
            
    {
    Console.WriteLine("Don't take more than 21 hour");

    }
       public void showInfo()
{
         Console.WriteLine("Section Name"+SectionName);
          Console.WriteLine("Section Id" + sectionId);
}

