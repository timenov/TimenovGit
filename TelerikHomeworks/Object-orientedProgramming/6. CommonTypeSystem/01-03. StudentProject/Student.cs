using System;
using System.Text;
using System.Collections.Generic;

namespace _01_03.StudentProject
{
    class Student : ICloneable, IComparable<Student>
    {
        #region fields
        private string firstName;
        private string middName;
        private string lastName;
        private string ssn;
        private string permamentAddress;
        private string mobilePhone;
        private string email;
        private string course;
        private University uni;
        private Faculty? fac;
        private Specialty? spec;
        #endregion

        #region properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string MiddName
        {
            get { return this.middName; }
            set { this.middName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }
        public string PermamentAddress
        {
            get { return this.permamentAddress; }
            set { this.permamentAddress = value; }
        }
        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        private University University
        {
            get { return this.uni; }
            set { this.uni = value; }
        }
        private Faculty? Faculty
        {
            get { return this.fac; }
            set { this.fac = value; }
        }
        private Specialty? Specialty
        {
            get { return this.spec; }
            set { this.spec = value; }
        }
        #endregion

        #region constructors
        public Student(string fisrtName, string middName, string lastName, string ssn, string address, string phone, string email, string course, University uni, Faculty? fac, Specialty? spec)
        {
            this.FirstName = fisrtName;
            this.MiddName = middName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermamentAddress = address;
            this.MobilePhone = phone;
            this.Email = email;
            this.Course = course;
            this.University = uni;
            this.Faculty = fac;
            this.Specialty = spec;
        }

        public Student(string firstName, string middName, string lastName, string course, University uni)
            : this(firstName, middName, lastName, null, null, null, null, course, uni, null, null)
        {
        }

        public Student(Student s)
            : this(s.FirstName, s.MiddName, s.LastName, s.SSN, s.PermamentAddress, s.MobilePhone, s.Email, s.Course, s.University, s.Faculty, s.Specialty)
        {
        }
        #endregion

        public override int GetHashCode()
        {
            return ((this.FirstName.GetHashCode() | this.MiddName.GetHashCode()) & (this.LastName.GetHashCode() | this.Course.GetHashCode()) + this.University.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            Student other = obj as Student;
            return this.GetHashCode() == other.GetHashCode();
        }

        public static bool operator ==(Student first, Student second)
        {
            return first.GetHashCode() == second.GetHashCode();
        }

        public static bool operator !=(Student first, Student second)
        {
            return first.GetHashCode() != second.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            #region build
            result.AppendFormat("{0}\n{1}\n{2}\n", this.FirstName, this.MiddName, this.LastName);
            if (!string.IsNullOrEmpty(this.SSN))
            {
                result.AppendLine(this.SSN);
            }
            if (!string.IsNullOrEmpty(this.PermamentAddress))
            {
                result.AppendLine(this.PermamentAddress);
            }
            if (!string.IsNullOrEmpty(this.MobilePhone))
            {
                result.AppendLine(this.MobilePhone);
            }
            if (!string.IsNullOrEmpty(this.Email))
            {
                result.AppendLine(this.Email);
            }
            result.AppendFormat("{0}\n{1}", this.course, this.University.ToString());
            if (this.Faculty != null)
            {
                result.AppendLine("\n" + this.Faculty.ToString());
            }
            if (this.Specialty != null)
            {
                result.Append(this.Specialty.ToString());
            }
            #endregion

            return result.ToString();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Student s)
        {
            int result = string.Compare(this.LastName, s.LastName);
            if (result == 0)
            {
                return string.Compare(this.SSN, s.SSN);
            }
            else
            {
                return result;
            }
        }
    }
}
