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

namespace ConditionsPrototype
{
    public partial class ConditionView : Form
    {
        public Condition curCondition;
        public List<Enum.Operator> operators = new List<Enum.Operator>();

        public ConditionView(Condition item = null)
        {
            InitializeComponent();

            if (item == null)
            {
                curCondition = new Condition();
            }
            else
            {
                curCondition = item;
            }

            operators.Add(Enum.Operator.EqualTo);
            operators.Add(Enum.Operator.NotEqualTo);
            operators.Add(Enum.Operator.GreaterThan);
            operators.Add(Enum.Operator.GreaterThanOrEqualTo);
            operators.Add(Enum.Operator.LessThan);
            operators.Add(Enum.Operator.LessThanOrEqualTo);

            LoadComponent();
        }

        private void LoadComponent()
        {
            cbLeftVariable.DataSource = ConditionListView.Variables.ToList();
            cbVariable.DataSource = ConditionListView.Variables.ToList();
            cbOperator.DataSource = operators.ToList();
            cbOperator.SelectedItem = curCondition.conditionOperator;
            cbOperator.DisplayMember = "Symbol";
            cbOpenGrouping.Checked = curCondition.LeftGrouping;
            cbCloseGrouping.Checked = curCondition.RightGrouping;

            if (curCondition.LeftItem != null)
            {
                cbLeftVariable.SelectedItem = curCondition.LeftItem;
            }

            if (curCondition.ItemType == ItemType.Static)
            {
                rbgConstant.Checked = true;
                txtConstant.Text = ((float)curCondition.RightValue).ToString();
            }
            else
            {
                rbgVariable.Checked = true;
                cbVariable.SelectedItem = ((Variable)curCondition.RightValue);
            }

            cbConnector.DataSource = System.Enum.GetValues(typeof(Connector));
            cbConnector.SelectedItem = curCondition.conditionConnector;

        }

        private void SaveComponent()
        {
            curCondition.LeftGrouping = cbOpenGrouping.Checked;
            curCondition.RightGrouping = cbCloseGrouping.Checked;

            if (rbgVariable.Checked)
            {
                curCondition.ItemType = ItemType.Dynamic;
                curCondition.RightValue = cbVariable.SelectedItem;
            }
            else
            {
                curCondition.ItemType = ItemType.Static;

                if (float.TryParse(txtConstant.Text, out float num))
                {
                    curCondition.RightValue = num;
                }
                else
                {
                    MessageBox.Show("Cannot convert to float");
                    return;
                }
            }

            curCondition.LeftItem = (Variable)cbLeftVariable.SelectedItem;
            curCondition.conditionOperator = (Enum.Operator)cbOperator.SelectedItem;
            curCondition.conditionConnector = (Connector)cbConnector.SelectedItem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveComponent();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
