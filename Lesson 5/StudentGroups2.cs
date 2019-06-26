using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _25._2_Student_Groups
{
    class StudentGroups2
    {
        private static List<Town> towns;
        private static List<Group> groups;
        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }

        class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students { get; set; }
        }

        class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }

        static void Main(string[] args)
        {
            towns = new List<Town>();
            groups = new List<Group>();

            ReadTownsAndStudents();

            towns = towns.OrderBy(t => t.Name).ToList();

            DistributeStudentsIntoGroups();

            groups = groups.OrderBy(g => g.Town.Name).ToList();

            Print();
        }

        private static void Print()
        {
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            foreach (var @group in groups)
            {
                Console.WriteLine($"{@group.Town.Name} => {string.Join(", ", group.Students.Select(s => s.Email).ToList())}");
            }
        }

        private static void DistributeStudentsIntoGroups()
        {
            foreach (var town in towns)
            {
                IEnumerable<Student> townStudents = town.Students
                                                        .OrderBy(s => s.RegistrationDate)
                                                        .ThenBy(s => s.Name)
                                                        .ThenBy(s => s.Email);
                while (townStudents.Any())
                {
                    Group group = new Group();
                    group.Town = town;
                    group.Students = townStudents.Take(group.Town.SeatsCount).ToList();
                    townStudents = townStudents.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }

            }
        }

        private static void ReadTownsAndStudents()
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    return;
                }

                if (input.Contains("=>"))
                {
                    Town currentTown = new Town();

                    string[] inputline =
                        input.Trim().Split(new string[] {" => "}, StringSplitOptions.RemoveEmptyEntries);


                    currentTown.Name = inputline[0];
                    currentTown.SeatsCount = int.Parse(inputline[1].Split()[0]);
                    currentTown.Students = new List<Student>();

                    towns.Add(currentTown);
                }
                else
                {
                    Student currentStudent = new Student();

                    string[] inputline = input.Split(new[] {'|', ' '}, StringSplitOptions.RemoveEmptyEntries);

                    currentStudent.Name = inputline[0] + " " + inputline[1];
                    currentStudent.Email = inputline[2];

                    if (inputline[2].Contains("|"))
                    {
                        currentStudent.Email = currentStudent.Email.Substring(1, inputline[2].Length - 1);
                    }

                    if (inputline[3].Contains("|"))
                    {
                        inputline[3] = inputline[3].Substring(1, inputline[3].Length - 1);
                    }

                    currentStudent.RegistrationDate =
                        DateTime.ParseExact(inputline[3], "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    if (towns.Count > 0)
                    {
                        towns[towns.Count - 1].Students.Add(currentStudent);
                    }

                }
            }
        }
    }
}
