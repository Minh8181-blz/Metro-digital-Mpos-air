using System;

namespace MPosAir.Application.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string name, long id)
        {
            EntityId = id;
            EntityName = name;
        }

        public long EntityId { get; set; }
        public string EntityName { get; set; }
    }
}
