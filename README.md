# Student Exercises Part 2: LINQ

## Instructions

In the last exercise, you had the instructors assign exercises to students.

```cs
Instructor.AssignExercise(exercise, student);
```

For this exercise, you need to create 4 new `List` instances to `Program.cs`: one to contain students, one to contain exercises, one to contain instructors, and one to contain cohorts.

```cs
List<Student> students = new List<Student>() {
    Larry,
    Kristin,
    Loshanna,
    Tre
};

List<Exercise> exercises = new List<Exercise>() {
    OverlyExcited,
    SolarSystem,
    CarLot,
    DynamicCards
};

// Same for instructors and cohorts
```

1. List exercises for the JavaScript language by using the `Where()` LINQ method.
1. List students in a particular cohort by using the `Where()` LINQ method.
1. List instructors in a particular cohort by using the `Where()` LINQ method.
1. Sort the students by their last name.
1. Display any students that aren't working on any exercises _(Make sure one of your student instances don't have any exercises. Create a new student if you need to.)_
1. Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
1. How many students in each cohort?

