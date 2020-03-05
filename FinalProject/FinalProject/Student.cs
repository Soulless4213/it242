using FinalProject;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Student
    {
        private string firstname;

        public Student(string firstName, string lastName)
        {
            FirstName = firstname;
            LastName = lastName;
            Assignments = new List<Cohort>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Cohort> Assignments { get; set; }
        public Cohort Cohort { get; set; }
    }
}
