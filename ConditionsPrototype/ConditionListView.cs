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
            Variables.Add(new Variable("ValueOne", 1));
            Variables.Add(new Variable("ValueTen", 10));

            conditions.Add(new Condition(Variables[0], Enum.Operator.EqualTo, 8, Grouping.OpenGrouping, Connector.And));
            conditions.Add(new Condition(Variables[1], Enum.Operator.GreaterThan, 4));

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
    }
}
