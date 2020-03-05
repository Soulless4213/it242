using System;
using System.Collections.Generic;
using System.Text;
using FinalProject;

namespace FinalProject
{
    class Cohort
    {
       
        
        public Cohort(string cohortName)
        {
            CohortName = cohortName;
            Student = new List<Student>();
        }
        public string CohortName { get; set; }

        public List<Student> Student { get; set;  }

        public List<Instructor> Instructor { get; set;  }

        public void AddInstructor(Instructor instructor)
        {
            instructor.Cohort = this;
            Instructor.Add(instructor);
        }

        public void AddStudent(Student student)
        {
            student.Cohort = this;
            Student.Add(student);
        }

        //        Cohort
        //You must define a type for representing a cohort in code.

        //The cohort's name (Cohort 6, Cohort 25, etc.)
        //make a constructor that accepts the cohorts name
        //The collection of students in the cohort.Hint: a List of<Student>
        //The collection of instructors in the cohort. Hint: a List of<Instructor>




    }
}