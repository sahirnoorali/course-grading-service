namespace WindowsFormsApplication1
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.studentTab = new System.Windows.Forms.TabPage();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.submitStudentButton = new System.Windows.Forms.Button();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.fnameText = new System.Windows.Forms.TextBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.lnameText = new System.Windows.Forms.TextBox();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.assessmentTab = new System.Windows.Forms.TabPage();
            this.submitAssessmentButton = new System.Windows.Forms.Button();
            this.numComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.marksLeftLabel = new System.Windows.Forms.Label();
            this.marksLeftDescLabel = new System.Windows.Forms.Label();
            this.marksTextBox = new System.Windows.Forms.TextBox();
            this.aMarksLabel = new System.Windows.Forms.Label();
            this.aComboBox = new System.Windows.Forms.ComboBox();
            this.atypeLabel = new System.Windows.Forms.Label();
            this.marksTab = new System.Windows.Forms.TabPage();
            this.stdComboBox = new System.Windows.Forms.ComboBox();
            this.marksObtTextBox = new System.Windows.Forms.TextBox();
            this.aTypeComboBox = new System.Windows.Forms.ComboBox();
            this.marksLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddMarksButton = new System.Windows.Forms.Button();
            this.a_typeLabel = new System.Windows.Forms.Label();
            this.stdIdLabel = new System.Windows.Forms.Label();
            this.gradeSheetTab = new System.Windows.Forms.TabPage();
            this.gradeSheetGridView = new System.Windows.Forms.DataGridView();
            this.printGradeButton = new System.Windows.Forms.Button();
            this.generateGradeTab = new System.Windows.Forms.TabPage();
            this.generateGradeButton = new System.Windows.Forms.Button();
            this.gradeGridView = new System.Windows.Forms.DataGridView();
            this.TabControl.SuspendLayout();
            this.studentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.assessmentTab.SuspendLayout();
            this.marksTab.SuspendLayout();
            this.gradeSheetTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeSheetGridView)).BeginInit();
            this.generateGradeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.studentTab);
            this.TabControl.Controls.Add(this.assessmentTab);
            this.TabControl.Controls.Add(this.marksTab);
            this.TabControl.Controls.Add(this.gradeSheetTab);
            this.TabControl.Controls.Add(this.generateGradeTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(576, 354);
            this.TabControl.TabIndex = 19;
            // 
            // studentTab
            // 
            this.studentTab.Controls.Add(this.studentGridView);
            this.studentTab.Controls.Add(this.submitStudentButton);
            this.studentTab.Controls.Add(this.fnameLabel);
            this.studentTab.Controls.Add(this.fnameText);
            this.studentTab.Controls.Add(this.addStudentButton);
            this.studentTab.Controls.Add(this.lnameText);
            this.studentTab.Controls.Add(this.lnameLabel);
            this.studentTab.Location = new System.Drawing.Point(4, 22);
            this.studentTab.Name = "studentTab";
            this.studentTab.Size = new System.Drawing.Size(568, 328);
            this.studentTab.TabIndex = 4;
            this.studentTab.Text = "Add Student(s)";
            this.studentTab.UseVisualStyleBackColor = true;
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(14, 62);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.ReadOnly = true;
            this.studentGridView.Size = new System.Drawing.Size(543, 212);
            this.studentGridView.TabIndex = 25;
            // 
            // submitStudentButton
            // 
            this.submitStudentButton.Location = new System.Drawing.Point(253, 296);
            this.submitStudentButton.Name = "submitStudentButton";
            this.submitStudentButton.Size = new System.Drawing.Size(75, 23);
            this.submitStudentButton.TabIndex = 24;
            this.submitStudentButton.Text = "Submit";
            this.submitStudentButton.UseVisualStyleBackColor = true;
            this.submitStudentButton.Click += new System.EventHandler(this.submitStudentButton_Click);
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(11, 12);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(88, 13);
            this.fnameLabel.TabIndex = 19;
            this.fnameLabel.Text = "Enter First Name:";
            // 
            // fnameText
            // 
            this.fnameText.Location = new System.Drawing.Point(115, 9);
            this.fnameText.Name = "fnameText";
            this.fnameText.Size = new System.Drawing.Size(100, 20);
            this.fnameText.TabIndex = 22;
            this.fnameText.TextChanged += new System.EventHandler(this.fnameText_TextChanged);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(482, 9);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 23);
            this.addStudentButton.TabIndex = 21;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // lnameText
            // 
            this.lnameText.Location = new System.Drawing.Point(356, 9);
            this.lnameText.Name = "lnameText";
            this.lnameText.Size = new System.Drawing.Size(100, 20);
            this.lnameText.TabIndex = 23;
            this.lnameText.TextChanged += new System.EventHandler(this.lnameText_TextChanged);
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Location = new System.Drawing.Point(250, 12);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(89, 13);
            this.lnameLabel.TabIndex = 20;
            this.lnameLabel.Text = "Enter Last Name:";
            // 
            // assessmentTab
            // 
            this.assessmentTab.Controls.Add(this.submitAssessmentButton);
            this.assessmentTab.Controls.Add(this.numComboBox);
            this.assessmentTab.Controls.Add(this.label1);
            this.assessmentTab.Controls.Add(this.marksLeftLabel);
            this.assessmentTab.Controls.Add(this.marksLeftDescLabel);
            this.assessmentTab.Controls.Add(this.marksTextBox);
            this.assessmentTab.Controls.Add(this.aMarksLabel);
            this.assessmentTab.Controls.Add(this.aComboBox);
            this.assessmentTab.Controls.Add(this.atypeLabel);
            this.assessmentTab.Location = new System.Drawing.Point(4, 22);
            this.assessmentTab.Name = "assessmentTab";
            this.assessmentTab.Size = new System.Drawing.Size(568, 328);
            this.assessmentTab.TabIndex = 3;
            this.assessmentTab.Text = "Add Assessment";
            this.assessmentTab.UseVisualStyleBackColor = true;
            // 
            // submitAssessmentButton
            // 
            this.submitAssessmentButton.Location = new System.Drawing.Point(147, 245);
            this.submitAssessmentButton.Name = "submitAssessmentButton";
            this.submitAssessmentButton.Size = new System.Drawing.Size(75, 23);
            this.submitAssessmentButton.TabIndex = 15;
            this.submitAssessmentButton.Text = "Submit";
            this.submitAssessmentButton.UseVisualStyleBackColor = true;
            this.submitAssessmentButton.Click += new System.EventHandler(this.submitAssessmentButton_Click);
            // 
            // numComboBox
            // 
            this.numComboBox.FormattingEnabled = true;
            this.numComboBox.Location = new System.Drawing.Point(194, 88);
            this.numComboBox.Name = "numComboBox";
            this.numComboBox.Size = new System.Drawing.Size(121, 21);
            this.numComboBox.TabIndex = 14;
            this.numComboBox.SelectedIndexChanged += new System.EventHandler(this.numComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Assessment Number:";
            // 
            // marksLeftLabel
            // 
            this.marksLeftLabel.AutoSize = true;
            this.marksLeftLabel.Location = new System.Drawing.Point(195, 186);
            this.marksLeftLabel.Name = "marksLeftLabel";
            this.marksLeftLabel.Size = new System.Drawing.Size(0, 13);
            this.marksLeftLabel.TabIndex = 11;
            // 
            // marksLeftDescLabel
            // 
            this.marksLeftDescLabel.AutoSize = true;
            this.marksLeftDescLabel.Location = new System.Drawing.Point(53, 186);
            this.marksLeftDescLabel.Name = "marksLeftDescLabel";
            this.marksLeftDescLabel.Size = new System.Drawing.Size(60, 13);
            this.marksLeftDescLabel.TabIndex = 10;
            this.marksLeftDescLabel.Text = "Marks Left:";
            // 
            // marksTextBox
            // 
            this.marksTextBox.Location = new System.Drawing.Point(194, 136);
            this.marksTextBox.Name = "marksTextBox";
            this.marksTextBox.Size = new System.Drawing.Size(121, 20);
            this.marksTextBox.TabIndex = 9;
            this.marksTextBox.TextChanged += new System.EventHandler(this.marksTextBox_TextChanged);
            // 
            // aMarksLabel
            // 
            this.aMarksLabel.AutoSize = true;
            this.aMarksLabel.Location = new System.Drawing.Point(53, 136);
            this.aMarksLabel.Name = "aMarksLabel";
            this.aMarksLabel.Size = new System.Drawing.Size(98, 13);
            this.aMarksLabel.TabIndex = 8;
            this.aMarksLabel.Text = "Assessment Marks:";
            // 
            // aComboBox
            // 
            this.aComboBox.FormattingEnabled = true;
            this.aComboBox.Items.AddRange(new object[] {
            "Quiz",
            "Assignment",
            "Mid Term",
            "Final"});
            this.aComboBox.Location = new System.Drawing.Point(194, 39);
            this.aComboBox.Name = "aComboBox";
            this.aComboBox.Size = new System.Drawing.Size(121, 21);
            this.aComboBox.TabIndex = 7;
            this.aComboBox.SelectedIndexChanged += new System.EventHandler(this.aComboBox_SelectedIndexChanged);
            // 
            // atypeLabel
            // 
            this.atypeLabel.AutoSize = true;
            this.atypeLabel.Location = new System.Drawing.Point(53, 42);
            this.atypeLabel.Name = "atypeLabel";
            this.atypeLabel.Size = new System.Drawing.Size(93, 13);
            this.atypeLabel.TabIndex = 6;
            this.atypeLabel.Text = "Assessment Type:";
            // 
            // marksTab
            // 
            this.marksTab.Controls.Add(this.stdComboBox);
            this.marksTab.Controls.Add(this.marksObtTextBox);
            this.marksTab.Controls.Add(this.aTypeComboBox);
            this.marksTab.Controls.Add(this.marksLabel);
            this.marksTab.Controls.Add(this.label3);
            this.marksTab.Controls.Add(this.label2);
            this.marksTab.Controls.Add(this.AddMarksButton);
            this.marksTab.Controls.Add(this.a_typeLabel);
            this.marksTab.Controls.Add(this.stdIdLabel);
            this.marksTab.Location = new System.Drawing.Point(4, 22);
            this.marksTab.Name = "marksTab";
            this.marksTab.Size = new System.Drawing.Size(568, 328);
            this.marksTab.TabIndex = 5;
            this.marksTab.Text = "Add Marks";
            this.marksTab.UseVisualStyleBackColor = true;
            // 
            // stdComboBox
            // 
            this.stdComboBox.FormattingEnabled = true;
            this.stdComboBox.Location = new System.Drawing.Point(182, 43);
            this.stdComboBox.Name = "stdComboBox";
            this.stdComboBox.Size = new System.Drawing.Size(121, 21);
            this.stdComboBox.TabIndex = 21;
            this.stdComboBox.SelectedIndexChanged += new System.EventHandler(this.stdComboBox_SelectedIndexChanged);
            // 
            // marksObtTextBox
            // 
            this.marksObtTextBox.Location = new System.Drawing.Point(182, 190);
            this.marksObtTextBox.Name = "marksObtTextBox";
            this.marksObtTextBox.Size = new System.Drawing.Size(121, 20);
            this.marksObtTextBox.TabIndex = 20;
            this.marksObtTextBox.TextChanged += new System.EventHandler(this.marksObtTextBox_TextChanged);
            // 
            // aTypeComboBox
            // 
            this.aTypeComboBox.FormattingEnabled = true;
            this.aTypeComboBox.Location = new System.Drawing.Point(182, 93);
            this.aTypeComboBox.Name = "aTypeComboBox";
            this.aTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.aTypeComboBox.TabIndex = 18;
            this.aTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.aTypeComboBox_SelectedIndexChanged);
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Location = new System.Drawing.Point(187, 140);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(0, 13);
            this.marksLabel.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Assessment Marks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Marks Obtained:";
            // 
            // AddMarksButton
            // 
            this.AddMarksButton.Location = new System.Drawing.Point(113, 257);
            this.AddMarksButton.Name = "AddMarksButton";
            this.AddMarksButton.Size = new System.Drawing.Size(114, 23);
            this.AddMarksButton.TabIndex = 13;
            this.AddMarksButton.Text = "Add / Update";
            this.AddMarksButton.UseVisualStyleBackColor = true;
            this.AddMarksButton.Click += new System.EventHandler(this.AddMarksButton_Click_1);
            // 
            // a_typeLabel
            // 
            this.a_typeLabel.AutoSize = true;
            this.a_typeLabel.Location = new System.Drawing.Point(58, 93);
            this.a_typeLabel.Name = "a_typeLabel";
            this.a_typeLabel.Size = new System.Drawing.Size(93, 13);
            this.a_typeLabel.TabIndex = 12;
            this.a_typeLabel.Text = "Assessment Type:";
            // 
            // stdIdLabel
            // 
            this.stdIdLabel.AutoSize = true;
            this.stdIdLabel.Location = new System.Drawing.Point(58, 43);
            this.stdIdLabel.Name = "stdIdLabel";
            this.stdIdLabel.Size = new System.Drawing.Size(92, 13);
            this.stdIdLabel.TabIndex = 10;
            this.stdIdLabel.Text = "Student Name-ID:";
            // 
            // gradeSheetTab
            // 
            this.gradeSheetTab.Controls.Add(this.printGradeButton);
            this.gradeSheetTab.Controls.Add(this.gradeSheetGridView);
            this.gradeSheetTab.Location = new System.Drawing.Point(4, 22);
            this.gradeSheetTab.Name = "gradeSheetTab";
            this.gradeSheetTab.Size = new System.Drawing.Size(568, 328);
            this.gradeSheetTab.TabIndex = 6;
            this.gradeSheetTab.Text = "Grade Sheet";
            this.gradeSheetTab.UseVisualStyleBackColor = true;
            // 
            // gradeSheetGridView
            // 
            this.gradeSheetGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeSheetGridView.Location = new System.Drawing.Point(13, 30);
            this.gradeSheetGridView.Name = "gradeSheetGridView";
            this.gradeSheetGridView.ReadOnly = true;
            this.gradeSheetGridView.Size = new System.Drawing.Size(540, 235);
            this.gradeSheetGridView.TabIndex = 0;
            // 
            // printGradeButton
            // 
            this.printGradeButton.Location = new System.Drawing.Point(219, 288);
            this.printGradeButton.Name = "printGradeButton";
            this.printGradeButton.Size = new System.Drawing.Size(121, 23);
            this.printGradeButton.TabIndex = 1;
            this.printGradeButton.Text = "Print Grade Sheet";
            this.printGradeButton.UseVisualStyleBackColor = true;
            this.printGradeButton.Click += new System.EventHandler(this.printGradeButton_Click);
            // 
            // generateGradeTab
            // 
            this.generateGradeTab.Controls.Add(this.generateGradeButton);
            this.generateGradeTab.Controls.Add(this.gradeGridView);
            this.generateGradeTab.Location = new System.Drawing.Point(4, 22);
            this.generateGradeTab.Name = "generateGradeTab";
            this.generateGradeTab.Size = new System.Drawing.Size(568, 328);
            this.generateGradeTab.TabIndex = 7;
            this.generateGradeTab.Text = "Generate Grade";
            this.generateGradeTab.UseVisualStyleBackColor = true;
            // 
            // generateGradeButton
            // 
            this.generateGradeButton.Location = new System.Drawing.Point(220, 282);
            this.generateGradeButton.Name = "generateGradeButton";
            this.generateGradeButton.Size = new System.Drawing.Size(121, 23);
            this.generateGradeButton.TabIndex = 3;
            this.generateGradeButton.Text = "Generate Grade";
            this.generateGradeButton.UseVisualStyleBackColor = true;
            this.generateGradeButton.Click += new System.EventHandler(this.generateGradeButton_Click);
            // 
            // gradeGridView
            // 
            this.gradeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradeGridView.Location = new System.Drawing.Point(14, 24);
            this.gradeGridView.Name = "gradeGridView";
            this.gradeGridView.ReadOnly = true;
            this.gradeGridView.Size = new System.Drawing.Size(540, 235);
            this.gradeGridView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 378);
            this.Controls.Add(this.TabControl);
            this.Name = "Form1";
            this.Text = "Course Grading System";
            this.TabControl.ResumeLayout(false);
            this.studentTab.ResumeLayout(false);
            this.studentTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.assessmentTab.ResumeLayout(false);
            this.assessmentTab.PerformLayout();
            this.marksTab.ResumeLayout(false);
            this.marksTab.PerformLayout();
            this.gradeSheetTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeSheetGridView)).EndInit();
            this.generateGradeTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage assessmentTab;
        private System.Windows.Forms.Label marksLeftLabel;
        private System.Windows.Forms.Label marksLeftDescLabel;
        private System.Windows.Forms.TextBox marksTextBox;
        private System.Windows.Forms.Label aMarksLabel;
        private System.Windows.Forms.ComboBox aComboBox;
        private System.Windows.Forms.Label atypeLabel;
        private System.Windows.Forms.TabPage studentTab;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.Button submitStudentButton;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox fnameText;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox lnameText;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.ComboBox numComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitAssessmentButton;
        private System.Windows.Forms.TabPage marksTab;
        private System.Windows.Forms.ComboBox aTypeComboBox;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddMarksButton;
        private System.Windows.Forms.Label a_typeLabel;
        private System.Windows.Forms.Label stdIdLabel;
        private System.Windows.Forms.TextBox marksObtTextBox;
        private System.Windows.Forms.ComboBox stdComboBox;
        private System.Windows.Forms.TabPage gradeSheetTab;
        private System.Windows.Forms.Button printGradeButton;
        private System.Windows.Forms.DataGridView gradeSheetGridView;
        private System.Windows.Forms.TabPage generateGradeTab;
        private System.Windows.Forms.Button generateGradeButton;
        private System.Windows.Forms.DataGridView gradeGridView;
    }
}

