namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ABox = new System.Windows.Forms.TextBox();
            this.BBox = new System.Windows.Forms.TextBox();
            this.StepBox = new System.Windows.Forms.TextBox();
            this.RKbut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yrk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yelr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tocn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ind,
            this.Yrk,
            this.Yelr,
            this.Tocn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(523, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // ABox
            // 
            this.ABox.Location = new System.Drawing.Point(12, 241);
            this.ABox.Name = "ABox";
            this.ABox.Size = new System.Drawing.Size(57, 20);
            this.ABox.TabIndex = 1;
            // 
            // BBox
            // 
            this.BBox.Location = new System.Drawing.Point(113, 241);
            this.BBox.Name = "BBox";
            this.BBox.Size = new System.Drawing.Size(57, 20);
            this.BBox.TabIndex = 2;
            // 
            // StepBox
            // 
            this.StepBox.Location = new System.Drawing.Point(213, 241);
            this.StepBox.Name = "StepBox";
            this.StepBox.Size = new System.Drawing.Size(57, 20);
            this.StepBox.TabIndex = 3;
            // 
            // RKbut
            // 
            this.RKbut.Location = new System.Drawing.Point(82, 301);
            this.RKbut.Name = "RKbut";
            this.RKbut.Size = new System.Drawing.Size(100, 33);
            this.RKbut.TabIndex = 4;
            this.RKbut.Text = "Calc";
            this.RKbut.UseVisualStyleBackColor = true;
            this.RKbut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Начало интервала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Конец интервала";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Step";
            // 
            // Ind
            // 
            this.Ind.HeaderText = "Индекс";
            this.Ind.Name = "Ind";
            this.Ind.ReadOnly = true;
            // 
            // Yrk
            // 
            this.Yrk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Yrk.HeaderText = "Метод Рунге-Кутта";
            this.Yrk.Name = "Yrk";
            this.Yrk.ReadOnly = true;
            this.Yrk.Width = 116;
            // 
            // Yelr
            // 
            this.Yelr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Yelr.HeaderText = "Модифицированный метод Эйлера";
            this.Yelr.Name = "Yelr";
            this.Yelr.ReadOnly = true;
            this.Yelr.Width = 157;
            // 
            // Tocn
            // 
            this.Tocn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tocn.HeaderText = "Точное решение";
            this.Tocn.Name = "Tocn";
            this.Tocn.ReadOnly = true;
            this.Tocn.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 555);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RKbut);
            this.Controls.Add(this.StepBox);
            this.Controls.Add(this.BBox);
            this.Controls.Add(this.ABox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ABox;
        private System.Windows.Forms.TextBox BBox;
        private System.Windows.Forms.TextBox StepBox;
        private System.Windows.Forms.Button RKbut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yrk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yelr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tocn;
    }
}

