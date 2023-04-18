namespace Cakes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cakeName1 = new System.Windows.Forms.TextBox();
            this.buttonSearchOne = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sumCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.averageCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.minCost = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cakeName2 = new System.Windows.Forms.TextBox();
            this.buttonFindCalories = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonShowCount = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.Color.AliceBlue;
            this.output.Location = new System.Drawing.Point(705, 31);
            this.output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output.Size = new System.Drawing.Size(646, 786);
            this.output.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonShowAll);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 118);
            this.panel1.TabIndex = 3;
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(473, 9);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(141, 29);
            this.buttonShowAll.TabIndex = 8;
            this.buttonShowAll.Text = "Показать\r\n";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(39, 83);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(348, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "сортировать по убыванию цены";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(39, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(373, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "сортировать по возрастанию цены";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Информация обо всех тортах";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cakeName1);
            this.panel2.Controls.Add(this.buttonSearchOne);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 100);
            this.panel2.TabIndex = 4;
            // 
            // cakeName1
            // 
            this.cakeName1.Location = new System.Drawing.Point(18, 44);
            this.cakeName1.Name = "cakeName1";
            this.cakeName1.Size = new System.Drawing.Size(414, 28);
            this.cakeName1.TabIndex = 6;
            // 
            // buttonSearchOne
            // 
            this.buttonSearchOne.Location = new System.Drawing.Point(473, 43);
            this.buttonSearchOne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearchOne.Name = "buttonSearchOne";
            this.buttonSearchOne.Size = new System.Drawing.Size(141, 29);
            this.buttonSearchOne.TabIndex = 4;
            this.buttonSearchOne.Text = "Поиск";
            this.buttonSearchOne.UseVisualStyleBackColor = true;
            this.buttonSearchOne.Click += new System.EventHandler(this.buttonSearchOne_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск информации о торте по названию:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.sumCost);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.averageCost);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.maxCost);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.minCost);
            this.panel3.Controls.Add(this.buttonCalc);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(12, 512);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 256);
            this.panel3.TabIndex = 5;
            // 
            // sumCost
            // 
            this.sumCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sumCost.Location = new System.Drawing.Point(370, 153);
            this.sumCost.Name = "sumCost";
            this.sumCost.ReadOnly = true;
            this.sumCost.Size = new System.Drawing.Size(244, 21);
            this.sumCost.TabIndex = 12;
            this.sumCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Общая стоимость всех тортов:\r\n";
            // 
            // averageCost
            // 
            this.averageCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.averageCost.Location = new System.Drawing.Point(370, 108);
            this.averageCost.Name = "averageCost";
            this.averageCost.ReadOnly = true;
            this.averageCost.Size = new System.Drawing.Size(244, 21);
            this.averageCost.TabIndex = 10;
            this.averageCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Средняя стоимость торта:\r\n";
            // 
            // maxCost
            // 
            this.maxCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maxCost.Location = new System.Drawing.Point(370, 61);
            this.maxCost.Name = "maxCost";
            this.maxCost.ReadOnly = true;
            this.maxCost.Size = new System.Drawing.Size(244, 21);
            this.maxCost.TabIndex = 8;
            this.maxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Максимальная стоимость торта:\r\n";
            // 
            // minCost
            // 
            this.minCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minCost.Location = new System.Drawing.Point(370, 14);
            this.minCost.Name = "minCost";
            this.minCost.ReadOnly = true;
            this.minCost.Size = new System.Drawing.Size(244, 21);
            this.minCost.TabIndex = 6;
            this.minCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(473, 209);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(141, 29);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Найти";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Минимальная стоимость торта:\r\n";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cakeName2);
            this.panel4.Controls.Add(this.buttonFindCalories);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(12, 400);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 95);
            this.panel4.TabIndex = 6;
            // 
            // cakeName2
            // 
            this.cakeName2.Location = new System.Drawing.Point(18, 44);
            this.cakeName2.Name = "cakeName2";
            this.cakeName2.Size = new System.Drawing.Size(414, 28);
            this.cakeName2.TabIndex = 6;
            // 
            // buttonFindCalories
            // 
            this.buttonFindCalories.Location = new System.Drawing.Point(473, 44);
            this.buttonFindCalories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFindCalories.Name = "buttonFindCalories";
            this.buttonFindCalories.Size = new System.Drawing.Size(141, 29);
            this.buttonFindCalories.TabIndex = 4;
            this.buttonFindCalories.Text = "Узнать";
            this.buttonFindCalories.UseVisualStyleBackColor = true;
            this.buttonFindCalories.Click += new System.EventHandler(this.buttonFindCalories_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Узнать калорийность по названию торта:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 788);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonShowCount);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(12, 167);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(633, 95);
            this.panel5.TabIndex = 8;
            // 
            // buttonShowCount
            // 
            this.buttonShowCount.Location = new System.Drawing.Point(473, 12);
            this.buttonShowCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonShowCount.Name = "buttonShowCount";
            this.buttonShowCount.Size = new System.Drawing.Size(141, 29);
            this.buttonShowCount.TabIndex = 4;
            this.buttonShowCount.Text = "Показать";
            this.buttonShowCount.UseVisualStyleBackColor = true;
            this.buttonShowCount.Click += new System.EventHandler(this.buttonShowCount_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 12);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(350, 40);
            this.label8.TabIndex = 3;
            this.label8.Text = "Информация о количестве тортов \r\nкаждого бренда";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1364, 829);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.output);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cakes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox output;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private TextBox cakeName;
        private Button buttonSearchOne;
        private Label label2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel3;
        private TextBox sumCost;
        private Label label6;
        private TextBox averageCost;
        private Label label5;
        private TextBox maxCost;
        private Label label4;
        private TextBox minCost;
        private Button buttonCalc;
        private Label label3;
        private Panel panel4;
        private TextBox brand;
        private Button buttonFindCalories;
        private Label label7;
        private Button buttonShowAll;
        private TextBox cakeName1;
        private TextBox cakeName2;
        private Button button1;
        private Panel panel5;
        private Button buttonShowCount;
        private Label label8;
    }
}