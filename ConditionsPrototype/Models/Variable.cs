using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsPrototype.Models
{
    public class Variable
    {
        public string Name { get; set; }
        public float Value { get; set; }

        public Variable(string name, float value)
        {
            this.Name = name;
            this.Value = value;
        }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
