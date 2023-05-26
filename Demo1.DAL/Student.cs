namespace Demo1.DAL
{
    public class Student
    {
        public Student()
        {
            Active = true;
        }
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; }
    }
}