using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsPrototype.Enum
{
    public struct Operator
    {
        public static readonly Operator EqualTo = new Operator(OperatorName.EqualTo, "=", 0);
        public static readonly Operator NotEqualTo = new Operator(OperatorName.NotEqualTo, "<>", 1);
        public static readonly Operator GreaterThan = new Operator(OperatorName.GreaterThan, ">", 2);
        public static readonly Operator GreaterThanOrEqualTo = new Operator(OperatorName.GreaterThanOrEqualTo, ">=", 3);
        public static readonly Operator LessThan = new Operator(OperatorName.LessThan, "<", 4);
        public static readonly Operator LessThanOrEqualTo = new Operator(OperatorName.LessThanOrEqualTo, "<=", 5);

        /// <summary>
        /// Gets the english name of the operator
        /// </summary>
        public OperatorName Name { get; private set; }
        /// <summary>
        /// Gets the symbol of the operator for being shown in dropdown
        /// </summary>
        public string Symbol { get; private set; }
        /// <summary>
        /// Gets the index of the item for saving
        /// </summary>
        public int Index { get; private set; }

        public bool IsDefault => Name == default(OperatorName) && Symbol == default(string) && Index == default(int);

        private Operator(OperatorName name, string symbol, int index)
        {
            this.Name = name;
            this.Symbol = symbol;
            this.Index = index;
        }

        public override string ToString()
        {
            return Symbol;
        }

        public enum OperatorName
        {
            EqualTo,
            NotEqualTo,
            GreaterThan,
            GreaterThanOrEqualTo,
            LessThan,
            LessThanOrEqualTo
        }
    }
}
