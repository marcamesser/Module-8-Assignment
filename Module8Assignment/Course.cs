using System;
using System.Collections;
using System.Collections.Generic;

namespace Module8Assignment
{
    public class Course
    {
        // constructor
        public Course(string CName, string CID, List<Student> CStudent, ArrayList CTeacher)
        {
            this.CourseName = CName;
            this.CourseID = CID;
            this.CourseStudent = CStudent;
            this.CourseTeacher = CTeacher;
        }
        // the following statements declare private member variables

        private string _CourseName;

        private string _CourseID;

        private List<Student> _CourseStudent;

        private ArrayList _CourseTeacher;

        public string CourseName
        {
            get => _CourseName;
            set => _CourseName = value;
        }

        public string CourseID
        {
            get => _CourseID;
            set => _CourseID = value;
        }

        public List<Student> CourseStudent
        {
            get => _CourseStudent;
            set => _CourseStudent = value;
        }

        public ArrayList CourseTeacher
        {
            get => _CourseTeacher;
            set => _CourseTeacher = value;
        }

        // the following statements declare public methods
        public void DisplayStudents()
        {
            //output students in StudentList
            foreach (Student Student in CourseStudent)
            {
                System.Console.WriteLine("Name: {0} {1}", Student.FirstName, Student.LastName);
            }
        }

        public void DisplayTeachers()
        {
            //output students in TeacherList
            foreach (Teacher Teacher in CourseTeacher)
            {
                System.Console.WriteLine("Name: {0} {1}", Teacher.FirstName, Teacher.LastName);
            }
        }

    }
}