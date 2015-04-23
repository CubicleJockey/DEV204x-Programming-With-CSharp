<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Xml.Linq.dll</Reference>
  <Namespace>System.Xml.Linq</Namespace>
</Query>

public void Main(string[] args)
{
	/* 
	* Since we don't need to display student information
	* I am using empty values.
	*/
	Student student1 = new Student(string.Empty, string.Empty, DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
	Student student2 = new Student(string.Empty, string.Empty, DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
	Student student3 = new Student(string.Empty, string.Empty, DateTime.Now, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
	
	/*Don't need to display data using empty values*/
	Teacher teacher = new Teacher(string.Empty, string.Empty, string.Empty, string.Empty);
	
	Course course = new Course("Dev204x", "Programming with C#", "Programming", 5, teacher, new[]{ student1, student2, student3 });
	Degree degree = new Degree("Bachelor", "Computer Science", 400, course);
	UProgram program = new UProgram("Information Technology", new[]{"Bachelor", "Masters"}, teacher, degree);
	
	var sb = new StringBuilder();
	
	sb.AppendFormat("The {0} program contains the {1} of {2} degree", program.Name, program.Degree.Level, program.Degree.Major).AppendLine();
	sb.AppendLine();
	sb.AppendFormat("The {0} of {1} contains the course {2}", program.Degree.Level, program.Degree.Major, program.Degree.Course.Title).AppendLine();
	sb.AppendLine();
	sb.AppendFormat("The {0} course contains {1} student(s)", program.Degree.Course.Title, Student.NumberOfStudents).AppendLine();
	
	Console.WriteLine(sb.ToString());
	Console.WriteLine("Press any key to continue...");
	Console.ReadLine();
}


#region Univeristy Objects

public class Course
{
	#region Properties
	
	public string Code { get; private set; }
	
	public string Title { get; private set; }
	
	public string Description { get; private set; }
	
	public short CreditHours { get; private set; }
	
	public Teacher Teacher { get; private set; }
	
	//IEnumerable<T> is the interface that Arrays and List<T> inherit from
	//This allows an array, a List<T> or any other item that inherits from
	//IEnumerable<T> to be passed to this property.
	//Documentation: https://msdn.microsoft.com/en-us/library/9eekhta0%28v=vs.110%29.aspx
	public IEnumerable<Student> Students { get; private set; } 
	
	#endregion Properties
	
	public Course(string code, string title, string description, short creditHours, Teacher teacher, IEnumerable<Student> students)
	{
		Code = code;
		Title = title;
		Description = description;
		CreditHours = creditHours;
		Teacher = teacher;
		Students = students;
	}
}

public class Degree
{
	#region Properties
	
	public string Level { get; private set; }
	
	public string Major { get; private set; }
	
	//Shorts Max value is 32767 never heard of a degree program going higher than this EVER
	public short RequiredCredits { get; private set; }
	
	public Course Course { get; private set; }
	
	#endregion Properties
	
	/*
	* The Program object should be able to contain degrees and the degrees should be 
	* able to contain courses as well but for the purposes of this assignment, 
	* just ensure you have a single variable in UProgram to hold a Degree and 
	* single variable in Degree to hold a Course.  
	*/
	public Degree(string level, string major, short requiredCredits, Course course)
	{
		Level = level;
		Major = major;
		RequiredCredits = requiredCredits;
		Course = course;
	}
}

public class UProgram
{
   #region Properties
	
	public string Name { get; private set; }
	
	//IEnumerable<T> is the interface that Arrays and List<T> inherit from
	//This allows an array, a List<T> or any other item that inherits from
	//IEnumerable<T> to be passed to this property.
	//Documentation: https://msdn.microsoft.com/en-us/library/9eekhta0%28v=vs.110%29.aspx
	public IEnumerable<string> DegreesOffered { get; private set; }
	
	public Teacher DepartmentHead { get; private set; }
	
	public Degree Degree { get; private set; }
	
	#endregion Properties
	
	public UProgram(string name, IEnumerable<string> degreesOffered, Teacher departmentHead, Degree degree)
	{
		Name = name;
		DegreesOffered = degreesOffered;
		DepartmentHead = departmentHead;
		Degree = degree;
	}
}

public class Student
{
	#region Static 
	
	//I disagree with this, if you have an arrar of students
	//you can just use length, this is sloppy
	public static int NumberOfStudents { get; private set; }
	
	#endregion Static
	
	#region Properties
	
	public string FirstName { get; private set; }
	public string LastName { get; private set; }
	public DateTime Birthday { get; private set; }
	public string Address { get; private set; }
	public string Address1 { get; private set; }
	public string City { get; private set; }
	public string State { get; private set; }
	public string Zip { get; private set; }
	public string Country { get; private set; }
	
	#endregion Properties
	
	public Student(string fName, string lName, DateTime bDay, string address, string address1,
				string city, string state, string zip, string country, string notes)
	{
		FirstName = fName;
		LastName = lName;
		Birthday = bDay;
		Address = address;
		Address1 = address1;
		City = city;
		State = state;
		Zip = zip;
		Country = country;
		
		NumberOfStudents++;
	}
}

public class Teacher
{
	#region Properties
	
	public string PreFix { get; private set; }
	public string FirstName { get; private set; }
	public string LastName { get; private set; }
	
	public string Department { get; private set; }
	
	#endregion Properties
	
	public Teacher(string prefix, string firstName, string lastName, string department)
	{
		PreFix = prefix;
		FirstName = firstName;
		LastName = lastName;
		Department = department;
	}
}

#endregion University Objects