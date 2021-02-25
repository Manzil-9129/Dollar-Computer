
namespace Dollar_Computer
{
    partial class Select
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
            this.components = new System.ComponentModel.Container();
            this.LaptopdataGridview = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laptopDataDataSet = new Dollar_Computer.LaptopDataDataSet();
            this.dataSet1 = new Dollar_Computer.DataSet1();
            this.tableTableAdapter = new Dollar_Computer.LaptopDataDataSetTableAdapters.TableTableAdapter();
            this.Next = new System.Windows.Forms.Button();
            this.Selectedtextbox = new System.Windows.Forms.TextBox();
            this.SelectionL = new System.Windows.Forms.Label();
            this.HL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LaptopdataGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // LaptopdataGridview
            // 
            this.LaptopdataGridview.AutoGenerateColumns = false;
            this.LaptopdataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LaptopdataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.memoryDataGridViewTextBoxColumn,
            this.cPUBrandDataGridViewTextBoxColumn,
            this.cPUTypeDataGridViewTextBoxColumn,
            this.cPUSpeedDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn});
            this.LaptopdataGridview.DataSource = this.tableBindingSource;
            this.LaptopdataGridview.Location = new System.Drawing.Point(52, 48);
            this.LaptopdataGridview.Name = "LaptopdataGridview";
            this.LaptopdataGridview.RowHeadersWidth = 51;
            this.LaptopdataGridview.RowTemplate.Height = 24;
            this.LaptopdataGridview.Size = new System.Drawing.Size(727, 325);
            this.LaptopdataGridview.TabIndex = 0;
            this.LaptopdataGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LaptopdataGridview_CellClick);
            this.LaptopdataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // memoryDataGridViewTextBoxColumn
            // 
            this.memoryDataGridViewTextBoxColumn.DataPropertyName = "Memory";
            this.memoryDataGridViewTextBoxColumn.HeaderText = "Memory";
            this.memoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memoryDataGridViewTextBoxColumn.Name = "memoryDataGridViewTextBoxColumn";
            this.memoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUBrandDataGridViewTextBoxColumn
            // 
            this.cPUBrandDataGridViewTextBoxColumn.DataPropertyName = "CPU Brand";
            this.cPUBrandDataGridViewTextBoxColumn.HeaderText = "CPU Brand";
            this.cPUBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUBrandDataGridViewTextBoxColumn.Name = "cPUBrandDataGridViewTextBoxColumn";
            this.cPUBrandDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUTypeDataGridViewTextBoxColumn
            // 
            this.cPUTypeDataGridViewTextBoxColumn.DataPropertyName = "CPU Type";
            this.cPUTypeDataGridViewTextBoxColumn.HeaderText = "CPU Type";
            this.cPUTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUTypeDataGridViewTextBoxColumn.Name = "cPUTypeDataGridViewTextBoxColumn";
            this.cPUTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUSpeedDataGridViewTextBoxColumn
            // 
            this.cPUSpeedDataGridViewTextBoxColumn.DataPropertyName = "CPU Speed";
            this.cPUSpeedDataGridViewTextBoxColumn.HeaderText = "CPU Speed";
            this.cPUSpeedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUSpeedDataGridViewTextBoxColumn.Name = "cPUSpeedDataGridViewTextBoxColumn";
            this.cPUSpeedDataGridViewTextBoxColumn.Width = 125;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.Width = 125;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.laptopDataDataSet;
            // 
            // laptopDataDataSet
            // 
            this.laptopDataDataSet.DataSetName = "LaptopDataDataSet";
            this.laptopDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(675, 407);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 31);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Selectedtextbox
            // 
            this.Selectedtextbox.Location = new System.Drawing.Point(198, 407);
            this.Selectedtextbox.Name = "Selectedtextbox";
            this.Selectedtextbox.Size = new System.Drawing.Size(267, 22);
            this.Selectedtextbox.TabIndex = 3;
            // 
            // SelectionL
            // 
            this.SelectionL.AutoSize = true;
            this.SelectionL.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionL.Location = new System.Drawing.Point(39, 407);
            this.SelectionL.Name = "SelectionL";
            this.SelectionL.Size = new System.Drawing.Size(120, 23);
            this.SelectionL.TabIndex = 4;
            this.SelectionL.Text = "Your Selection";
            // 
            // HL
            // 
            this.HL.AutoSize = true;
            this.HL.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HL.Location = new System.Drawing.Point(20, 21);
            this.HL.Name = "HL";
            this.HL.Size = new System.Drawing.Size(119, 24);
            this.HL.TabIndex = 5;
            this.HL.Text = "Computer List";
            this.HL.Click += new System.EventHandler(this.HL_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.HL);
            this.Controls.Add(this.SelectionL);
            this.Controls.Add(this.Selectedtextbox);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.LaptopdataGridview);
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LaptopdataGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laptopDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LaptopdataGridview;
        private DataSet1 dataSet1;
        private LaptopDataDataSet laptopDataDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private LaptopDataDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox Selectedtextbox;
        private System.Windows.Forms.Label SelectionL;
        private System.Windows.Forms.Label HL;
    }
}