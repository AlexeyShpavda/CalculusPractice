namespace SmallQuestionnaire
{
    partial class Questionnaire
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
            this.caption = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.labelForName = new System.Windows.Forms.Label();
            this.textBoxForName = new System.Windows.Forms.TextBox();
            this.labelForSurname = new System.Windows.Forms.Label();
            this.textBoxForSurname = new System.Windows.Forms.TextBox();
            this.labelForGender = new System.Windows.Forms.Label();
            this.labelForDateOfBirth = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxForGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxForMarried = new System.Windows.Forms.CheckBox();
            this.buttonForSave = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.Location = new System.Drawing.Point(135, 9);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(38, 13);
            this.caption.TabIndex = 0;
            this.caption.Text = "FORM";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttonForSave);
            this.mainPanel.Controls.Add(this.checkBoxForMarried);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.comboBoxForGender);
            this.mainPanel.Controls.Add(this.DateOfBirth);
            this.mainPanel.Controls.Add(this.labelForDateOfBirth);
            this.mainPanel.Controls.Add(this.labelForGender);
            this.mainPanel.Controls.Add(this.textBoxForSurname);
            this.mainPanel.Controls.Add(this.labelForSurname);
            this.mainPanel.Controls.Add(this.textBoxForName);
            this.mainPanel.Controls.Add(this.labelForName);
            this.mainPanel.Location = new System.Drawing.Point(12, 25);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(283, 224);
            this.mainPanel.TabIndex = 1;
            // 
            // labelForName
            // 
            this.labelForName.AutoSize = true;
            this.labelForName.Location = new System.Drawing.Point(6, 19);
            this.labelForName.Name = "labelForName";
            this.labelForName.Size = new System.Drawing.Size(38, 13);
            this.labelForName.TabIndex = 0;
            this.labelForName.Text = "Name:";
            // 
            // textBoxForName
            // 
            this.textBoxForName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxForName.Location = new System.Drawing.Point(78, 19);
            this.textBoxForName.Name = "textBoxForName";
            this.textBoxForName.Size = new System.Drawing.Size(197, 20);
            this.textBoxForName.TabIndex = 1;
            // 
            // labelForSurname
            // 
            this.labelForSurname.AutoSize = true;
            this.labelForSurname.Location = new System.Drawing.Point(6, 52);
            this.labelForSurname.Name = "labelForSurname";
            this.labelForSurname.Size = new System.Drawing.Size(52, 13);
            this.labelForSurname.TabIndex = 2;
            this.labelForSurname.Text = "Surname:";
            // 
            // textBoxForSurname
            // 
            this.textBoxForSurname.Location = new System.Drawing.Point(78, 52);
            this.textBoxForSurname.Name = "textBoxForSurname";
            this.textBoxForSurname.Size = new System.Drawing.Size(197, 20);
            this.textBoxForSurname.TabIndex = 3;
            // 
            // labelForGender
            // 
            this.labelForGender.AutoSize = true;
            this.labelForGender.Location = new System.Drawing.Point(6, 84);
            this.labelForGender.Name = "labelForGender";
            this.labelForGender.Size = new System.Drawing.Size(45, 13);
            this.labelForGender.TabIndex = 4;
            this.labelForGender.Text = "Gender:";
            // 
            // labelForDateOfBirth
            // 
            this.labelForDateOfBirth.AutoSize = true;
            this.labelForDateOfBirth.Location = new System.Drawing.Point(6, 115);
            this.labelForDateOfBirth.Name = "labelForDateOfBirth";
            this.labelForDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.labelForDateOfBirth.TabIndex = 6;
            this.labelForDateOfBirth.Text = "Date of Birth:";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(78, 115);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(197, 20);
            this.DateOfBirth.TabIndex = 7;
            // 
            // comboBoxForGender
            // 
            this.comboBoxForGender.FormattingEnabled = true;
            this.comboBoxForGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxForGender.Location = new System.Drawing.Point(78, 84);
            this.comboBoxForGender.Name = "comboBoxForGender";
            this.comboBoxForGender.Size = new System.Drawing.Size(197, 21);
            this.comboBoxForGender.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Are you married?";
            // 
            // checkBoxForMarried
            // 
            this.checkBoxForMarried.AutoSize = true;
            this.checkBoxForMarried.Location = new System.Drawing.Point(176, 153);
            this.checkBoxForMarried.Name = "checkBoxForMarried";
            this.checkBoxForMarried.Size = new System.Drawing.Size(15, 14);
            this.checkBoxForMarried.TabIndex = 10;
            this.checkBoxForMarried.UseVisualStyleBackColor = true;
            // 
            // buttonForSave
            // 
            this.buttonForSave.Location = new System.Drawing.Point(98, 184);
            this.buttonForSave.Name = "buttonForSave";
            this.buttonForSave.Size = new System.Drawing.Size(88, 28);
            this.buttonForSave.TabIndex = 11;
            this.buttonForSave.Text = "Save";
            this.buttonForSave.UseVisualStyleBackColor = true;
            this.buttonForSave.Click += new System.EventHandler(this.buttonForSave_Click);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 261);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.caption);
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label labelForName;
        private System.Windows.Forms.CheckBox checkBoxForMarried;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxForGender;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Label labelForDateOfBirth;
        private System.Windows.Forms.Label labelForGender;
        private System.Windows.Forms.TextBox textBoxForSurname;
        private System.Windows.Forms.Label labelForSurname;
        private System.Windows.Forms.TextBox textBoxForName;
        private System.Windows.Forms.Button buttonForSave;
    }
}

