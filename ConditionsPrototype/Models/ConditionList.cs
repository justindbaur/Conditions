using System;
using System.Collections;
using System.Collections.Generic;

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
                return Evaluate(this.conditions);
            }
        }

        private bool Evaluate(List<Condition> conditions)
        {
            // Set starting variables
            bool previousOutcome = true;
            Connector previousConnector = Connector.And;

            for (int i = 0; i < conditions.Count; i++)
            {
                if (conditions[i].LeftGrouping)
                {
                    var groupCount = FindGroupLength(i, conditions);

                    // Is group just that single item?
                    if (groupCount == 0)
                    {
                        previousOutcome = FindOutcome(previousOutcome, previousConnector, conditions[i].Outcome);
                        previousConnector = conditions[i].ConditionConnector;
                        continue;
                    }
                    else if (groupCount < conditions.Count) // If group is only sub group of entire list evalulate qpty7
                    {
                        // Evaluate sub group with previous item
                        previousOutcome = FindOutcome(previousOutcome, previousConnector, Evaluate(conditions.GetRange(i, groupCount)));
                        previousConnector = conditions[i + (groupCount - 1)].ConditionConnector;
                        i = i + (groupCount - 1);
                        continue;
                    }
                    else if (groupCount == conditions.Count)
                    {

                        previousOutcome = FindOutcome(previousOutcome, previousConnector, conditions[i].Outcome);
                        previousConnector = conditions[i].ConditionConnector;
                        continue;
                    }
                }
                else
                {

                    previousOutcome = FindOutcome(previousOutcome, previousConnector, conditions[i].Outcome);
                    previousConnector = conditions[i].ConditionConnector;
                    continue;
                }
            }

            return previousOutcome;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        private int FindGroupLength(int start, List<Condition> conditions)
        {
            if (conditions.Count == 0 || !conditions[start].LeftGrouping)
            {
                throw new Exception("Start position does not start a group");
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

            throw new Exception("End Point could not be found.");
        }

        private bool FindOutcome(bool first, Connector connector, bool second)
        {
            switch (connector)
            {
                case Connector.And:
                    return first && second;
                case Connector.Or:
                    return first || second;
                case Connector.Xor:
                    return first ^ second;
                default:
                    throw new ArgumentOutOfRangeException($"Connector of { connector } not recognized.");
            }
        }
    }
}
