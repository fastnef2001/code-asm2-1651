using System;
using System.Collections.Generic;
using System.Text;

namespace nhanh
{
    class Student: Person
    {
        public double GradeASM1 { get; set; }
        public double GradeASM2 { get; set; }

        public double GPA { get; set; }
        public string Rank { get; set; }
        private List<Student> ListStudent = null;
        public Student()
        {
            ListStudent = new List<Student>();
        }



        /**
        * Hàm tạo ID tăng dần cho nhân viên
        */
            private int GenerateID()
            {
                int max = 1;
                if (ListStudent != null && ListStudent.Count > 0)
                {
                    max = ListStudent[0].ID;
                    foreach (Student sv in ListStudent)
                    {
                        if (max < sv.ID)
                        {
                            max = sv.ID;
                        }
                    }
                    max++;
                }
                return max;
            }


        public int NumberOfStudents()
        {
            int Count = 0;
            if (ListStudent != null)
            {
                Count = ListStudent.Count;
            }
            return Count;
        }

        public void EnterStudent()
        {
            // Initialize a new student
            Student sv = new Student();
            sv.ID = GenerateID();
            Console.Write("Enter student name  : ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter student gender: ");
            sv.Gender = Convert.ToString(Console.ReadLine());

            Console.Write("Enter student age   : ");
            sv.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter grade ASM1    : ");
            sv.GradeASM1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter grade ASM2    : ");
            sv.GradeASM2 = Convert.ToDouble(Console.ReadLine());

            CalculateGPA(sv);
            GradeRank(sv);
            ListStudent.Add(sv);
        }


        public void UpdateStudent(int ID)
        {
            // Find student in list 
            Student sv = FindByID(ID);
            // If student exists, please enter student information
            if (sv != null)
            {
                Console.Write("Enter student name  : ");
                string name = Convert.ToString(Console.ReadLine());
                // If not enter what, not update 
                if (name != null && name.Length > 0)
                {
                    sv.Name = name;
                }

                Console.Write("Enter student gender: ");
                // If not enter what, not update 
                string gender = Convert.ToString(Console.ReadLine());
                if (gender != null && gender.Length > 0)
                {
                    sv.Gender = gender;
                }

                Console.Write("Enter student age   : ");
                string ageStr = Convert.ToString(Console.ReadLine());
                // If not enter what, not update 
                if (ageStr != null && ageStr.Length > 0)
                {
                    sv.Age = Convert.ToInt32(ageStr);
                }

                Console.Write("Enter grade ASM1     : ");
                string diemToanStr = Convert.ToString(Console.ReadLine());
                // If not enter what, not update 
                if (diemToanStr != null && diemToanStr.Length > 0)
                {
                    sv.GradeASM1 = Convert.ToDouble(diemToanStr);
                }

                Console.Write("Enter grade ASM2     : ");
                string diemLyStr = Convert.ToString(Console.ReadLine());
                // If not enter what, not update 
                if (diemLyStr != null && diemLyStr.Length > 0)
                {
                    sv.GradeASM2 = Convert.ToDouble(diemLyStr);
                }   
                CalculateGPA(sv);
                GradeRank(sv);
            }
            else
            {
                Console.WriteLine("Student with ID = {0} doesn't exist.", ID);
            }
        }

       
         //Function to sort list of students by ID ascending
        public void SortByID()
        {
            ListStudent.Sort(delegate (Student sv1, Student sv2) {
                return sv1.ID.CompareTo(sv2.ID);
            });
        }

        // Function to sort the list of students by name from A to Z
        public void SortByName()
        {
            ListStudent.Sort(delegate (Student sv1, Student sv2) {
                return sv1.Name.CompareTo(sv2.Name);
            });
        }
        //Function to sort the list of students by ascending GPA

        public void SortByGPA()
        {
            ListStudent.Sort(delegate (Student sv1, Student sv2) {
                return sv1.GPA.CompareTo(sv2.GPA);
            });
        }

        /**
         * Student search function by ID
         * Returns a student
         */
        public Student FindByID(int ID)
        {
            Student searchResult = null;
            if (ListStudent != null && ListStudent.Count > 0)
            {
                foreach (Student sv in ListStudent)
                {
                    if (sv.ID == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }

        /**
         * Student search function by Name
         * Returns a student    
         */
        public List<Student> FindByName(String keyword)
        {
            List<Student> searchResult = new List<Student>();
            if (ListStudent != null && ListStudent.Count > 0)
            {
                foreach (Student sv in ListStudent)
                {
                    if (sv.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }

        
        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;
            //Search students by ID
            Student sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = ListStudent.Remove(sv);
            }
            return IsDeleted;
        }

         // Function to calculate average score for students
        private void CalculateGPA(Student sv)
        {
            double GPA = (sv.GradeASM1 + sv.GradeASM2) / 2;
            sv.GPA = Math.Round(GPA, 2, MidpointRounding.AwayFromZero);
        }


        // Academic rating function for student

        private void GradeRank(Student sv)
        {
            if (sv.GPA == 10)
            {
                sv.Rank = "D";
            }
            else if (sv.GPA >= 8)
            {
                sv.Rank = "M";
            }
            else if (sv.GPA >= 6.5)
            {
                sv.Rank = "P";
            }
            else
            {
                sv.Rank = "F";
            }
        }

        /**
         * Hàm hiển thị danh sách sinh viên ra màn hình console
         */
        public void DisplayStudent(List<Student> listSV)
        {
            // show column headers
            Console.WriteLine("{0, -2} {1, -10} {2, -4} {3, -4} {4, -4} {5, -4} {6, -4} {7, -4}",
                                 "ID", "Name", "Sex", "Age", "ASM1", "ASM2", "GPA", "Rank");
            // Show list of students
            if (listSV != null && listSV.Count > 0)
            {
                foreach (Student sv in listSV)
                {
                    Console.WriteLine("{0, -2} {1, -10} {2, -4} {3, -4} {4, -4} {5, -4} {6, -4} {7, -4}",
                                      sv.ID, sv.Name, sv.Gender, sv.Age, sv.GradeASM1, sv.GradeASM2, sv.GPA, sv.Rank);
                }
            }
            Console.WriteLine();
        }

        /*
         * Hàm trả về danh sách sinh viên hiện tại
         */
        public List<Student> getListStudent()
        {
            return ListStudent;
        }

    }
}
