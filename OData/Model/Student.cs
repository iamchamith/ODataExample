using System.Collections.Generic;

namespace OData.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student()
        {
        }
        public Student(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public Student AddSubject(Subject subject) {
            if (Subjects == null)
                Subjects = new List<Subject>();
            Subjects.Add(subject);
            return this;
        }
    }
}
