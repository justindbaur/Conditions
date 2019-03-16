using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsPrototype.Models
{
    public class VariableList : ICollection<Variable>
    {
        private List<Variable> variables { get; set; }

        public VariableList()
        {
            variables = new List<Variable>();
        }

        public Variable this[int index]
        {
            get
            {
                return variables[index];
            }
            set
            {
                variables[index] = value;
            }
        }


        public int Count => variables.Count;

        public bool IsReadOnly => false;

        public void Add(Variable item)
        {
            variables.Add(item);
        }

        public void Clear()
        {
            variables.Clear();
        }

        public bool Contains(Variable item)
        {
            return variables.Contains(item);
        }

        public void CopyTo(Variable[] array, int arrayIndex)
        {
            variables.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Variable> GetEnumerator()
        {
            return variables.GetEnumerator();
        }

        public bool Remove(Variable item)
        {
            return variables.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return variables.GetEnumerator();
        }
    }
}
