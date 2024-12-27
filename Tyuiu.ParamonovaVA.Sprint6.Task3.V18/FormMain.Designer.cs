using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.ParamonovaVA.Sprint6.Task3.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_PVA = new GroupBox();
            pictureBoxTask_PVA = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonAbout_PVA = new Button();
            buttonExecute_PVA = new Button();
            dataGridViewTask_PVA = new DataGridView();
            groupBoxOutput_PVA = new GroupBox();
            dataGridViewResult_PVA = new DataGridView();
            labelResult_PVA = new Label();
            groupBoxTask_PVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_PVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_PVA).BeginInit();
            groupBoxOutput_PVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PVA).BeginInit();
            SuspendLayout();
            
            groupBoxTask_PVA.Controls.Add(pictureBoxTask_PVA);
            groupBoxTask_PVA.Location = new Point(12, 12);
            groupBoxTask_PVA.Name = "groupBoxTask_PVA";
            groupBoxTask_PVA.Size = new Size(410, 255);
            groupBoxTask_PVA.TabIndex = 0;
            groupBoxTask_PVA.TabStop = false;
            groupBoxTask_PVA.Text = "Условие";
            
            pictureBoxTask_PVA.Image = (Image)resources.GetObject("pictureBoxTask_PVA.Image");
            pictureBoxTask_PVA.Location = new Point(6, 22);
            pictureBoxTask_PVA.Name = "pictureBoxTask_PVA";
            pictureBoxTask_PVA.Size = new Size(396, 226);
            pictureBoxTask_PVA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_PVA.TabIndex = 0;
            pictureBoxTask_PVA.TabStop = false;
            
            buttonAbout_PVA.Location = new Point(12, 273);
            buttonAbout_PVA.Name = "buttonAbout_PVA";
            buttonAbout_PVA.Size = new Size(117, 43);
            buttonAbout_PVA.TabIndex = 1;
            buttonAbout_PVA.Text = "Справка";
            buttonAbout_PVA.UseVisualStyleBackColor = true;
            buttonAbout_PVA.Click += buttonAbout_PVA_Click;
           
            buttonExecute_PVA.Location = new Point(135, 273);
            buttonExecute_PVA.Name = "buttonExecute_PVA";
            buttonExecute_PVA.Size = new Size(287, 43);
            buttonExecute_PVA.TabIndex = 2;
            buttonExecute_PVA.Text = "Выполнить";
            buttonExecute_PVA.UseVisualStyleBackColor = true;
            buttonExecute_PVA.Click += buttonExecute_PVA_Click;
            
            dataGridViewTask_PVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTask_PVA.Location = new Point(457, 67);
            dataGridViewTask_PVA.Name = "dataGridViewTask_PVA";
            dataGridViewTask_PVA.RowHeadersVisible = false;
            dataGridViewTask_PVA.Size = new Size(163, 163);
            dataGridViewTask_PVA.TabIndex = 3;
           
            groupBoxOutput_PVA.Controls.Add(dataGridViewResult_PVA);
            groupBoxOutput_PVA.Controls.Add(labelResult_PVA);
            groupBoxOutput_PVA.Location = new Point(657, 12);
            groupBoxOutput_PVA.Name = "groupBoxOutput_PVA";
            groupBoxOutput_PVA.Size = new Size(255, 304);
            groupBoxOutput_PVA.TabIndex = 1;
            groupBoxOutput_PVA.TabStop = false;
            groupBoxOutput_PVA.Text = "Вывод данных";
            
            dataGridViewResult_PVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PVA.Location = new Point(41, 55);
            dataGridViewResult_PVA.Name = "dataGridViewResult_PVA";
            dataGridViewResult_PVA.RowHeadersVisible = false;
            dataGridViewResult_PVA.Size = new Size(163, 163);
            dataGridViewResult_PVA.TabIndex = 4;
             
            labelResult_PVA.AutoSize = true;
            labelResult_PVA.Location = new Point(6, 22);
            labelResult_PVA.Name = "labelResult_PVA";
            labelResult_PVA.Size = new Size(63, 15);
            labelResult_PVA.TabIndex = 4;
            labelResult_PVA.Text = "Результат:";
            
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 328);
            Controls.Add(groupBoxOutput_PVA);
            Controls.Add(dataGridViewTask_PVA);
            Controls.Add(buttonExecute_PVA);
            Controls.Add(buttonAbout_PVA);
            Controls.Add(groupBoxTask_PVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 18 |  Парамонова В.А.";
            Load += FormMain_Load;
            groupBoxTask_PVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_PVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTask_PVA).EndInit();
            groupBoxOutput_PVA.ResumeLayout(false);
            groupBoxOutput_PVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PVA;
        private PictureBox pictureBoxTask_PVA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonAbout_PVA;
        private Button buttonExecute_PVA;
        private DataGridView dataGridViewTask_PVA;
        private GroupBox groupBoxOutput_PVA;
        private Label labelResult_PVA;
        private DataGridView dataGridViewResult_PVA;
    }
}