using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _23._Mentor_Group
{
    class MentorGroup
    {
        class Student
        {
            public List<string> Comments { get; set; }
            public List<DateTime> Attendance { get; set; }
            public string Name { get; set; }

            public Student(string name)
            {
                Name = name;
                Comments = new List<string>();
                Attendance = new List<DateTime>();
            }
        }
        static void Main(string[] args)
        {
            SortedDictionary<string, Student> students = new SortedDictionary<string, Student>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of dates")
                {
                    break;
                }

                string[] inputLine = input.Split();
                string name = inputLine[0];

                Student currentStudent = new Student(name);
                if (!students.ContainsKey(name))
                {
                    students[name] = currentStudent;
                }

                if (inputLine.Length == 1)
                {
                    continue;
                }

                string[] inputDates = inputLine[1].Split(',');


                foreach (var date in inputDates)
                {
                    students[name].Attendance.Add(DateTime
                                        .ParseExact(date, "dd/MM/yyyy",
                                                    CultureInfo.InvariantCulture));
                }

            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of comments")
                {
                    break;
                }

                string name = input.Split('-')[0];
                string comment = input.Split('-')[1];

                if (!students.ContainsKey(name))
                {
                    continue;
                }

                students[name].Comments.Add(comment);
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key}");
                Console.WriteLine("Comments:");
                if (student.Value.Comments.Count > 0)
                {
                    foreach (var comment in student.Value.Comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }

                Console.WriteLine("Dates attended:");

                foreach (var date in student.Value.Attendance.OrderBy(d => d))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }

            }

        }
    }
}
