using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsPrototype.Models
{
    public class ConditionList : ICollection<Condition>
    {
        public ConditionList()
        {
            conditions = new List<Condition>();
        }

        private ConditionList(List<Condition> conditions)
        {
            this.conditions = conditions;
        }

        public List<Condition> conditions { get; set; }

        public Condition this[int index]
        {
            get
            {
                return conditions[index];
            }
            set
            {
                conditions[index] = value;
            }
        }

        public int Count => conditions.Count;

        public bool IsReadOnly => false;

        public void Add(Condition item)
        {
            conditions.Add(item);
        }

        private ConditionList GetRange(int index, int count)
        {
            return new ConditionList(conditions.GetRange(index, count));
        }

        public void Clear()
        {
            conditions.Clear();
        }

        public bool Contains(Condition item)
        {
            return conditions.Contains(item);
        }

        public void CopyTo(Condition[] array, int arrayIndex)
        {
            conditions.CopyTo(array, arrayIndex);
        }

        public int FindIndex(Predicate<Condition> match)
        {
            return conditions.FindIndex(match);
        }

        public IEnumerator<Condition> GetEnumerator()
        {
            return conditions.GetEnumerator();
        }

        public bool Remove(Condition item)
        {
            return conditions.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return conditions.GetEnumerator();
        }

        public bool Outcome
        {
            get
            {
                return Evaluate(this);
            }
        }

        private bool Evaluate(ConditionList conditions)
        {
            //If conditions are empty return true
            if (conditions.Count == 0)
            {
                return true;
            }

            //If there is only one condition return that items outcome
            if (conditions.Count == 1)
            {
                return conditions[0].Outcome;
            }

            // Find open groupings if they exist
            var startIndex = conditions.FindNextOpen();

            if (startIndex != -1)
            {
                var endIndex = conditions.FindNextEnd();

                if (endIndex)
                {

                }
            }
        }

        private int FindNextOpen()
        {
            return conditions.FindIndex(con => con.LeftGrouping);
        }

        private int FindNextEnd()
        {
            return conditions.FindIndex(con => con.RightGrouping);
        }
    }
}
