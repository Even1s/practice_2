namespace task_2
{
    internal static class StudentProgram
    {
        public static void Run()
        {
            var student = new Student();
            while (true)
            {
                Console.WriteLine("Commands:");
                Console.WriteLine("[E] - Edit");
                Console.WriteLine("[P] - Print");
                Console.WriteLine("[Q] - Exit");
                string? command = Console.ReadLine();
                switch (command)
                {
                    case "E":
                        Console.Clear();
                        Edit(student);
                        continue;
                    case "P":
                        Console.Clear();
                        Print(student);
                        continue;
                    case "Q":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ERROR");
                        continue;
                }

                break;
            }
        }

        private static void Edit(Student student)
        {
            while (true)
            {
                Console.WriteLine("Properties:");
                Console.WriteLine("[N] - Last Name");
                Console.WriteLine("[B] - Birth Date");
                Console.WriteLine("[G] - Group");
                Console.WriteLine("[P] - Performanse");
                Console.WriteLine("[Q] - Exit");
                string? property = Console.ReadLine();
                switch (property)
                {
                    case "N":
                        Console.Clear();
                        Console.Write("Write Last Name: ");
                        student.LastName = Console.ReadLine() ?? string.Empty;
                        Console.Clear();
                        break;
                    case "B":
                        Console.Clear();
                        Console.Write("Write Birth Date (dd.mm.yyyy): ");
                        int[]? date = Console.ReadLine()?.Split('.').ToArray().Select(int.Parse).ToArray();
                        student.SetDate(date[0], date[1], date[2]);
                        Console.Clear();
                        break;
                    case "G":
                        Console.Clear();
                        Console.Write("Write Group: ");
                        student.Group = int.Parse(Console.ReadLine() ?? string.Empty);
                        Console.Clear();
                        break;
                    case "P":
                        Console.Clear();
                        Console.Write("Write Performanse: ");
                        int[]? performanse = Console.ReadLine()?.Split(' ').ToArray().Select(int.Parse).ToArray();
                        student.Performanse = performanse;
                        Console.Clear();
                        break;
                    case "Q":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ERROR");
                        continue;
                }

                break;
            }
        }

        static void Print(Student student)
        {
            while (true)
            {
                Console.WriteLine("Properties:");
                Console.WriteLine("[N] - Last Name");
                Console.WriteLine("[B] - Birth Date");
                Console.WriteLine("[G] - Group");
                Console.WriteLine("[P] - Performanse");
                Console.WriteLine("[Q] - Exit");
                string? property = Console.ReadLine();
                switch (property)
                {
                    case "N":
                        Console.Clear();
                        Console.WriteLine($"Last Name: {student.LastName}");
                        Console.Write("Press Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "B":
                        Console.Clear();
                        Console.WriteLine($"Birth Date: {student.BirthDate}");
                        Console.Write("Press Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "G":
                        Console.Clear();
                        Console.WriteLine($"Group: {student.Group}");
                        Console.Write("Press Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "P":
                        Console.Clear();
                        Console.WriteLine($"Performanse: {string.Join(",", student.Performanse)}");
                        Console.Write("Press Enter");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "Q":
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("ERROR");
                        continue;
                }

                break;
            }
        }
    }
}