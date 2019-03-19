using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    internal class CohortCount {
        public Cohort Cohort { get; set; }
        public int Count { get; set; }
    }

    class Program
    {
        static void Main()
        {

            /* PART 1 */

            /*  Create 4, or more, exercises. */

            Exercise UserDefinedTypes = new Exercise() {
                Name = "User Defined Types",
                Language = "C#"
            };
            Exercise CDictionaries = new Exercise() {
                Name = "Common Types - Dictionaries",
                Language = "C#"
            };
            Exercise BuildingDOmComponents = new Exercise() {
                Name = "Building DOM Components",
                Language = "Javascript"
            };
            Exercise BuildingAPI = new Exercise() {
                Name = "Building and Using an API",
                Language = "Javascript"
            };
            Exercise ReactStateProps = new Exercise() {
                Name = "React: State and Props",
                Language = "ReactJS"
            };
            Exercise ReactURLRouting = new Exercise() {
                Name = "React: URL Routing",
                Language = "ReactJS"
            };


            /* Create 3, or more, cohorts. */

            Cohort C29 = new Cohort("Day Cohort 29");
            Cohort C30 = new Cohort("Day Cohort 30");
            Cohort C31 = new Cohort("Day Cohort 31");
            Cohort C32 = new Cohort("Day Cohort 32");


            /* Create 4, or more, students and assign them to one of the cohorts. */

            Student megcruzen = new Student("Megan", "Cruzen", "megcruzen", C29);
            C29.StudentList.Add(megcruzen);
            Student asiacarter = new Student("Asia", "Carter", "asiacarter", C29);
            C29.StudentList.Add(asiacarter);
            Student joeblow = new Student("Joe", "Blow", "joeblow", C30);
            C30.StudentList.Add(joeblow);
            Student janesmith = new Student("Jane", "Smith", "janesmith", C31);
            C31.StudentList.Add(janesmith);


            /* Create 3, or more, instructors and assign them to one of the cohorts. */

            Instructor andy = new Instructor("Andy", "Collins", "andyc", C29);
            C29.InstructorList.Add(andy);
            Instructor steve = new Instructor("Steve", "Brownlee", "coach", C30);
            C30.InstructorList.Add(steve);
            Instructor jisie = new Instructor("Jisie", "David", "jisiedavid", C31);
            C31.InstructorList.Add(jisie);


            /* Have each instructor assign 2 exercises to each of the students. */

            andy.AssignExercise(C29, UserDefinedTypes);
            andy.AssignExercise(C29, CDictionaries);
            steve.AssignExercise(C30, ReactStateProps);
            steve.AssignExercise(C30, ReactURLRouting);
            jisie.AssignExercise(C31, BuildingDOmComponents);
            jisie.AssignExercise(C31, BuildingAPI);

            joeblow.ExerciseList.Add(UserDefinedTypes);
            joeblow.ExerciseList.Add(CDictionaries);


            /* Create a list of students. Add all of the student instances to it. */
            List<Student> StudentList = new List<Student>() {
                megcruzen, asiacarter, joeblow, janesmith
            };


            /* Create a list of exercises. Add all of the exercise instances to it. */
            List<Exercise> ExerciseList = new List<Exercise>() {
                UserDefinedTypes, CDictionaries, ReactStateProps, ReactURLRouting,
                BuildingDOmComponents, BuildingAPI
            };


            /* Generate a report that displays which students are working on which exercises. */

            foreach (Student student in StudentList) {
                List<string> currentExercises = new List<string>();
                foreach (Exercise exercise in student.ExerciseList) {
                    currentExercises.Add(exercise.Name);
                };
                Console.WriteLine($"{student.FirstName} {student.LastName} is working on {String.Join(", ", currentExercises)}");
            }


            /* PART 2 */

            /* Create 4 new List instances: one to contain students, one to contain exercises, one to contain instructors, and one to contain cohorts. */

            Student samjones = new Student("Sam", "Jones", "samj", C32);
            C32.StudentList.Add(samjones);
            Student maryremo = new Student("Mary", "Remo", "maryremo", C29);
            C29.StudentList.Add(maryremo);

            List<Student> students = new List<Student>() {
                megcruzen, asiacarter, joeblow, janesmith, samjones, maryremo
            };

            List<Exercise> exercises = new List<Exercise>() {
                UserDefinedTypes, CDictionaries, BuildingDOmComponents, BuildingAPI,
                ReactStateProps, ReactURLRouting
            };

            Instructor leah = new Instructor("Leah", "Hoefling", "leah", C29);
            Instructor madi = new Instructor("Madi", "Peper", "madi", C29);

            List<Instructor> instructors = new List<Instructor>() {
                andy, steve, jisie, leah, madi
            };

            List<Cohort> cohorts = new List<Cohort>() {
                C29, C30, C31, C32
            };


            // 1. List exercises for the JavaScript language by using the Where() LINQ method.

            IEnumerable<Exercise> javascriptExercises = from exercise in exercises
                    where exercise.Language == "Javascript"
                    select exercise;

            Console.WriteLine("--------");
            Console.WriteLine("Javascript exercises:");
            foreach (Exercise exercise in javascriptExercises)
                {
                    Console.WriteLine(exercise.Name);
                }
            Console.WriteLine("--------");


            // 2. List students in a particular cohort by using the Where() LINQ method.

            IEnumerable<Student> studentsInC29 = from student in students
                where student.Cohort == C29
                select student;

            Console.WriteLine("Students in C29:");
            foreach (Student student in studentsInC29)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }
            Console.WriteLine("--------");


            // 3. List instructors in a particular cohort by using the Where() LINQ method.

            IEnumerable<Instructor> instructorsInC29 = from instructor in instructors
                where instructor.Cohort == C29
                select instructor;

            Console.WriteLine("Instructors in C29:");
            foreach (Instructor instructor in instructorsInC29)
                {
                    Console.WriteLine($"{instructor.FirstName} {instructor.LastName}");
                }
            Console.WriteLine("--------");


            // 4. Sort the students by their last name.
            IEnumerable<Student> studentsByName = from student in students
                orderby student.LastName descending
                select student;

            Console.WriteLine("NSS Students by last names:");
            foreach (Student student in studentsByName)
                {
                    Console.WriteLine($"{student.LastName}, {student.FirstName}");
                }
            Console.WriteLine("--------");


            // 5. Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)

            IEnumerable<Student> studentsNotWorking = from student in students
                where student.ExerciseList.Count == 0
                select student;

            Console.WriteLine("Students not working on exercises:");
            foreach (Student student in studentsNotWorking)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName}");
                }
            Console.WriteLine("--------");


            // 6. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.

            IEnumerable<Student> studentExerciseList = from student in students
                orderby student.ExerciseList.Count descending
                select student;

            Student studentWithMostExercises = studentExerciseList.First();
            Console.WriteLine($"Student working on most exercises: {studentWithMostExercises.FirstName} {studentWithMostExercises.LastName}");
            Console.WriteLine("--------");



            // 7. How many students in each cohort?

            IEnumerable<CohortCount> cohortStudents2 = (from student in students
                group student by student.Cohort into studentCohort
                select new CohortCount {
                    Cohort = studentCohort.Key,
                    Count = studentCohort.Count(student => student.Cohort == studentCohort.Key)
                });

            Console.WriteLine("Number of Students:");
            foreach (var item in cohortStudents2)
            {
                Console.WriteLine($"{item.Cohort.Name}: {item.Count}");
            }

        }
    }
}
