﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Ch11
{
    internal class _509
    {
       class Student
        {
            public string Name { get; set; }
            public double Score { get; set; }

            public Student(string name, double score)
            {
                Name = name;
                Score = score;
            }

            public override string ToString()
            {
                return this.Name + " : " + this.Score ;
            }
        }

        class Students
        {
            private List<Student> listOfStudent = new List<Student>();
            public delegate void PrintProcess(Student list);
            public void Add(Student student)
            {
                listOfStudent.Add(student);
            }

            public void Print()
            {
                Print((student) =>
                {
                    Console.WriteLine(student);
                });
            }

            public void Print(PrintProcess process)
            {
                foreach (var item in listOfStudent)
                {
                    process(item);
                }
            }
        }

        class Program
        {
            static void Main1(string[] args)
            {
                Students students = new Students();
                students.Add(new Student("윤인성", 4.2));
                students.Add(new Student("연하진", 4.4));

                students.Print();
                students.Print((student) =>
                {
                    Console.WriteLine();
                    Console.WriteLine("이름 : " + student.Name);
                    Console.WriteLine("학점 : " + student.Score);
                });
            }
        }
    }
}
