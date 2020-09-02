using System;
using System.Collections.Generic;
using System.Text;

namespace Tema2
{
    class Student : ICloneable, IComparable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string PermanentAddress { get; set; }
        public int MobilePhone { get; set; }
        public string Email { get; set; }
        public int Course { get; set; }
        public Universities University { get; set; }
        public Specialities Speciality { get; set; }
        public Faculties Faculty { get; set; }

        public Student(string fName, string mName, string lName,
            int ssn, string permanentAddress, int mobilePhone,
            string email, int course, Universities universities,
            Specialities specialities, Faculties faculties)

        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.University = universities;
            this.Speciality = specialities;
            this.Faculty = faculties;

        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (student.FirstName == this.FirstName && student.MiddleName == this.MiddleName && student.LastName == this.LastName &&
                student.SSN == this.SSN && student.PermanentAddress == this.PermanentAddress && student.MobilePhone == this.MobilePhone && student.Email == this.Email &&
                student.Course == this.Course && student.University == this.University && student.Speciality == this.Speciality && student.Faculty == this.Faculty)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^ LastName.GetHashCode() ^ SSN.GetHashCode());
        }


        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            s.AppendLine($"First name: {this.FirstName}");
            s.AppendLine($"Middle name:{this.MiddleName}");
            s.AppendLine($"Last name: {this.LastName}");
            s.AppendLine($"SSN: {this.SSN}");
            s.AppendLine($"Permanent address: {this.PermanentAddress}");
            s.AppendLine($"Mobile phone: {this.MobilePhone}");
            s.AppendLine($"Email: {this.Email}");
            s.AppendLine($"Course: {this.Course}");
            s.AppendLine($"University: {this.University}");
            s.AppendLine($"Faculty: {this.Faculty}");
            s.AppendLine($"Specialty: {this.Speciality}");

            return s.ToString();
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }


        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        //Problem 2. ICloneable

        //Add implementations of the ICloneable interface.
        // The Clone() method should deeply copy all object's fields into a new object of type Student.


        public object Clone()
        {
            return new Student(this.FirstName,
            this.MiddleName,
            this.LastName,
            this.SSN,
            this.PermanentAddress,
            this.MobilePhone,
            this.Email,
            this.Course,
            this.University,
            this.Speciality,
            this.Faculty);
        }

       

        public int CompareTo(Student compareStudent)
        {
            int compareFname = this.FirstName.CompareTo(compareStudent.FirstName);

            if (compareFname != 0)
            {
                return compareFname;
            }

            else
            {
                int compareMname = this.MiddleName.CompareTo(compareStudent.MiddleName);

                if (compareMname != 0)

                {
                    return compareMname;
                }

                else
                {
                    int compareLastname = this.LastName.CompareTo(compareStudent.LastName);

                    if (compareLastname != 0)
                    {
                        return compareLastname;
                    }

                    else
                    {
                        int compareSSN = this.SSN.CompareTo(compareStudent.SSN);

                        if (compareSSN != 0)
                        {
                            return compareSSN;
                        }

                        else
                        {
                            return 0;
                        }

                    }
                }
            }

        }
    }
        public enum Specialities
        {

            ChimieMedicala, BazeDeDate, Biochemistry
        }

        public enum Universities
        {
            AlexandruIoanCuza, GheorgheAsachi, Agricultura

        }

        public enum Faculties
        {
            Chimie, Informatica, Zootehnie

        }
    
    
}
