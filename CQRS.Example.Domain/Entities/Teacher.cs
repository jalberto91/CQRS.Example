namespace CQRS.Example.Domain.Entities
{
    public class Teacher : BaseEntity
    {
        public string Name { get; set; }

        public int KnowledgeLevel { get; set; }

        public List<Student> Students { get; set; } = [];
    }
}