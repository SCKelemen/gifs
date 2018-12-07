using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Reactions.Models
{
    public class Reaction
    {
        public ulong Id { get; }
        public string Name { get; }
        public string Path { get; }
        public Tag[] Tags { get; }
        public ulong Views { get; }
        public DateTime Created { get; }
        public string CreatedBy { get; }
    }
}
