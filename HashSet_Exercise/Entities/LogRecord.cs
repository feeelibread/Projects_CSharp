using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet_Exercise.Entities
{
    class LogRecord
    {
        public string Name { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string name, DateTime instant)
        {
            Name = name;
            Instant = instant;
        }

        public LogRecord()
        {

        }

        public override bool Equals(object obj)
        {
            return !(obj is LogRecord)
                ? false
                : obj is LogRecord record &&
                   Name == record.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
