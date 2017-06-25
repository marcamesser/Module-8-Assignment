using System;
using System.Collections;
using System.Collections.Generic;

namespace Module8Assignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // declare students
            Student Joey = new Student("Joey", "Freshwater", 01);
            Joey.Grades.Push("A+");
            Joey.Grades.Push("A+");
            Joey.Grades.Push("A+");
            Joey.Grades.Push("A+");
            Joey.Grades.Push("A+");
            Student Jimmy = new Student("Jimmy", "Chestnut", 02);
            Jimmy.Grades.Push("A+");
            Jimmy.Grades.Push("A+");
            Jimmy.Grades.Push("A+");
            Jimmy.Grades.Push("A+");
            Jimmy.Grades.Push("A+");
            Student Lane = new Student("Lane", "Kiffin", 03);
            Lane.Grades.Push("A+");
            Lane.Grades.Push("A+");
            Lane.Grades.Push("A+");
            Lane.Grades.Push("A+");
            Lane.Grades.Push("A+");
            List<Student> StudentList = new List<Student>();
            StudentList.Add(Joey);
            StudentList.Add(Jimmy);
            StudentList.Add(Lane);


            // declare teacher
            Teacher Butch = new Teacher("Butch", "Jones", 01);
            ArrayList TeacherList = new ArrayList();
            TeacherList.Add(Butch);

            // declare course
            Course Prog = new Course("Programming with C#", "P01", StudentList, TeacherList);
            Course[] CourseArray = {Prog};

            Prog.DisplayStudents();
        }
    }
}