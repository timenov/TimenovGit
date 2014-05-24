/* 1.Define a class Student, which contains data about a student – first,
 *   middle and last name, SSN, permanent address, mobile phone e-mail, course,
 *   specialty, university, faculty. Use an enumeration for the specialties,
 *   universities and faculties. Override the standard methods, inherited by 
 *   System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * 2.Add implementations of the ICloneable interface. The Clone() method should
 *   deeply copy all object's fields into a new object of type Student.
 * 3.Implement the  IComparable<Student> interface to compare students by names
 *   (as first criteria, in lexicographic order) and by social security number 
 *   (as second criteria, in increasing order).
*/

using System;
using System.Text.RegularExpressions;

namespace _01_03.StudentProject
{
    class MainClass
    {
        static void Main()
        {
            Student[] sss = new Student[] { new Student("Pesho", "Maznikov", "Kalitarov", "third", University.TUSofia),
                                            new Student("Pesho", "Maznikov", "Malitkov", "second", University.UNWE),
                                            new Student("Nikolay", "Maznikov", "Karamfilov", "first", University.NBU),
                                            new Student("Evstati", "Maznikov", "Zurlekov", "fourth", University.UNWE),
                                            new Student("Gramatik", "Maznikov", "Shebekov", "first", University.TUSofia),
                                            new Student("Gosho", "Maznikov", "Angelov", "123456789","some address","0885334123","duduk@kaval.vgz", "second", University.SU, Faculty.FMI, Specialty.NM) };
            //Array.Sort(sss);

            //foreach (var item in sss)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine();
            //}

            Student s = null;
            s = (Student)sss[1].Clone();

            Console.WriteLine(s.LastName);
        }
    }
}
