namespace WestCoastEducation;

public class Menu
{
    private School _school;

    public Menu(School school)
    {
        _school = school;
    }

    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("============================");
            Console.WriteLine("    WestCoast Education");
            Console.WriteLine("============================");
            Console.WriteLine("1. Add course");
            Console.WriteLine("2. Add teacher ");
            Console.WriteLine("3. Add student");
            Console.WriteLine("4. Add education leader");
            Console.WriteLine("5. Add administrator");
            Console.WriteLine("6. List courses");
            Console.WriteLine("7. List students");
            Console.WriteLine("0. Exit");
            Console.Write("Choice: ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                AddCourse();
                break;
                case "2":
                AddTeacher();
                break;
                case "3":
                AddStudent();
                break;
                case "4":
                AddEducationLeader();
                break;
                case "5":
                AddAdministrator();
                break;
                case "6":
                _school.ListCourses();
                break;
                case "7":
                _school.ListStudents();
                break;
                case "0":
                running = false;
                break;
                default:
                Console.WriteLine("Invalid choice, you may try again!");
                break;  
            
            }

        }
    }

    private void AddCourse ()
    {
        Console.Write("Course number: ");
        string courseNumber = Console.ReadLine() ?? "";

        Console.Write("Title: ");
        string title = Console.ReadLine() ?? "";

        Console.Write("Length (weeks): ");
        if (!int.TryParse(Console.ReadLine(), out int length))
        {
            Console.WriteLine("Invalid length!");
            return;
        }

        Console.Write("Start date (yyyy-mm-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
        {
            Console.WriteLine("Invalid date! ");
            return;
        }

        Console.Write("End date (yyyy-mm-dd): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
        {
            Console.WriteLine("Invalid date! ");
            return;
        }

        Console.Write("Type (1 = Classroom, 2 = Distance): ");
        string? typeChoice = Console.ReadLine();

        CourseType type = CourseType.Classroom;
        if (typeChoice == "2")
        {
            type = CourseType.Distance;
        }

        Course course = new Course (courseNumber, title, length, startDate, endDate, type);

        if (_school.AddCourse(course))
        {
            Console.WriteLine("Course added!");
        }
        else
        {
            Console.WriteLine("Course with that number already exists!");
        }
    }
    private void AddTeacher (){}
    private void AddStudent (){}
    private void AddAdministrator (){}
    private void AddEducationLeader (){}
}
