using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Student
{
    class Student : System.Object, ICloneable, IComparable<Student>
    {
        //Enumerations
        public enum Universities
        {
            technicalUniversity, medicalUniveristy, sofiqUniversity
        }
        public enum Faculties
        {
            mechanicalEngineering, telecommunications, stomatology, medicine, phisics, social
        }
        public enum Specialties
        {
            mechanicalEngineering, engineeringDesign, mechatronics,
            stomatology, medicine, nuclearPhysics, history, telecommunications
        }

        //Fields
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public uint sSN { get; set; }
        public uint mobilePhoneNum { get; set; }
        public string eMail { get; set; }
        public uint course { get; set; }
        public Universities university { get; set; }
        public Faculties faculty { get; set; }
        public Specialties specialty { get; set; }

        //Constructor
        public Student(string inputFirstName, string inputMiddleName, string inputLastName,
            uint inputSSN, uint inputMobileNum, string inputEMail, uint inputCourse,
            Universities inputUn, Faculties inputFac, Specialties inputSpec)
        {
            this.firstName = inputFirstName;
            this.middleName = inputMiddleName;
            this.lastName = inputLastName;
            this.sSN = inputSSN;
            this.mobilePhoneNum = inputMobileNum;
            this.eMail = inputEMail;
            this.course = inputCourse;
            this.university = inputUn;
            this.faculty = inputFac;
            this.specialty = inputSpec;
        }

        //Methods
        //ToString
        public override string ToString()
        {
            StringBuilder studentFuelds = new StringBuilder();

            studentFuelds.AppendLine(this.firstName + " " + this.middleName + " " + this.lastName);
            studentFuelds.AppendLine("-------------");
            studentFuelds.AppendLine(this.sSN.ToString());
            studentFuelds.AppendLine(this.mobilePhoneNum.ToString());
            studentFuelds.AppendLine(this.eMail);
            studentFuelds.AppendLine(this.course.ToString());
            studentFuelds.AppendLine("-------------");
            studentFuelds.AppendLine(this.university.ToString());
            studentFuelds.AppendLine(this.faculty.ToString());
            studentFuelds.AppendLine(this.specialty.ToString());

            return studentFuelds.ToString();
        }

        //Equals
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Student inputStudent = obj as Student;

            if ((System.Object)inputStudent == null)
            {
                return false;
            }

            return (this.sSN == inputStudent.sSN);
        }

        //The code below is part from MSDN's tutorial
        public bool Equals(Student inputStudent)
        {
            if ((object)inputStudent == null)
            {
                return false;
            }

            return (this.sSN == inputStudent.sSN);
        }

        //GetHashCode
        public override int GetHashCode()
        {
            return (int)this.sSN;
        }

        //==
        public static bool operator ==(Student studentOne, Student studentTwo)
        {
            if (System.Object.ReferenceEquals(studentOne, studentTwo))
            {
                return true;
            }

            if (((object)studentOne == null) || ((object)studentTwo == null))
            {
                return false;
            }

            return studentOne.sSN == studentTwo.sSN;
        }

        //!=
        public static bool operator !=(Student studentOne, Student studentTwo)
        {
            return !(studentOne.sSN == studentTwo.sSN);
        }

        //Clone
        public object Clone()
        {
            var item = new Student
            (
                firstName = firstName,
                middleName = middleName,
                lastName = lastName,
                sSN = sSN,
                mobilePhoneNum = mobilePhoneNum,
                eMail = eMail,
                course = course,
                university = university,
                faculty = faculty,
                specialty = specialty
            );

            return item;
        }

        //CompareTo
        public int CompareTo(Student inputStudent)
        {
            if (this.firstName != inputStudent.firstName)
            {
                return String.Compare(this.firstName, inputStudent.firstName);
            }
            if (this.middleName != inputStudent.middleName)
            {
                return String.Compare(this.middleName, inputStudent.middleName);
            }
            if (this.lastName != inputStudent.lastName)
            {
                return String.Compare(this.lastName, inputStudent.lastName);
            }
            if (this.sSN != inputStudent.sSN)
            {
                return (int)(this.sSN - inputStudent.sSN);
            }

            return 0;
        }
    }
}
