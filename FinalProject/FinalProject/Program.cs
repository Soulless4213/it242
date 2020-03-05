using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {



            //            Create 4, or more, exercises.
            //Create 3, or more, cohorts.
            //Create 4, or more, students and assign them to one of the cohorts.
            //Create 3, or more, instructors and assign them to one of the cohorts.
            //Have each instructor assign 2 exercises to each of the students.


            //Exercises
            Exercise Assignment1 = new Exercise
            {
                Assignments = "First Assignment",
                LanguageType = "Python"
            };
            Exercise Assignment2 = new Exercise
            {
                Assignments = "Second Assignment",
                LanguageType = "Javascript"
            };
            Exercise Assignment3 = new Exercise
            {
                Assignments = "Third Assignment",
                LanguageType = "Javascript"
            };
            Exercise Assignment4 = new Exercise
            {
                Assignments = "Fourth Assignment",
                LanguageType = "Python"
            };
            Exercise Assignment5 = new Exercise
            {
                Assignments = "Fifth Assignment",
                LanguageType = "C#"
            };



            //Cohorts
            Cohort Programming101 = new Cohort("Programming 101");
          
            Cohort Programming102 = new Cohort("Programming 102");

            Cohort Programming103 = new Cohort("Programming 103");
          


            //Instructors
            Instructor One = new Instructor("Bob", "Ross");
            Instructor Two = new Instructor("John", "Billboard");
            Instructor Three = new Instructor("Cory", "Reading");
            Instructor Four = new Instructor("James", "Brown");


            //Students
            Student One1 = new Student("Austin", "Fury");
            Student Two2 = new Student("Jamie", "Johnson");
            Student Three3 = new Student("Barbosa", "Rock");
            Student Four4 = new Student("Dillon", "Vance");

            One.AddExercise(One1, Assignment1);
            One.AddExercise(One1, Assignment2);

            Two.AddExercise(Two2, Assignment1);
            Two.AddExercise(Two2, Assignment2);

            Three.AddExercise(Three3, Assignment1);
            Three.AddExercise(Three3, Assignment2);

            Four.AddExercise(Four4, Assignment1);
            Four.AddExercise(Four4, Assignment2);



            Console.WriteLine("");
        }
    }
}