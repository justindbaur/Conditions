using ConditionsPrototype.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConditionsPrototype.Enum;
using System.Diagnostics;

namespace ConditionsPrototype
{
    public partial class ConditionListView : Form
    {
        public ConditionList conditions;
        public static VariableList Variables;

        private BindingSource bindingSource = new BindingSource();

        public ConditionListView()
        {
            InitializeComponent();

            conditions = new ConditionList();

            Variables = new VariableList();
            Variables.Add(new Variable("Value0" , 0 ));
            Variables.Add(new Variable("Value1" , 1 ));
            Variables.Add(new Variable("Value2" , 2 ));
            Variables.Add(new Variable("Value3" , 3 ));
            Variables.Add(new Variable("Value4" , 4 ));
            Variables.Add(new Variable("Value5" , 5 ));
            Variables.Add(new Variable("Value6" , 6 ));
            Variables.Add(new Variable("Value7" , 7 ));
            Variables.Add(new Variable("Value8" , 8 ));
            Variables.Add(new Variable("Value9" , 9 ));
            Variables.Add(new Variable("Value10", 10));

            int testNum = 8;

            switch (testNum)
            {
                case 1:
                    conditions.Add(new Condition(Variables[5], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    conditions.Add(new Condition(Variables[4], Operator.EqualTo, 10));
                    conditions.Add(new Condition(Variables[5], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    conditions.Add(new Condition(Variables[5], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    conditions.Add(new Condition(Variables[5], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    break;
                case 2:
                    conditions.Add(new Condition(Variables[10], Operator.GreaterThan, 8, Grouping.OpenGrouping, Connector.And));
                    break;
                case 3:
                    conditions.Add(new Condition(Variables[7], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    break;
                case 4:
                    conditions.Add(new Condition(Variables[2], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    break;
                case 5:
                    conditions.Add(new Condition(Variables[6], Operator.GreaterThanOrEqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    break;
                case 6:
                    conditions.Add(new Condition(Variables[8], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    break;
                case 7:
                    conditions.Add(new Condition(Variables[1], Operator.LessThan, 8, Grouping.OpenGrouping, Connector.And));
                    break;
                case 8:
                    conditions.Add(new Condition(Variables[10], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    conditions.Add(new Condition(Variables[1], Operator.GreaterThan, 4));
                    conditions.Add(new Condition(Variables[2], Operator.LessThan, 5, Grouping.CloseGrouping, Connector.Or));
                    conditions.Add(new Condition(Variables[10], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    conditions.Add(new Condition(Variables[1], Operator.GreaterThan, 4));
                    conditions.Add(new Condition(Variables[2], Operator.LessThan, 5, Grouping.CloseGrouping, Connector.Or));
                    break;
                case 9:
                    conditions.Add(new Condition(Variables[10], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    conditions.Add(new Condition(Variables[1], Operator.GreaterThan, 4));
                    conditions.Add(new Condition(Variables[2], Operator.LessThan, 5, Grouping.CloseGrouping, Connector.Or));
                    break;
                case 10:
                    conditions.Add(new Condition(Variables[10], Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
                    conditions.Add(new Condition(Variables[9], Operator.LessThan, 15, Grouping.CloseGrouping, Connector.Or));
                    conditions.Add(new Condition(Variables[5], Operator.NotEqualTo, 6, Grouping.NoGrouping, Connector.Or));
                    break;
                default:
                    break;
            }

            LoadList();

            
        }

        private void LoadList()
        {
            dgvConditions.Rows.Clear();

            foreach (var item in conditions)
            {
                dgvConditions.Rows.Add(item.GetObject());
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ConditionView conditionView = new ConditionView();
            conditionView.ShowDialog();
            if (conditionView.DialogResult == DialogResult.OK)
            {
                conditions.Add(conditionView.curCondition);
                LoadList();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var selectedRowIndex = dgvConditions.SelectedRows[0].Index;

            var item = conditions[selectedRowIndex];

            ConditionView conditionView = new ConditionView(item);
            conditionView.ShowDialog();
            if (conditionView.DialogResult == DialogResult.OK)
            {
                conditions[selectedRowIndex] = conditionView.curCondition;
                LoadList();
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            bool result = conditions.Outcome;
            sw.Stop();
            MessageBox.Show($"Outcome: { result }\nTicks: { sw.ElapsedTicks }");
            sw.Reset();

        }
    }
}
