using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionsPrototype.Enum
{
    public struct Operator
    {
        public static readonly Operator EqualTo = new Operator("EqualTo", "=", 0);
        public static readonly Operator NotEqualTo = new Operator("NotEqualTo", "<>", 1);
        public static readonly Operator GreaterThan = new Operator("GreaterThan", ">", 2);
        public static readonly Operator GreaterThanOrEqualTo = new Operator("GreaterThanOrEqualTo", ">=", 3);
        public static readonly Operator LessThan = new Operator("LessThan", "<", 4);
        public static readonly Operator LessThanOrEqualTo = new Operator("LessThanOrEqualTo", "<=", 5);

        /// <summary>
        /// Gets the english name of the operator
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Gets the symbol of the operator for being shown in dropdown
        /// </summary>
        public string Symbol { get; private set; }
        /// <summary>
        /// Gets the index of the item for saving
        /// </summary>
        public int Index { get; private set; }

        public bool IsDefault => Name == default(string) && Symbol == default(string) && Index == default(int);

        private Operator(string name, string symbol, int index)
        {
            this.Name = name;
            this.Symbol = symbol;
            this.Index = index;
        }

        public override string ToString()
        {
            return Symbol;
        }
    }
}
