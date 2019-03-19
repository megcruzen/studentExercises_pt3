using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Slack {get; set;}
        public Cohort Cohort {get; set;}

        public Instructor(string firstname, string lastname, string slack, Cohort cohort) {
            FirstName = firstname;
            LastName = lastname;
            Slack = slack;
            Cohort = cohort;
        }

        // Method to assign an exercise to all students in a cohort
        public void AssignExercise(Cohort cohort, Exercise exercise) {
            // loop over each student per cohort
            foreach (Student student in cohort.StudentList) {
                student.ExerciseList.Add(exercise);
                // Console.WriteLine($"{exercise.Name} was added to {student.FirstName}'s list");
            }
        }

        // Method to assign specific exercises to specific students
        // public void AssignExercise2(Student student, Exercise exercise) {
        //         student.ExerciseList.Add(exercise);
        //         Console.WriteLine($"{FirstName} assigned {exercise.Name} to {student.FirstName}");
        // }
    }
}