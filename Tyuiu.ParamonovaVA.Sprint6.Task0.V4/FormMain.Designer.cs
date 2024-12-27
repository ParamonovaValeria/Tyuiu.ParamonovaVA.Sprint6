namespace Tyuiu.ParamonovaVA.Sprint6.Task0.V4
{
    partial class FormMain
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBoxX = new TextBox();
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            button1 = new Button();
            buttoninfo = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 16);
            textBox1.TabIndex = 0;
            textBox1.Text = "Вычислить выражение";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(448, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 39);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBoxX);
            groupBox2.Location = new Point(12, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 213);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.MenuBar;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.ForeColor = SystemColors.InfoText;
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 1;
            textBox2.Text = "Переменная X:";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(6, 44);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 0;
            textBoxX.TextChanged += textBoxX_TextChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Location = new Point(448, 225);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(340, 117);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод Данных";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Info;
            textBoxResult.Location = new Point(6, 29);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 0;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(639, 371);
            button1.Name = "button1";
            button1.Size = new Size(149, 67);
            button1.TabIndex = 4;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttoninfo
            // 
            buttoninfo.Location = new Point(609, 415);
            buttoninfo.Name = "buttoninfo";
            buttoninfo.Size = new Size(24, 23);
            buttoninfo.TabIndex = 5;
            buttoninfo.Text = "?";
            buttoninfo.UseVisualStyleBackColor = true;
            buttoninfo.Click += buttoninfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(800, 450);
            Controls.Add(buttoninfo);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Таск 0 Спринт 6";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox textBoxX;
        private TextBox textBoxResult;
        private Button buttoninfo;
        private TextBox textBox2;
    }
}