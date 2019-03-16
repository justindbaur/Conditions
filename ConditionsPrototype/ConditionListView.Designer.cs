namespace ConditionsPrototype
{
    partial class ConditionListView
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
            this.dgvConditions = new System.Windows.Forms.DataGridView();
            this.OpenGrouping = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LeftItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseGrouping = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Connection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConditions
            // 
            this.dgvConditions.AllowUserToAddRows = false;
            this.dgvConditions.AllowUserToDeleteRows = false;
            this.dgvConditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConditions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OpenGrouping,
            this.LeftItem,
            this.Operator,
            this.RightItem,
            this.CloseGrouping,
            this.Connection});
            this.dgvConditions.Location = new System.Drawing.Point(12, 12);
            this.dgvConditions.MultiSelect = false;
            this.dgvConditions.Name = "dgvConditions";
            this.dgvConditions.ReadOnly = true;
            this.dgvConditions.RowHeadersVisible = false;
            this.dgvConditions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConditions.Size = new System.Drawing.Size(473, 368);
            this.dgvConditions.TabIndex = 0;
            // 
            // OpenGrouping
            // 
            this.OpenGrouping.HeaderText = "(";
            this.OpenGrouping.Name = "OpenGrouping";
            this.OpenGrouping.ReadOnly = true;
            this.OpenGrouping.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OpenGrouping.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.OpenGrouping.Width = 25;
            // 
            // LeftItem
            // 
            this.LeftItem.HeaderText = "Left Item";
            this.LeftItem.Name = "LeftItem";
            this.LeftItem.ReadOnly = true;
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            this.Operator.ReadOnly = true;
            // 
            // RightItem
            // 
            this.RightItem.HeaderText = "Right Item";
            this.RightItem.Name = "RightItem";
            this.RightItem.ReadOnly = true;
            // 
            // CloseGrouping
            // 
            this.CloseGrouping.HeaderText = ")";
            this.CloseGrouping.Name = "CloseGrouping";
            this.CloseGrouping.ReadOnly = true;
            this.CloseGrouping.Width = 25;
            // 
            // Connection
            // 
            this.Connection.HeaderText = "Connection";
            this.Connection.Name = "Connection";
            this.Connection.ReadOnly = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(410, 415);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(329, 415);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(248, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(12, 415);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 23);
            this.btnExecute.TabIndex = 4;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // ConditionListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvConditions);
            this.Name = "ConditionListView";
            this.Text = "ConditionView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConditions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConditions;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OpenGrouping;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CloseGrouping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Connection;
    }
}