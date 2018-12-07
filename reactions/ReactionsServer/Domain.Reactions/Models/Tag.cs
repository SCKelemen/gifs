using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Reactions.Models
{
    public class Tag
    {
        public ulong Id { get; }
        public string Value { get; }

        // this one probably doesnt make much sense
        public ulong Items { get; }
    }
}
