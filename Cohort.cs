using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Cohort
    {
        public string Name {get; set;}
        public List<Student> StudentList {get; set;}
        public List<Instructor> InstructorList {get; set;}

        public Cohort(string name) {
            Name = name;
            StudentList = new List<Student>();
            InstructorList = new List<Instructor>();
        }
    }
}