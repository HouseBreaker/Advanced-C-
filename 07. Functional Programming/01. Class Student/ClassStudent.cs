using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Class_Student
{
	class ClassStudent
	{
		static void Main()
		{
			var students = new List<Student>();

			students.Add(new Student(
				"Sara", "Mills", 
				"+359 2885934", 
				"smills0@marketwatch.com", 
				21, 
				203314, 
				2, 
				new List<int>() {2, 3, 4, 5, 2, 6, 4, 5, 3, 4}
				));

			students.Add(new Student(
				"Daniel", "Carter",
				"028385934",
				"dcarter1@buzzfeed.com",
				22,
				203315,
				1,
				new List<int>() { 4, 5, 4, 4, 6, 6, 4, 5, 4, 4 }
				));

			students.Add(new Student(
				"Aaron", "Gibson",
				"+3592885934",
				"agibson2@house.gov",
				19,
				203314,
				3,
				new List<int>() { 3, 3, 5, 5, 4, 5, 4, 3, 2, 3 }
				));

			students.Add(new Student(
				"William", "Alexander",
				"028485934",
				"walexander3@abv.bg",
				24,
				203315,
				2,
				new List<int>() { 4, 6, 3, 2, 6, 6, 6, 3, 4, 5 }
				));

			students.Add(new Student(
				"Mildred", "Hansen",
				"02885934",
				"mhansen4@abv.bg",
				35,
				203415,
				3,
				new List<int>() { 4, 4, 4, 2, 3, 6, 3, 6, 2, 2 }
				));

				// Problem 2 - Students by group: 
			// Print all students from group number 2

			var problem2Students = string.Join(", ", students
				.Where(a => a.GroupNumber == 2)
				.Select(s => $"{s.FirstName} {s.LastName}"));

			Console.WriteLine("Problem 2 - Students by group:");
			Console.WriteLine(problem2Students + " got group number 2");

				// Problem 3 - Students by First and Last Name:
			// Print all students whose first name is before their last name alphabetically. Use a LINQ query.

			var problem3Students = string.Join(", ", students
				.Where(s => s.FirstName[0] < s.LastName[0])
				.Select(s => $"{s.FirstName} {s.LastName}"));

			Console.WriteLine("\nProblem 3 - Students by First and Last Name:");
            Console.WriteLine(problem3Students + " got a first name which is before their last name alphabetically");

					// Problem 4 - Students by Age:
			// Write a LINQ query that finds the first name and last name of 
			// all students with age between 18 and 24. The query should return
			// only the first name, last name and age.

			var problem4Students = string.Join(Environment.NewLine, students
				.Where(s => s.Age >= 18 && s.Age <= 24)
				.Select(s => $"{s.FirstName} {s.LastName} - {s.Age} years old"));

			Console.WriteLine("\nProblem 4 - Students by Age:\n");
			Console.WriteLine($"Students between 18 and 24 years old: \n{problem4Students}");

				// Problem 5. Sort Students
			// Using the extension methods OrderBy() and ThenBy() with lambda
			// expressions sort the students by first name and last name in 
			// descending order. Rewrite the same with LINQ query syntax.

			// using extension methods
			var problem5Students = string.Join(Environment.NewLine, students
				.OrderByDescending(s => s.FirstName)
				.ThenByDescending(s => s.LastName)
				.Select(s => $"{s.FirstName} {s.LastName}"));

			// as LINQ query
			var problem5StudentsLinqQuery = string.Join(Environment.NewLine, 
				from s in students
				orderby s.FirstName descending 
				select $"{s.FirstName} {s.LastName}");
				

			Console.WriteLine("\nProblem 5. Sort Students:\n");
			Console.WriteLine($"Students sorted by first name then last name:\n{problem5Students}");
			Console.WriteLine($"\nStudents sorted by first name then last name using LINQ Query:\n{problem5StudentsLinqQuery}");

				// Problem 6. Filter Students by Email Domain
			// Print all students that have email @abv.bg. Use LINQ.

			var problem6Students = string.Join(Environment.NewLine, students
				.Where(s => s.Email.Contains("@abv.bg"))
				.Select(s => $"{s.FirstName} {s.LastName} - {s.Email}"));

			Console.WriteLine("\nProblem 6. Filter Students by Email Domain:");
			Console.WriteLine($"Students whose email is an abv.bg email:\n{problem6Students}");

				// Problem 7. Filter Students by Phone
			// Print all students with phones in Sofia (starting with 02 / +3592 / +359 2). Use LINQ.
			var problem7Students = string.Join(Environment.NewLine, students
				.Where(s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592") || s.Phone.StartsWith("+359 2"))
				.Select(s => $"{s.FirstName} {s.LastName} - Phone: {s.Phone}"));

			Console.WriteLine("\nProblem 7. Filter Students By Phone:");
			Console.WriteLine($"Students who have a Sofia phone:\n{problem7Students}");

				// Problem 8. Excellent students
			// Print all students that have at least one mark Excellent (6)
			// . Using LINQ first select them into a new anonymous 
			// class that holds { FullName + Marks}.

			// todo: proper linq query with anonymous class
			var problem8Students = string.Join(Environment.NewLine, students
				.Where(s => s.Marks.Contains(6))
				.Select(s => $"{s.FirstName} {s.LastName} - Marks: {string.Join(", ", s.Marks)}"));

			Console.WriteLine("\nProblem 8. Excellent Students:");
			Console.WriteLine($"Students who have at least one excellent grade:\n{problem8Students}");

			// Problem 9. Weak Students
			// Write a similar program to the previous one to extract the students with exactly two marks "2". Use extension methods.

			var problem9Students = string.Join(Environment.NewLine, students
				.Where(s => s.Marks.Count(g => g.Equals(2)) == 2)
				.Select(s => $"{s.FirstName} {s.LastName} - Marks: {string.Join(", ", s.Marks)}"));

			Console.WriteLine("\nProblem 9. Weak Students:");
			Console.WriteLine($"Students who have exactly 2 \"2\" grades:\n{problem9Students}");

			// Problem 10. Students Enrolled in 2014
			// Extract and print the Marks of the students that enrolled in 2014
			// (the students from 2014 have 14 as their 5-th and 6-th digit in the FacultyNumber).

			var problem10Students = string.Join(Environment.NewLine, students
				.Where(s => s.FacultyNumber.ToString().EndsWith("14"))
				.Select(s => $"{s.FirstName} {s.LastName} - Faculty Number {s.FacultyNumber}"));

			Console.WriteLine("\nProblem 10. Students enrolled in 2014:");
			Console.WriteLine($"Students who enrolled in 2014:\n{problem10Students}");
		}
	}
}
