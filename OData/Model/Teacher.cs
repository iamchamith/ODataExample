namespace OData.Model
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject Subject { get; set; }

        public Teacher()
        {
        }
        public Teacher(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public Teacher SetSubject(Subject subject)
        {
            Subject = subject;
            return this;
        }
    }
}
