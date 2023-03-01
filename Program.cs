namespace ExercicioFixacao
{
  class Program
  {
    static void Main(string[] args)
    {
      Student[] students = new Student[10];

      System.Console.Write("How many rooms will be rented? ");
      int rooms = int.Parse(Console.ReadLine());

      for (int i = 0; i < rooms; i++)
      {
        System.Console.WriteLine("Rent #" + (i + 1));

        System.Console.Write("Name: ");
        string studentName = Console.ReadLine();

        System.Console.Write("Email: ");
        string studentEmail = Console.ReadLine();

        System.Console.Write("Room: ");
        int studentRoom = int.Parse(Console.ReadLine());

        students[studentRoom] = new Student {
          Name = studentName,
          Email = studentEmail
        };
      }

      System.Console.WriteLine("Busy rooms:");
      for (int i = 0; i < students.Length; i++)
      {
        if (students[i] != null)
        {
          System.Console.WriteLine($"{i}: {students[i].Name}, {students[i].Email}");
        }
      }
    }
  }
}