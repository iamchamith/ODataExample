using OData.Model;
using System.Collections.Generic;

namespace OData.Repository
{
    public class StudentManagementSystemRepository
    {
        public static List<Subject> GetSubject =>
            new List<Subject>() {
                new Subject(1,"C sharp"),
                   new Subject(2,"Java"),
                      new Subject(3,"Javascript"),
                         new Subject(4,"Perl"),
                            new Subject(5,"Python"),
            };


        public static List<Teacher> GetTeachers =>
            new List<Teacher>
            {
                new Teacher(1,"Kamal").SetSubject(GetSubject[0]),
                new Teacher(2,"Ruwan").SetSubject(GetSubject[1]),
                new Teacher(3,"Amal").SetSubject(GetSubject[2]),
                new Teacher(4,"Pathum").SetSubject(GetSubject[3]),
                new Teacher(5,"Nimal").SetSubject(GetSubject[4])
            };

        public static List<Student> GetStudents => new List<Student> {
            new Student(1,"Ruwini").AddSubject(GetSubject[0])
            .AddSubject(GetSubject[1]),
             new Student(2,"Nayani").AddSubject(GetSubject[0])
            .AddSubject(GetSubject[1])
            .AddSubject(GetSubject[4]),
              new Student(3,"Pawani").AddSubject(GetSubject[0])
            .AddSubject(GetSubject[1])
              .AddSubject(GetSubject[2])
              .AddSubject(GetSubject[3])
              .AddSubject(GetSubject[4])
        };
    }
}
