namespace ConditionsPrototype
{
    partial class ConditionView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbOpenGrouping = new System.Windows.Forms.CheckBox();
            this.cbCloseGrouping = new System.Windows.Forms.CheckBox();
            this.rbgConstant = new System.Windows.Forms.RadioButton();
            this.txtConstant = new System.Windows.Forms.TextBox();
            this.rbgVariable = new System.Windows.Forms.RadioButton();
            this.cbVariable = new System.Windows.Forms.ComboBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.cbLeftVariable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbConnector = new System.Windows.Forms.ComboBox();
            this.lblConnector = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbOpenGrouping
            // 
            this.cbOpenGrouping.AutoSize = true;
            this.cbOpenGrouping.Location = new System.Drawing.Point(45, 12);
            this.cbOpenGrouping.Name = "cbOpenGrouping";
            this.cbOpenGrouping.Size = new System.Drawing.Size(98, 17);
            this.cbOpenGrouping.TabIndex = 0;
            this.cbOpenGrouping.Text = "Open Grouping";
            this.cbOpenGrouping.UseVisualStyleBackColor = true;
            // 
            // cbCloseGrouping
            // 
            this.cbCloseGrouping.AutoSize = true;
            this.cbCloseGrouping.Location = new System.Drawing.Point(45, 302);
            this.cbCloseGrouping.Name = "cbCloseGrouping";
            this.cbCloseGrouping.Size = new System.Drawing.Size(98, 17);
            this.cbCloseGrouping.TabIndex = 1;
            this.cbCloseGrouping.Text = "Close Grouping";
            this.cbCloseGrouping.UseVisualStyleBackColor = true;
            // 
            // rbgConstant
            // 
            this.rbgConstant.AutoSize = true;
            this.rbgConstant.Location = new System.Drawing.Point(45, 193);
            this.rbgConstant.Name = "rbgConstant";
            this.rbgConstant.Size = new System.Drawing.Size(67, 17);
            this.rbgConstant.TabIndex = 2;
            this.rbgConstant.TabStop = true;
            this.rbgConstant.Text = "Constant";
            this.rbgConstant.UseVisualStyleBackColor = true;
            // 
            // txtConstant
            // 
            this.txtConstant.Location = new System.Drawing.Point(45, 216);
            this.txtConstant.Name = "txtConstant";
            this.txtConstant.Size = new System.Drawing.Size(100, 20);
            this.txtConstant.TabIndex = 3;
            // 
            // rbgVariable
            // 
            this.rbgVariable.AutoSize = true;
            this.rbgVariable.Location = new System.Drawing.Point(45, 243);
            this.rbgVariable.Name = "rbgVariable";
            this.rbgVariable.Size = new System.Drawing.Size(63, 17);
            this.rbgVariable.TabIndex = 4;
            this.rbgVariable.TabStop = true;
            this.rbgVariable.Text = "Variable";
            this.rbgVariable.UseVisualStyleBackColor = true;
            // 
            // cbVariable
            // 
            this.cbVariable.FormattingEnabled = true;
            this.cbVariable.Location = new System.Drawing.Point(45, 266);
            this.cbVariable.Name = "cbVariable";
            this.cbVariable.Size = new System.Drawing.Size(121, 21);
            this.cbVariable.TabIndex = 5;
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Location = new System.Drawing.Point(45, 131);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(121, 21);
            this.cbOperator.TabIndex = 6;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(45, 112);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(48, 13);
            this.lblOperator.TabIndex = 7;
            this.lblOperator.Text = "Operator";
            // 
            // cbLeftVariable
            // 
            this.cbLeftVariable.FormattingEnabled = true;
            this.cbLeftVariable.Location = new System.Drawing.Point(48, 71);
            this.cbLeftVariable.Name = "cbLeftVariable";
            this.cbLeftVariable.Size = new System.Drawing.Size(121, 21);
            this.cbLeftVariable.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Variable";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(298, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cbConnector
            // 
            this.cbConnector.FormattingEnabled = true;
            this.cbConnector.Location = new System.Drawing.Point(45, 344);
            this.cbConnector.Name = "cbConnector";
            this.cbConnector.Size = new System.Drawing.Size(121, 21);
            this.cbConnector.TabIndex = 12;
            // 
            // lblConnector
            // 
            this.lblConnector.AutoSize = true;
            this.lblConnector.Location = new System.Drawing.Point(51, 326);
            this.lblConnector.Name = "lblConnector";
            this.lblConnector.Size = new System.Drawing.Size(56, 13);
            this.lblConnector.TabIndex = 13;
            this.lblConnector.Text = "Connector";
            // 
            // ConditionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 406);
            this.Controls.Add(this.lblConnector);
            this.Controls.Add(this.cbConnector);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLeftVariable);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.cbVariable);
            this.Controls.Add(this.rbgVariable);
            this.Controls.Add(this.txtConstant);
            this.Controls.Add(this.rbgConstant);
            this.Controls.Add(this.cbCloseGrouping);
            this.Controls.Add(this.cbOpenGrouping);
            this.Name = "ConditionView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOpenGrouping;
        private System.Windows.Forms.CheckBox cbCloseGrouping;
        private System.Windows.Forms.RadioButton rbgConstant;
        private System.Windows.Forms.TextBox txtConstant;
        private System.Windows.Forms.RadioButton rbgVariable;
        private System.Windows.Forms.ComboBox cbVariable;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.ComboBox cbLeftVariable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbConnector;
        private System.Windows.Forms.Label lblConnector;
    }
}

