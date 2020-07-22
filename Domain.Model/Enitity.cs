using System;

namespace Domain.Model
{
    public abstract class Enitity
    {
        public int? Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
