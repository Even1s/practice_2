using Microsoft.VisualBasic;

namespace task_1
{
    internal static class Program
    {
        public static void Main()
        {
            // FirstTask();
            // SecondTask();
            ThirdTask();
        }

        private static void FirstTask()
        {
            Console.Write("Введите драгоценности: ");
            string? j = Console.ReadLine();
            Console.Write("Введите камни: ");
            string? s = Console.ReadLine();
            if (j == null || s == null) return;
            int contains = 0;
            foreach (var stone in s)
            {
                if (j.Contains(stone)) contains++;
            }
            Console.WriteLine($"Содержится {contains} драгоценностей");
        }
        private static List<int[]> Combination(int startIndex, int[] pair, int[] initialArray)
        {
            var combinations = new List<int[]>();
            for (int i = startIndex; i < initialArray.Length; i++)
            {
                var value = pair.Concat([initialArray[i]]).ToArray();
                combinations.Add(value);
                combinations.AddRange(Combination(i + 1, value, initialArray));
            }
            return combinations;
        }

        private static void SecondTask()
        {
            Console.Write("Введите массив: ");
            int[]? wroteArray = Console.ReadLine()?.Split(' ').ToArray().Select(int.Parse).ToArray();
            Console.Write("Введите число: ");
            int target = int.Parse(Console.ReadLine() ?? string.Empty);
            List<int[]> filteredArray = new List<int[]>();
            foreach (var array in Combination(0, [], wroteArray))
            {
                int sum = 0;
                foreach (var number in array)
                    sum += number;
                if (sum == target)
                {
                    Array.Sort(array);
                    bool isEqual = false;
                    foreach (var filter in filteredArray)
                    {
                        if (filter.SequenceEqual(array)) isEqual = true;
                    }
                    if (!isEqual) filteredArray.Add(array);
                };
            }

            foreach (var array in filteredArray)
            {
                Console.WriteLine(String.Join(", ", array));
            }
        }

        private static bool hasDuplicate(int[] array)
        {
            foreach (var number in array)
                if (Array.FindAll(array, x => x == number).Length > 1) return true;
            return false;
        }

        private static void ThirdTask()
        {
            Console.Write("Введите массив: ");
            int[]? wroteArray = Console.ReadLine()?.Split(' ').ToArray().Select(int.Parse).ToArray();
            Console.WriteLine(hasDuplicate(wroteArray));
        }
    }
}
