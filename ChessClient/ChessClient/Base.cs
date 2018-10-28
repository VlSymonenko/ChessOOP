using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessClient
{
   public class Base
    {
        public Guid Id;
        public string Name;

        public Base() : this("") { }

        public Base(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
        }
    }
}
