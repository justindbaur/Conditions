using ConditionsPrototype.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsPrototype.Models
{
    public class Condition
    {
        private Grouping grouping { get; set; }

        public bool LeftGrouping {
            get
            {
                return (grouping == Grouping.OpenGrouping || grouping == Grouping.OpenAndCloseGrouping);
            }
            set
            {
                if (value)
                {
                    if (RightGrouping)
                    {
                        grouping = Grouping.OpenAndCloseGrouping;
                    }
                    else
                    {
                        grouping = Grouping.OpenGrouping;
                    }
                }
                else
                {
                    if (RightGrouping)
                    {
                        grouping = Grouping.CloseGrouping;
                    }
                    else
                    {
                        grouping = Grouping.NoGrouping;
                    }
                }
            }
        }
        public bool RightGrouping
        {
            get
            {
                return (grouping == Grouping.CloseGrouping || grouping == Grouping.OpenAndCloseGrouping);
            }
            set
            {
                if (value)
                {
                    if (LeftGrouping)
                    {
                        grouping = Grouping.OpenAndCloseGrouping;
                    }
                    else
                    {
                        grouping = Grouping.CloseGrouping;
                    }
                }
                else
                {
                    if (LeftGrouping)
                    {
                        grouping = Grouping.OpenGrouping;
                    }
                    else
                    {
                        grouping = Grouping.NoGrouping;
                    }
                }
            }
        }

        public Operator conditionOperator { get; set;}

        public Connector conditionConnector { get; set; }

        private Variable leftObject { get; set; }

        public Variable LeftItem
        {
            get
            {
                return leftObject;
            }
            set
            {
                leftObject = value;
            }

        }

        private object rightObject { get; set; }
        public ItemType ItemType { get; set; }

        public object RightItem
        {
            get
            {
                if (this.ItemType == ItemType.Static)
                {
                    if (float.TryParse(this.rightObject.ToString(), out float result))
                    {
                        return result;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    Variable item = (Variable)this.rightObject;
                    return item;
                }
            }
            set
            {
                rightObject = value;
            }
        }

        public float LeftValue
        {
            get
            {
                return LeftItem.Value;
            }
        }

        public float RightValue
        {
            get
            {
                return ItemType == ItemType.Dynamic ? ((Variable)rightObject).Value : (float)rightObject;
            }
        }

        public Condition()
        {
            this.ItemType = ItemType.Static;
            this.rightObject = 0;
            this.conditionOperator = Enum.Operator.EqualTo;
            this.grouping = Grouping.NoGrouping;
            this.conditionConnector = Connector.And;
        }

        public Condition(Variable leftValue, Operator op, Variable rightValue, Grouping grouping, Connector connector)
        {
            this.leftObject = leftValue;
            this.conditionOperator = op;
            this.ItemType = ItemType.Dynamic;
            this.rightObject = rightValue;
            this.grouping = grouping;
            this.conditionConnector = connector;
        }

        public Condition(Variable leftValue, Operator op, float rightValue, Grouping grouping, Connector connector)
        {
            this.leftObject = leftValue;
            this.conditionOperator = op;
            this.ItemType = ItemType.Static;
            this.RightItem = rightValue;
            this.grouping = grouping;
            this.conditionConnector = connector;
        }

        public Condition(Variable leftValue, Operator op, Variable rightValue)
        {
            this.leftObject = leftValue;
            this.conditionOperator = op;
            this.ItemType = ItemType.Dynamic;
            this.rightObject = rightValue;
            this.grouping = Grouping.NoGrouping;
            this.conditionConnector = Connector.And;
        }

        public Condition(Variable leftValue, Operator op, float rightValue)
        {
            this.leftObject = leftValue;
            this.conditionOperator = op;
            this.ItemType = ItemType.Static;
            this.rightObject = rightValue;
            this.grouping = Grouping.NoGrouping;
            this.conditionConnector = Connector.And;
        }

        public object[] GetObject()
        {
            var oa = new object[6];

            oa[0] = this.LeftGrouping;
            oa[1] = this.LeftItem.Name;
            oa[2] = this.conditionOperator;
            oa[3] = this.RightItem;
            oa[4] = this.RightGrouping;
            oa[5] = this.conditionConnector;

            return oa;
        }

        public bool Outcome
        {
            get
            {
                switch (this.conditionOperator.Name)
                {
                    case Operator.OperatorName.EqualTo:
                        return LeftValue == RightValue;
                    case Operator.OperatorName.NotEqualTo:
                        return LeftValue != RightValue;
                    case Operator.OperatorName.GreaterThan:
                        return LeftValue > RightValue;
                    case Operator.OperatorName.GreaterThanOrEqualTo:
                        return LeftValue >= RightValue;
                    case Operator.OperatorName.LessThan:
                        return LeftValue < RightValue;
                    case Operator.OperatorName.LessThanOrEqualTo:
                        return LeftValue <= RightValue;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
    }

    public enum Grouping
    {
        NoGrouping,
        OpenGrouping,
        CloseGrouping,
        OpenAndCloseGrouping
    }

    public enum Connector
    {
        And,
        Or
    }

    public enum ItemType
    {
        Static,
        Dynamic
    }
}
