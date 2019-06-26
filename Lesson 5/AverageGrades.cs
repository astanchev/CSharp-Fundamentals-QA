using System;
using System.Collections.Generic;
using System.Linq;

namespace _19._Average_Grades
{
    class AverageGrades
    {
        public class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade => Grades.Average();

            public Student(string name, List<double> grades)
            {
                Name = name;
                Grades = new List<double>();
                foreach (var grade in grades)
                {
                    this.Grades.Add(grade);
                }
            }
        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int numberStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberStudents; i++)
            {
                string[] currentStudent = Console.ReadLine().Split();

                string name = currentStudent[0];
                List<double> currentGrades = new List<double>();

                for (int j = 1; j < currentStudent.Length; j++)
                {
                    currentGrades.Add(double.Parse(currentStudent[j]));
                }
                Student student = new Student(name, currentGrades);

                students.Add(student);
            }


            foreach (var student in students
                .Where(s => s.AverageGrade >= 5.0)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade))
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }

        }
    }
}
