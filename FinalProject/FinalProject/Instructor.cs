using FinalProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Instructor
    {
        private string firstname;

        public Instructor(string firstName, string lastName)
        {
            FirstName = firstname;
            LastName = lastName;
        }

        public string FirstName { get; set;  }
        public string LastName { get; set; }
        public Cohort Cohort { get; set; }
        private string Slackhandle { get; set; }
        public string Specialty { get; set; }

        public void AddExercise(Student student,Exercise exercise)
        {
            student.Assignments.Add(exercise);
        }

    }
}
