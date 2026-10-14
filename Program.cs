namespace WestCoastEducation;

class Program
{
     static void Main()
    {
        School school = new School ();
        Menu menu = new Menu (school);
        menu.Run ();
    }
}
