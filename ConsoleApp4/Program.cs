using ConsoleApp4;

class Program
{
    static void BubbleSort(Student[] students)
    {
        int n = students.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (students[j].Age > students[j + 1].Age)
                {
                    // Swap
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Student[] students = {
            new Student("ivan", 17),
            new Student("mariya", 16),
            new Student("petur", 18),
            new Student("anna", 15)
        };

        BubbleSort(students);

        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} - {student.Age} godini");
        }
    }
}

