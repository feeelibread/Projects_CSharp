using System;
using System.Collections.Generic;
using System.Text;

namespace List_Exercise_2
{
    public class Base
    {
        public Guid _id { get; set; }

        public Base()
        {
            _id = Guid.NewGuid();
        }
    }
}
