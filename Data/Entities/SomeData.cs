using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class SomeData : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

    }
}
