using System;
using System.Collections.Generic;

namespace _01.Class_Student
{
	public class Student
	{
		private string firstName, lastName, phone, email;
		private int age, facultyNumber, groupNumber;

		public Student(string firstName, string lastName, string phone, string email, int age, int facultyNumber, int groupNumber, IList<int> marks)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Phone = phone;
			this.Email = email;
			this.Age = age;
			this.FacultyNumber = facultyNumber;
			this.GroupNumber = groupNumber;
			this.Marks = marks;
		}

		public string FirstName
		{
			get { return this.firstName; }
			set
			{
				ValidateString(value, "First Name");
				this.firstName = value;
			}
		}

		public string LastName
		{
			get { return this.lastName; }
			set
			{
				ValidateString(value, "Last name");
				this.lastName = value;
			}
		}

		public string Phone
		{
			get { return this.phone; }
			set
			{
				ValidateString(value, "Phone number");
				this.phone = value;
			}
		}

		public string Email
		{
			get { return this.email; }
			set
			{
				ValidateString(value, "Email");
				this.email = value;
			}
		}

		public int Age
		{
			get { return this.age; }
			set
			{
				ValidateInt(value, "Age");
				this.age = value;
			}
		}

		public int FacultyNumber
		{
			get { return this.facultyNumber; }
			set
			{
				ValidateInt(value, "Faculty number");
				this.facultyNumber = value;
			}
		}

		public int GroupNumber
		{
			get { return this.groupNumber; }
			set
			{
				ValidateInt(value, "Group number");
				this.groupNumber = value;
			}
		}

		public IList<int> Marks { get; set; }

		private void ValidateString(string input, string prop)
		{
			if (string.IsNullOrWhiteSpace(input))
			{
				throw new ArgumentNullException(nameof(input), $"{prop} field must not be empty.");
			}
		}

		private void ValidateInt(int input, string prop)
		{ 
			if (input < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(input), $"{prop} field must not be empty.");
			}
		}
	}
}
