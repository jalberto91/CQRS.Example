namespace CQRS.Example.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            this.Id = GetNewId();
            this.Active = true;
        }

        public string Id { get; set; }

        public bool Active { get; set; }

        public static string GetNewId()
        {
            return Guid.NewGuid().ToString();
        }
    }
}