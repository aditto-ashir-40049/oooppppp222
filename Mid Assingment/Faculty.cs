using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid_Assingment
{
    class Faculty
    {
        private string facultyName;
        private string facultyId;
        private double totalHourOfTeaching;
        public string FacultyName
        {
            set { facultyName = value; }
            get { return facultyName; }
        }
        public string FacultyId
        {
            set { facultyId = value; }
            get { return facultyId; }
        }
        public double TotalHourOfTeaching
        {
            set { totalHourOfTeaching = value; }
            get { return totalHourOfTeaching; }
        }
        public Faculty()
        {
        }
        public Faculty(string facultyName, string facultyId, double totalHourOfTeaching)
        {
            this.facultyName = facultyName;
            this.facultyId = facultyId;
            this.totalHourOfTeaching = totalHourOfTeaching;
        }
        public void showFacultyInfo()
        {
            Console.WriteLine("Faculty Name" + facultyName);
            Console.WriteLine("FacultyId" + facultyId);
        }
        public void showSectionsInfo()
        {

            int i = 0;
            int sectionCount = 0;
            do
            {
                Section(i).ShowInfo();
                i++;
            } while (i < sectionCount);



        }

        }
    }