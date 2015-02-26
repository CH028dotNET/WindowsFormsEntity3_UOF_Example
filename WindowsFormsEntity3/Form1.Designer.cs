namespace WindowsFormsEntity3
{
    partial class Form1
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
            this.dataGridGroups = new System.Windows.Forms.DataGridView();
            this.btnShowGroups = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.dataGridSubjects = new System.Windows.Forms.DataGridView();
            this.btnShowSubjects = new System.Windows.Forms.Button();
            this.dataGridGroupToSubject = new System.Windows.Forms.DataGridView();
            this.btnShowGrToSubj = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnUpdateSubject = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStudentGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroupToSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGroups
            // 
            this.dataGridGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGroups.Location = new System.Drawing.Point(69, 43);
            this.dataGridGroups.Name = "dataGridGroups";
            this.dataGridGroups.Size = new System.Drawing.Size(240, 150);
            this.dataGridGroups.TabIndex = 0;
            this.dataGridGroups.SelectionChanged += new System.EventHandler(this.dataGridGroups_SelectionChanged);
            // 
            // btnShowGroups
            // 
            this.btnShowGroups.Location = new System.Drawing.Point(143, 14);
            this.btnShowGroups.Name = "btnShowGroups";
            this.btnShowGroups.Size = new System.Drawing.Size(95, 23);
            this.btnShowGroups.TabIndex = 1;
            this.btnShowGroups.Text = "Show Groups";
            this.btnShowGroups.UseVisualStyleBackColor = true;
            this.btnShowGroups.Click += new System.EventHandler(this.btnShowGroups_Click);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Location = new System.Drawing.Point(444, 43);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.Size = new System.Drawing.Size(240, 150);
            this.dataGridStudents.TabIndex = 2;
            this.dataGridStudents.SelectionChanged += new System.EventHandler(this.dataGridStudents_SelectionChanged);
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(513, 13);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(111, 23);
            this.btnShowStudents.TabIndex = 3;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // dataGridSubjects
            // 
            this.dataGridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSubjects.Location = new System.Drawing.Point(800, 43);
            this.dataGridSubjects.Name = "dataGridSubjects";
            this.dataGridSubjects.Size = new System.Drawing.Size(240, 150);
            this.dataGridSubjects.TabIndex = 4;
            this.dataGridSubjects.SelectionChanged += new System.EventHandler(this.dataGridSubjects_SelectionChanged);
            // 
            // btnShowSubjects
            // 
            this.btnShowSubjects.Location = new System.Drawing.Point(861, 12);
            this.btnShowSubjects.Name = "btnShowSubjects";
            this.btnShowSubjects.Size = new System.Drawing.Size(104, 23);
            this.btnShowSubjects.TabIndex = 5;
            this.btnShowSubjects.Text = "Show Subjects";
            this.btnShowSubjects.UseVisualStyleBackColor = true;
            this.btnShowSubjects.Click += new System.EventHandler(this.btnShowSubjects_Click);
            // 
            // dataGridGroupToSubject
            // 
            this.dataGridGroupToSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGroupToSubject.Location = new System.Drawing.Point(444, 377);
            this.dataGridGroupToSubject.Name = "dataGridGroupToSubject";
            this.dataGridGroupToSubject.Size = new System.Drawing.Size(240, 150);
            this.dataGridGroupToSubject.TabIndex = 6;
            // 
            // btnShowGrToSubj
            // 
            this.btnShowGrToSubj.Location = new System.Drawing.Point(513, 348);
            this.btnShowGrToSubj.Name = "btnShowGrToSubj";
            this.btnShowGrToSubj.Size = new System.Drawing.Size(111, 23);
            this.btnShowGrToSubj.TabIndex = 7;
            this.btnShowGrToSubj.Text = "Show Subjects";
            this.btnShowGrToSubj.UseVisualStyleBackColor = true;
            this.btnShowGrToSubj.Click += new System.EventHandler(this.btnShowGrToSubj_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Location = new System.Drawing.Point(143, 225);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(95, 23);
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(143, 199);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroup.TabIndex = 9;
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(143, 255);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteGroup.TabIndex = 10;
            this.btnDeleteGroup.Text = "Delete Group";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            this.btnDeleteGroup.Click += new System.EventHandler(this.btnDeleteGroup_Click);
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.Location = new System.Drawing.Point(143, 285);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.Size = new System.Drawing.Size(95, 23);
            this.btnUpdateGroup.TabIndex = 11;
            this.btnUpdateGroup.Text = "Update Group";
            this.btnUpdateGroup.UseVisualStyleBackColor = true;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(884, 199);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubject.TabIndex = 12;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(884, 225);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(100, 23);
            this.btnAddSubject.TabIndex = 13;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(884, 255);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteSubject.TabIndex = 14;
            this.btnDeleteSubject.Text = "Delete Subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnUpdateSubject
            // 
            this.btnUpdateSubject.Location = new System.Drawing.Point(884, 284);
            this.btnUpdateSubject.Name = "btnUpdateSubject";
            this.btnUpdateSubject.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateSubject.TabIndex = 15;
            this.btnUpdateSubject.Text = "Update Subject";
            this.btnUpdateSubject.UseVisualStyleBackColor = true;
            this.btnUpdateSubject.Click += new System.EventHandler(this.btnUpdateSubject_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(445, 270);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 38);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(528, 270);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(75, 38);
            this.btnDeleteStudent.TabIndex = 17;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(609, 270);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(75, 38);
            this.btnUpdateStudent.TabIndex = 18;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(441, 199);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Age:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(441, 216);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 23;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(441, 238);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(547, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Group:";
            // 
            // comboBoxStudentGroup
            // 
            this.comboBoxStudentGroup.FormattingEnabled = true;
            this.comboBoxStudentGroup.Location = new System.Drawing.Point(583, 198);
            this.comboBoxStudentGroup.Name = "comboBoxStudentGroup";
            this.comboBoxStudentGroup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudentGroup.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 564);
            this.Controls.Add(this.comboBoxStudentGroup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnUpdateSubject);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.btnUpdateGroup);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.btnAddGroup);
            this.Controls.Add(this.btnShowGrToSubj);
            this.Controls.Add(this.dataGridGroupToSubject);
            this.Controls.Add(this.btnShowSubjects);
            this.Controls.Add(this.dataGridSubjects);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.dataGridStudents);
            this.Controls.Add(this.btnShowGroups);
            this.Controls.Add(this.dataGridGroups);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGroupToSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGroups;
        private System.Windows.Forms.Button btnShowGroups;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.DataGridView dataGridSubjects;
        private System.Windows.Forms.Button btnShowSubjects;
        private System.Windows.Forms.DataGridView dataGridGroupToSubject;
        private System.Windows.Forms.Button btnShowGrToSubj;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnUpdateGroup;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnUpdateSubject;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStudentGroup;
    }
}

