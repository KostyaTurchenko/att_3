namespace _10._27
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
            this.InputStudentsDGV = new System.Windows.Forms.DataGridView();
            this.InputStudentsDGV_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputStudentsDGV_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.minPoint = new System.Windows.Forms.NumericUpDown();
            this.minsumOfStudents = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExcludedStudents = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFailOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFailSave = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.InputStudentsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minsumOfStudents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputStudentsDGV
            // 
            this.InputStudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputStudentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InputStudentsDGV_name,
            this.InputStudentsDGV_points});
            this.InputStudentsDGV.Location = new System.Drawing.Point(11, 26);
            this.InputStudentsDGV.Margin = new System.Windows.Forms.Padding(2);
            this.InputStudentsDGV.Name = "InputStudentsDGV";
            this.InputStudentsDGV.RowTemplate.Height = 24;
            this.InputStudentsDGV.Size = new System.Drawing.Size(344, 287);
            this.InputStudentsDGV.TabIndex = 0;
            // 
            // InputStudentsDGV_name
            // 
            this.InputStudentsDGV_name.HeaderText = "Имя и фамилия студента";
            this.InputStudentsDGV_name.Name = "InputStudentsDGV_name";
            this.InputStudentsDGV_name.Width = 200;
            // 
            // InputStudentsDGV_points
            // 
            this.InputStudentsDGV_points.HeaderText = "Сумма баллов";
            this.InputStudentsDGV_points.Name = "InputStudentsDGV_points";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(344, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отчислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // minPoint
            // 
            this.minPoint.Location = new System.Drawing.Point(415, 56);
            this.minPoint.Name = "minPoint";
            this.minPoint.Size = new System.Drawing.Size(104, 20);
            this.minPoint.TabIndex = 2;
            this.minPoint.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // minsumOfStudents
            // 
            this.minsumOfStudents.Location = new System.Drawing.Point(383, 117);
            this.minsumOfStudents.Name = "minsumOfStudents";
            this.minsumOfStudents.Size = new System.Drawing.Size(164, 20);
            this.minsumOfStudents.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Минимальный балл";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Минимальное кол-во студентов";
            // 
            // ExcludedStudents
            // 
            this.ExcludedStudents.Location = new System.Drawing.Point(380, 181);
            this.ExcludedStudents.Name = "ExcludedStudents";
            this.ExcludedStudents.Size = new System.Drawing.Size(167, 173);
            this.ExcludedStudents.TabIndex = 7;
            this.ExcludedStudents.Click += new System.EventHandler(this.ExcludedStudents_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчислены:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFailOpen,
            this.MenuFailSave});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MenuFailOpen
            // 
            this.MenuFailOpen.Name = "MenuFailOpen";
            this.MenuFailOpen.Size = new System.Drawing.Size(152, 22);
            this.MenuFailOpen.Text = "Открыть";
            this.MenuFailOpen.Click += new System.EventHandler(this.MenuFailOpen_Click);
            // 
            // MenuFailSave
            // 
            this.MenuFailSave.Name = "MenuFailSave";
            this.MenuFailSave.Size = new System.Drawing.Size(152, 22);
            this.MenuFailSave.Text = "Сохранить";
            this.MenuFailSave.Click += new System.EventHandler(this.MenuFailSave_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ExcludedStudents);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minsumOfStudents);
            this.Controls.Add(this.minPoint);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputStudentsDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Список студентов";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputStudentsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minsumOfStudents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InputStudentsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputStudentsDGV_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputStudentsDGV_points;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown minPoint;
        private System.Windows.Forms.NumericUpDown minsumOfStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ExcludedStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuFailOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuFailSave;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    }
}

