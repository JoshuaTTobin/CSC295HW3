using System;

public class Student
{
    public string Name { get; set; }
    public double GPA { get; set; }

    public Student(string name, double gpa)
    {
        Name = name;
        GPA = gpa;
    }

    public override string ToString()
    {
        return $"{Name}: {GPA:F2}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student[] students = new Student[]
        {
            new Student("Alice", 3.5),
            new Student("Bob", 2.8),
            new Student("Charlie", 3.9),
            new Student("David", 3.2),
            new Student("Eve", 3.7)
        };

        Console.WriteLine("Select sorting algorithm:");
        Console.WriteLine("1. Bubble Sort");
        Console.WriteLine("2. Selection Sort");
        Console.WriteLine("3. Insertion Sort");
        Console.WriteLine("4. Merge Sort (Extra Credit)");
        Console.Write("Enter your choice: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                BubbleSort(students);
                break;
            case 2:
                SelectionSort(students);
                break;
            case 3:
                InsertionSort(students);
                break;
            case 4:
                MergeSort(students);
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        Console.WriteLine("Sorted students by GPA (Descending):");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    public static void BubbleSort(Student[] students)
    {
        int n = students.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (students[j].GPA < students[j + 1].GPA)
                {
                    // Swap students[j] and students[j + 1]
                    var temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }
    }

    public static void SelectionSort(Student[] students)
    {
        int n = students.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int maxIdx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (students[j].GPA > students[maxIdx].GPA)
                {
                    maxIdx = j;
                }
            }
            // Swap students[i] and students[maxIdx]
            var temp = students[i];
            students[i] = students[maxIdx];
            students[maxIdx] = temp;
        }
    }

    public static void InsertionSort(Student[] students)
    {
        int n = students.Length;
        for (int i = 1; i < n; ++i)
        {
            var key = students[i];
            int j = i - 1;

            while (j >= 0 && students[j].GPA < key.GPA)
            {
                students[j + 1] = students[j];
                j = j - 1;
            }
            students[j + 1] = key;
        }
    }

    public static void MergeSort(Student[] students)
    {
        if (students.Length <= 1)
            return;

        int mid = students.Length / 2;
        Student[] left = new Student[mid];
        Student[] right = new Student[students.Length - mid];

        for (int i = 0; i < mid; i++)
            left[i] = students[i];
        for (int i = mid; i < students.Length; i++)
            right[i - mid] = students[i];

        MergeSort(left);
        MergeSort(right);
        Merge(students, left, right);
    }

    private static void Merge(Student[] students, Student[] left, Student[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i].GPA >= right[j].GPA)
            {
                students[k++] = left[i++];
            }
            else
            {
                students[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            students[k++] = left[i++];
        }

        while (j < right.Length)
        {
            students[k++] = right[j++];
        }
    }
}
