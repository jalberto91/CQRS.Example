namespace CQRS.Example.Domain.Entities
{
    public class Student : BaseEntity
    {
        public string Name { get; set; }

        public int ListNumber { get; set; }

        public int GroupNumber { get; set; }

        public List<Teacher> Teachers { get; set; } = [];
    }
}