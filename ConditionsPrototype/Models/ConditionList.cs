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
            //if (conditions.Count == 0)
            //{
            //    return true;
            //}

            ////If there is only one condition return that items outcome
            //if (conditions.Count == 1)
            //{
            //    return conditions[0].Outcome;
            //}

            //// Find open groupings if they exist
            //var startIndex = conditions.FindNextOpen();

            //if (startIndex != -1)
            //{
            //    var endIndex = conditions.FindNextEnd();

            //    if (endIndex != -1)
            //    {
            //        if (startIndex <= endIndex)
            //        {
            //            // 
            //        }
            //    }
            //}
            //else
            //{
            //    // Handle stuff
            //}






            
            if (conditions.Count == 0)
            {
                return true;
            }

            if (conditions.Count == 1)
            {
                return conditions[0].Outcome;
            }


            bool current = true;
            Connector currentConnector;


            // For splicing in the correct answer for a group
            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i].LeftGrouping)
                {
                    var groupCount = conditions.FindGroupLength(i);

                    if (groupCount == -1)
                    {
                        // A valid group end could not be found for the group start. Configuration must be wrong
                        throw new InvalidProgramException();
                    }
                    else if (groupCount == 0)
                    {
                        //Group is just itself
                    }
                    else
                    {
                        //Insert the sub items list back into the main list
                        conditions[i + groupCount] = Evaluate(new ConditionList(conditions.GetRange(i, groupCount).ToList()));
                    }
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        private int FindGroupLength(int start)
        {
            if (conditions.Count == 0)
            {
                return -1;
            }

            // If the condition in the opening group index does not open a group then return false
            if (!conditions[start].LeftGrouping)
            {
                return -1;
            }

            int groupEnd = 0;
            int count = 0;

            for (int i = start; i < conditions.Count; i++)
            {
                count++;
                // 
                if (conditions[i].LeftGrouping)
                {
                    groupEnd++;
                }

                // 
                if (conditions[i].RightGrouping)
                {
                    groupEnd--;
                }

                // 
                if (groupEnd == 0)
                {
                    return count;
                }
            }
            return -1;
        }
    }
}
