
namespace Dollar_Computer
{
    partial class ProductInfo
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
            this.ProductID = new System.Windows.Forms.Label();
            this.ConditionL = new System.Windows.Forms.Label();
            this.CostL = new System.Windows.Forms.Label();
            this.PtextBox = new System.Windows.Forms.TextBox();
            this.Ctextbox = new System.Windows.Forms.TextBox();
            this.Costtextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cpuspeedtextbox = new System.Windows.Forms.TextBox();
            this.Cputypetextbox = new System.Windows.Forms.TextBox();
            this.Cpubrandtextbox = new System.Windows.Forms.TextBox();
            this.Memorytextbox = new System.Windows.Forms.TextBox();
            this.CpuSL = new System.Windows.Forms.Label();
            this.CpuTL = new System.Windows.Forms.Label();
            this.CpuL = new System.Windows.Forms.Label();
            this.MemoryL = new System.Windows.Forms.Label();
            this.Next2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ClickNextL = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.NameL = new System.Windows.Forms.Label();
            this.ModelL = new System.Windows.Forms.Label();
            this.Modeltextbox = new System.Windows.Forms.TextBox();
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.Pgroupbox = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Pgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(54, 74);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(108, 22);
            this.ProductID.TabIndex = 0;
            this.ProductID.Text = "Product ID";
            // 
            // ConditionL
            // 
            this.ConditionL.AutoSize = true;
            this.ConditionL.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionL.Location = new System.Drawing.Point(300, 74);
            this.ConditionL.Name = "ConditionL";
            this.ConditionL.Size = new System.Drawing.Size(100, 22);
            this.ConditionL.TabIndex = 1;
            this.ConditionL.Text = "Condition";
            // 
            // CostL
            // 
            this.CostL.AutoSize = true;
            this.CostL.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostL.Location = new System.Drawing.Point(546, 74);
            this.CostL.Name = "CostL";
            this.CostL.Size = new System.Drawing.Size(53, 22);
            this.CostL.TabIndex = 2;
            this.CostL.Text = "Cost";
            // 
            // PtextBox
            // 
            this.PtextBox.Enabled = false;
            this.PtextBox.Location = new System.Drawing.Point(171, 70);
            this.PtextBox.Name = "PtextBox";
            this.PtextBox.Size = new System.Drawing.Size(100, 22);
            this.PtextBox.TabIndex = 3;
            this.PtextBox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // Ctextbox
            // 
            this.Ctextbox.Enabled = false;
            this.Ctextbox.Location = new System.Drawing.Point(417, 70);
            this.Ctextbox.Name = "Ctextbox";
            this.Ctextbox.Size = new System.Drawing.Size(100, 22);
            this.Ctextbox.TabIndex = 4;
            this.Ctextbox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // Costtextbox
            // 
            this.Costtextbox.Enabled = false;
            this.Costtextbox.Location = new System.Drawing.Point(624, 70);
            this.Costtextbox.Name = "Costtextbox";
            this.Costtextbox.Size = new System.Drawing.Size(100, 22);
            this.Costtextbox.TabIndex = 5;
            this.Costtextbox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cpuspeedtextbox);
            this.groupBox1.Controls.Add(this.Cputypetextbox);
            this.groupBox1.Controls.Add(this.Cpubrandtextbox);
            this.groupBox1.Controls.Add(this.Memorytextbox);
            this.groupBox1.Controls.Add(this.CpuSL);
            this.groupBox1.Controls.Add(this.CpuTL);
            this.groupBox1.Controls.Add(this.CpuL);
            this.groupBox1.Controls.Add(this.MemoryL);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tech specs";
            // 
            // Cpuspeedtextbox
            // 
            this.Cpuspeedtextbox.Enabled = false;
            this.Cpuspeedtextbox.Location = new System.Drawing.Point(450, 110);
            this.Cpuspeedtextbox.Name = "Cpuspeedtextbox";
            this.Cpuspeedtextbox.Size = new System.Drawing.Size(100, 28);
            this.Cpuspeedtextbox.TabIndex = 7;
            this.Cpuspeedtextbox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // Cputypetextbox
            // 
            this.Cputypetextbox.Enabled = false;
            this.Cputypetextbox.Location = new System.Drawing.Point(123, 110);
            this.Cputypetextbox.Name = "Cputypetextbox";
            this.Cputypetextbox.Size = new System.Drawing.Size(100, 28);
            this.Cputypetextbox.TabIndex = 6;
            this.Cputypetextbox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // Cpubrandtextbox
            // 
            this.Cpubrandtextbox.Enabled = false;
            this.Cpubrandtextbox.Location = new System.Drawing.Point(450, 44);
            this.Cpubrandtextbox.Name = "Cpubrandtextbox";
            this.Cpubrandtextbox.Size = new System.Drawing.Size(130, 28);
            this.Cpubrandtextbox.TabIndex = 5;
            this.Cpubrandtextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Cpubrandtextbox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // Memorytextbox
            // 
            this.Memorytextbox.Enabled = false;
            this.Memorytextbox.Location = new System.Drawing.Point(123, 44);
            this.Memorytextbox.Name = "Memorytextbox";
            this.Memorytextbox.Size = new System.Drawing.Size(100, 28);
            this.Memorytextbox.TabIndex = 4;
            this.Memorytextbox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // CpuSL
            // 
            this.CpuSL.AutoSize = true;
            this.CpuSL.Location = new System.Drawing.Point(293, 117);
            this.CpuSL.Name = "CpuSL";
            this.CpuSL.Size = new System.Drawing.Size(114, 22);
            this.CpuSL.TabIndex = 3;
            this.CpuSL.Text = "CPU Speed";
            // 
            // CpuTL
            // 
            this.CpuTL.AutoSize = true;
            this.CpuTL.Location = new System.Drawing.Point(6, 114);
            this.CpuTL.Name = "CpuTL";
            this.CpuTL.Size = new System.Drawing.Size(101, 22);
            this.CpuTL.TabIndex = 2;
            this.CpuTL.Text = "CPU Type";
            // 
            // CpuL
            // 
            this.CpuL.AutoSize = true;
            this.CpuL.Location = new System.Drawing.Point(295, 50);
            this.CpuL.Name = "CpuL";
            this.CpuL.Size = new System.Drawing.Size(112, 22);
            this.CpuL.TabIndex = 1;
            this.CpuL.Text = "CPU Brand";
            // 
            // MemoryL
            // 
            this.MemoryL.AutoSize = true;
            this.MemoryL.Location = new System.Drawing.Point(6, 50);
            this.MemoryL.Name = "MemoryL";
            this.MemoryL.Size = new System.Drawing.Size(86, 22);
            this.MemoryL.TabIndex = 0;
            this.MemoryL.Text = "Memory";
            // 
            // Next2
            // 
            this.Next2.Location = new System.Drawing.Point(696, 407);
            this.Next2.Name = "Next2";
            this.Next2.Size = new System.Drawing.Size(75, 31);
            this.Next2.TabIndex = 8;
            this.Next2.Text = "Next";
            this.Next2.UseVisualStyleBackColor = true;
            this.Next2.Click += new System.EventHandler(this.Next2_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(584, 407);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 31);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ClickNextL
            // 
            this.ClickNextL.AutoSize = true;
            this.ClickNextL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickNextL.Location = new System.Drawing.Point(45, 414);
            this.ClickNextL.Name = "ClickNextL";
            this.ClickNextL.Size = new System.Drawing.Size(235, 50);
            this.ClickNextL.TabIndex = 10;
            this.ClickNextL.Text = "Click Next To Continue\r\n\r\n";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Save Product Info";
            this.saveFileDialog1.Filter = "txt files|*.txt|AllFiles|*.*";
            // 
            // NameL
            // 
            this.NameL.AutoSize = true;
            this.NameL.Location = new System.Drawing.Point(20, 45);
            this.NameL.Name = "NameL";
            this.NameL.Size = new System.Drawing.Size(62, 22);
            this.NameL.TabIndex = 0;
            this.NameL.Text = "Name";
            // 
            // ModelL
            // 
            this.ModelL.AutoSize = true;
            this.ModelL.Location = new System.Drawing.Point(350, 45);
            this.ModelL.Name = "ModelL";
            this.ModelL.Size = new System.Drawing.Size(67, 22);
            this.ModelL.TabIndex = 1;
            this.ModelL.Text = "Model";
            // 
            // Modeltextbox
            // 
            this.Modeltextbox.Enabled = false;
            this.Modeltextbox.Location = new System.Drawing.Point(450, 35);
            this.Modeltextbox.Name = "Modeltextbox";
            this.Modeltextbox.Size = new System.Drawing.Size(130, 28);
            this.Modeltextbox.TabIndex = 2;
            this.Modeltextbox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // Nametextbox
            // 
            this.Nametextbox.Enabled = false;
            this.Nametextbox.Location = new System.Drawing.Point(123, 35);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(100, 28);
            this.Nametextbox.TabIndex = 3;
            this.Nametextbox.Leave += new System.EventHandler(this.Cpuspeedtextbox_Leave);
            // 
            // Pgroupbox
            // 
            this.Pgroupbox.Controls.Add(this.Nametextbox);
            this.Pgroupbox.Controls.Add(this.Modeltextbox);
            this.Pgroupbox.Controls.Add(this.ModelL);
            this.Pgroupbox.Controls.Add(this.NameL);
            this.Pgroupbox.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pgroupbox.Location = new System.Drawing.Point(48, 113);
            this.Pgroupbox.Name = "Pgroupbox";
            this.Pgroupbox.Size = new System.Drawing.Size(667, 97);
            this.Pgroupbox.TabIndex = 6;
            this.Pgroupbox.TabStop = false;
            this.Pgroupbox.Text = "Product Info";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ClickNextL);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Next2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pgroupbox);
            this.Controls.Add(this.Costtextbox);
            this.Controls.Add(this.Ctextbox);
            this.Controls.Add(this.PtextBox);
            this.Controls.Add(this.CostL);
            this.Controls.Add(this.ConditionL);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfo";
            this.Text = "Product Info";
            this.Load += new System.EventHandler(this.ProductInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Pgroupbox.ResumeLayout(false);
            this.Pgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.Label ConditionL;
        private System.Windows.Forms.Label CostL;
        private System.Windows.Forms.TextBox PtextBox;
        private System.Windows.Forms.TextBox Ctextbox;
        private System.Windows.Forms.TextBox Costtextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Cpuspeedtextbox;
        private System.Windows.Forms.TextBox Cputypetextbox;
        private System.Windows.Forms.TextBox Cpubrandtextbox;
        private System.Windows.Forms.TextBox Memorytextbox;
        private System.Windows.Forms.Label CpuSL;
        private System.Windows.Forms.Label CpuTL;
        private System.Windows.Forms.Label CpuL;
        private System.Windows.Forms.Label MemoryL;
        private System.Windows.Forms.Button Next2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label ClickNextL;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label NameL;
        private System.Windows.Forms.Label ModelL;
        private System.Windows.Forms.TextBox Modeltextbox;
        private System.Windows.Forms.TextBox Nametextbox;
        private System.Windows.Forms.GroupBox Pgroupbox;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}