using System;
using System.Collections.Generic;

namespace MPosAir.Domain.Base
{
    public class EntityBase
    {
        public long Id { get; protected set; }
        public DateTime CreatedAt { get; protected set; }
        public DateTime LastUpdatedAt { get; protected set; }

        protected void SetLastUpdated()
        {
            LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
