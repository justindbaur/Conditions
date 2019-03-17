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

        public int FindIndex(int startIndex, Predicate<Condition> match)
        {
            return conditions.FindIndex(startIndex, match);
        }

        public int FindIndex(int startIndex, int count, Predicate<Condition> match)
        {
            return conditions.FindIndex(startIndex, count, match);
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

                if (endIndex != -1)
                {
                    if (startIndex <= endIndex)
                    {
                        // 
                    }
                }
            }
            else
            {
                // Handle stuff
            }














            
            if (conditions.Count == 0)
            {
                return true;
            }

            if (conditions.Count == 1)
            {
                return conditions[0].Outcome;
            }


            // For splicing in the correct answer for a group
            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i].LeftGrouping)
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

        private bool DoGroupsMatch(int openGroupIndex, int closeGroupIndex)
        {
            // The open grouping index must be less than or equal to the close group index
            if (closeGroupIndex < openGroupIndex)
            {
                throw new IndexOutOfRangeException();
            }

            // If there are no conditions in the list they cannot match
            if (conditions.Count == 0)
            {
                return false;
            }

            // If the condition in the opening group index does not open a group then return false
            if (!conditions[openGroupIndex].LeftGrouping)
            {
                return false;
            }

            // If the condition in the close group index does not close a group then return false
            if (!conditions[closeGroupIndex].RightGrouping)
            {
                return false;
            }

            int count = 0;

            for (int i = openGroupIndex; i < conditions.Count; i++)
            {
                // 
                if (conditions[i].LeftGrouping)
                {
                    count++;
                }

                // 
                if (conditions[i].RightGrouping)
                {
                    count--;
                }

                // 
                if (count == 0)
                {
                    if (i == closeGroupIndex)
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
    }
}
