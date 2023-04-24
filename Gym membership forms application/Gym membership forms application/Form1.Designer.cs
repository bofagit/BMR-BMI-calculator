namespace Gym_membership_forms_application
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_VHeavyExersise = new System.Windows.Forms.RadioButton();
            this.radioButton_HeavyExersise = new System.Windows.Forms.RadioButton();
            this.radioButton_ModerateExersise = new System.Windows.Forms.RadioButton();
            this.radioButton_LightExersise = new System.Windows.Forms.RadioButton();
            this.radioButton_NoExcersise = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Output_TargetBMI = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_Output_WC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_OutputKCal = new System.Windows.Forms.Label();
            this.label_Output_BMI = new System.Windows.Forms.Label();
            this.label_Output_BMR = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age:";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(55, 9);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(140, 20);
            this.textBox_Age.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight (Kg):";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(108, 42);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(140, 20);
            this.textBox_Weight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height (Cm):";
            // 
            // textBox_Height
            // 
            this.textBox_Height.Location = new System.Drawing.Point(108, 76);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(140, 20);
            this.textBox_Height.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_VHeavyExersise);
            this.groupBox1.Controls.Add(this.radioButton_HeavyExersise);
            this.groupBox1.Controls.Add(this.radioButton_ModerateExersise);
            this.groupBox1.Controls.Add(this.radioButton_LightExersise);
            this.groupBox1.Controls.Add(this.radioButton_NoExcersise);
            this.groupBox1.Location = new System.Drawing.Point(15, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 140);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excersise Frequency:";
            // 
            // radioButton_VHeavyExersise
            // 
            this.radioButton_VHeavyExersise.AutoSize = true;
            this.radioButton_VHeavyExersise.Location = new System.Drawing.Point(6, 111);
            this.radioButton_VHeavyExersise.Name = "radioButton_VHeavyExersise";
            this.radioButton_VHeavyExersise.Size = new System.Drawing.Size(303, 17);
            this.radioButton_VHeavyExersise.TabIndex = 13;
            this.radioButton_VHeavyExersise.Text = "Very Heavy exersise (twice per day, extra heavy workouts).";
            this.radioButton_VHeavyExersise.UseVisualStyleBackColor = false;
            // 
            // radioButton_HeavyExersise
            // 
            this.radioButton_HeavyExersise.AutoSize = true;
            this.radioButton_HeavyExersise.Location = new System.Drawing.Point(6, 88);
            this.radioButton_HeavyExersise.Name = "radioButton_HeavyExersise";
            this.radioButton_HeavyExersise.Size = new System.Drawing.Size(196, 17);
            this.radioButton_HeavyExersise.TabIndex = 12;
            this.radioButton_HeavyExersise.Text = "Heavy exersise (5-7 days per week).";
            this.radioButton_HeavyExersise.UseVisualStyleBackColor = false;
            // 
            // radioButton_ModerateExersise
            // 
            this.radioButton_ModerateExersise.AutoSize = true;
            this.radioButton_ModerateExersise.Location = new System.Drawing.Point(6, 65);
            this.radioButton_ModerateExersise.Name = "radioButton_ModerateExersise";
            this.radioButton_ModerateExersise.Size = new System.Drawing.Size(210, 17);
            this.radioButton_ModerateExersise.TabIndex = 11;
            this.radioButton_ModerateExersise.Text = "Moderate exersise (3-5 days per week).";
            this.radioButton_ModerateExersise.UseVisualStyleBackColor = false;
            // 
            // radioButton_LightExersise
            // 
            this.radioButton_LightExersise.AutoSize = true;
            this.radioButton_LightExersise.Location = new System.Drawing.Point(6, 42);
            this.radioButton_LightExersise.Name = "radioButton_LightExersise";
            this.radioButton_LightExersise.Size = new System.Drawing.Size(185, 17);
            this.radioButton_LightExersise.TabIndex = 10;
            this.radioButton_LightExersise.Text = "Light exesise (1-3 days per week).";
            this.radioButton_LightExersise.UseVisualStyleBackColor = false;
            // 
            // radioButton_NoExcersise
            // 
            this.radioButton_NoExcersise.AutoSize = true;
            this.radioButton_NoExcersise.Checked = true;
            this.radioButton_NoExcersise.Location = new System.Drawing.Point(6, 19);
            this.radioButton_NoExcersise.Name = "radioButton_NoExcersise";
            this.radioButton_NoExcersise.Size = new System.Drawing.Size(118, 17);
            this.radioButton_NoExcersise.TabIndex = 9;
            this.radioButton_NoExcersise.TabStop = true;
            this.radioButton_NoExcersise.Text = "Little to no exersise.";
            this.radioButton_NoExcersise.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Female);
            this.groupBox2.Controls.Add(this.radioButton_Male);
            this.groupBox2.Location = new System.Drawing.Point(15, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 74);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender:";
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(6, 42);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(59, 17);
            this.radioButton_Female.TabIndex = 1;
            this.radioButton_Female.Text = "Female";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Checked = true;
            this.radioButton_Male.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Male.TabIndex = 0;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 77);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Output_TargetBMI);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label_Output_WC);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label_OutputKCal);
            this.groupBox3.Controls.Add(this.label_Output_BMI);
            this.groupBox3.Controls.Add(this.label_Output_BMR);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(337, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 185);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // label_Output_TargetBMI
            // 
            this.label_Output_TargetBMI.AutoSize = true;
            this.label_Output_TargetBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Output_TargetBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Output_TargetBMI.Location = new System.Drawing.Point(91, 88);
            this.label_Output_TargetBMI.Name = "label_Output_TargetBMI";
            this.label_Output_TargetBMI.Size = new System.Drawing.Size(2, 20);
            this.label_Output_TargetBMI.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label9.Location = new System.Drawing.Point(9, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Target BMI:";
            // 
            // label_Output_WC
            // 
            this.label_Output_WC.AutoSize = true;
            this.label_Output_WC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Output_WC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Output_WC.Location = new System.Drawing.Point(153, 122);
            this.label_Output_WC.Name = "label_Output_WC";
            this.label_Output_WC.Size = new System.Drawing.Size(2, 20);
            this.label_Output_WC.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label8.Location = new System.Drawing.Point(9, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Current weight class:";
            // 
            // label_OutputKCal
            // 
            this.label_OutputKCal.AutoSize = true;
            this.label_OutputKCal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_OutputKCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_OutputKCal.Location = new System.Drawing.Point(288, 156);
            this.label_OutputKCal.Name = "label_OutputKCal";
            this.label_OutputKCal.Size = new System.Drawing.Size(2, 20);
            this.label_OutputKCal.TabIndex = 5;
            // 
            // label_Output_BMI
            // 
            this.label_Output_BMI.AutoSize = true;
            this.label_Output_BMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Output_BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Output_BMI.Location = new System.Drawing.Point(96, 52);
            this.label_Output_BMI.Name = "label_Output_BMI";
            this.label_Output_BMI.Size = new System.Drawing.Size(2, 20);
            this.label_Output_BMI.TabIndex = 4;
            // 
            // label_Output_BMR
            // 
            this.label_Output_BMR.AutoSize = true;
            this.label_Output_BMR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Output_BMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_Output_BMR.Location = new System.Drawing.Point(104, 20);
            this.label_Output_BMR.Name = "label_Output_BMR";
            this.label_Output_BMR.Size = new System.Drawing.Size(2, 20);
            this.label_Output_BMR.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(9, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "Number of daily KCals to maintain weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Current BMI:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Current BMR:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 357);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gym Calculations";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_VHeavyExersise;
        private System.Windows.Forms.RadioButton radioButton_HeavyExersise;
        private System.Windows.Forms.RadioButton radioButton_ModerateExersise;
        private System.Windows.Forms.RadioButton radioButton_LightExersise;
        private System.Windows.Forms.RadioButton radioButton_NoExcersise;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_OutputKCal;
        private System.Windows.Forms.Label label_Output_BMI;
        private System.Windows.Forms.Label label_Output_BMR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_Output_WC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Output_TargetBMI;
        private System.Windows.Forms.Label label9;
    }
}

