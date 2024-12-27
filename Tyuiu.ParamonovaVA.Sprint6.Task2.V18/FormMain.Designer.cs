using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.ParamonovaVA.Sprint6.Task2.V18
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_PVA = new GroupBox();
            pictureBoxTask_PVA = new PictureBox();
            groupBoxOutput_PVA = new GroupBox();
            chartFunction_PVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelResult_PVA = new Label();
            dataGridViewFunction_PVA = new DataGridView();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFx = new DataGridViewTextBoxColumn();
            groupBoxInput_PVA = new GroupBox();
            labelStop_PVA = new Label();
            textBoxStop_PVA = new TextBox();
            textBoxStart_PVA = new TextBox();
            labelStart_PVA = new Label();
            buttonRun_PVA = new Button();
            buttonInfo_PVA = new Button();
            groupBoxTask_PVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_PVA).BeginInit();
            groupBoxOutput_PVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_PVA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_PVA).BeginInit();
            groupBoxInput_PVA.SuspendLayout();
            SuspendLayout();
            
            groupBoxTask_PVA.Controls.Add(pictureBoxTask_PVA);
            groupBoxTask_PVA.Location = new Point(12, 12);
            groupBoxTask_PVA.Name = "groupBoxTask_PVA";
            groupBoxTask_PVA.Size = new Size(543, 393);
            groupBoxTask_PVA.TabIndex = 0;
            groupBoxTask_PVA.TabStop = false;
            groupBoxTask_PVA.Text = "Условие";
            
            pictureBoxTask_PVA.BackgroundImage = (Image)resources.GetObject("pictureBoxTask_PVA.BackgroundImage");
            pictureBoxTask_PVA.Image = (Image)resources.GetObject("pictureBoxTask_PVA.Image");
            pictureBoxTask_PVA.Location = new Point(6, 26);
            pictureBoxTask_PVA.Name = "pictureBoxTask_PVA";
            pictureBoxTask_PVA.Size = new Size(531, 238);
            pictureBoxTask_PVA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_PVA.TabIndex = 0;
            pictureBoxTask_PVA.TabStop = false;
           
            groupBoxOutput_PVA.Controls.Add(chartFunction_PVA);
            groupBoxOutput_PVA.Controls.Add(labelResult_PVA);
            groupBoxOutput_PVA.Controls.Add(dataGridViewFunction_PVA);
            groupBoxOutput_PVA.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxOutput_PVA.Location = new Point(561, 12);
            groupBoxOutput_PVA.Name = "groupBoxOutput_PVA";
            groupBoxOutput_PVA.Size = new Size(731, 492);
            groupBoxOutput_PVA.TabIndex = 1;
            groupBoxOutput_PVA.TabStop = false;
            groupBoxOutput_PVA.Text = "Вывод данных";
            
            chartArea2.Name = "ChartArea1";
            chartFunction_PVA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunction_PVA.Legends.Add(legend2);
            chartFunction_PVA.Location = new Point(218, 60);
            chartFunction_PVA.Name = "chartFunction_PVA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_PVA.Series.Add(series2);
            chartFunction_PVA.Size = new Size(470, 412);
            chartFunction_PVA.TabIndex = 2;
            chartFunction_PVA.Text = "chart1";
            
            labelResult_PVA.AutoSize = true;
            labelResult_PVA.Location = new Point(6, 26);
            labelResult_PVA.Name = "labelResult_PVA";
            labelResult_PVA.Size = new Size(99, 20);
            labelResult_PVA.TabIndex = 1;
            labelResult_PVA.Text = "Результат:";
            
            dataGridViewFunction_PVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_PVA.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFx });
            dataGridViewFunction_PVA.Location = new Point(6, 49);
            dataGridViewFunction_PVA.Name = "dataGridViewFunction_PVA";
            dataGridViewFunction_PVA.ReadOnly = true;
            dataGridViewFunction_PVA.RowHeadersVisible = false;
            dataGridViewFunction_PVA.RowHeadersWidth = 51;
            dataGridViewFunction_PVA.Size = new Size(180, 437);
            dataGridViewFunction_PVA.TabIndex = 0;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "X";
            ColumnX.MinimumWidth = 6;
            ColumnX.Name = "ColumnX";
            ColumnX.ReadOnly = true;
            ColumnX.Width = 90;
            // 
            // ColumnFx
            // 
            ColumnFx.HeaderText = "F(X)";
            ColumnFx.MinimumWidth = 6;
            ColumnFx.Name = "ColumnFx";
            ColumnFx.ReadOnly = true;
            ColumnFx.Width = 90;
            
            groupBoxInput_PVA.Controls.Add(labelStop_PVA);
            groupBoxInput_PVA.Controls.Add(textBoxStop_PVA);
            groupBoxInput_PVA.Controls.Add(textBoxStart_PVA);
            groupBoxInput_PVA.Controls.Add(labelStart_PVA);
            groupBoxInput_PVA.Location = new Point(12, 411);
            groupBoxInput_PVA.Name = "groupBoxInput_PVA";
            groupBoxInput_PVA.Size = new Size(287, 93);
            groupBoxInput_PVA.TabIndex = 2;
            groupBoxInput_PVA.TabStop = false;
            groupBoxInput_PVA.Text = "Ввод данных";
            
            labelStop_PVA.AutoSize = true;
            labelStop_PVA.Location = new Point(147, 23);
            labelStop_PVA.Name = "labelStop_PVA";
            labelStop_PVA.Size = new Size(94, 20);
            labelStop_PVA.TabIndex = 1;
            labelStop_PVA.Text = "Конец шага:";
            
            textBoxStop_PVA.Location = new Point(147, 46);
            textBoxStop_PVA.Name = "textBoxStop_PVA";
            textBoxStop_PVA.Size = new Size(134, 27);
            textBoxStop_PVA.TabIndex = 2;
            textBoxStop_PVA.Text = "5";
             
            textBoxStart_PVA.Location = new Point(6, 46);
            textBoxStart_PVA.Name = "textBoxStart_PVA";
            textBoxStart_PVA.Size = new Size(135, 27);
            textBoxStart_PVA.TabIndex = 3;
            textBoxStart_PVA.Text = "-5";
            textBoxStart_PVA.KeyPress += textBoxStart_PVA_TextChanged;
             
            labelStart_PVA.AutoSize = true;
            labelStart_PVA.Location = new Point(6, 23);
            labelStart_PVA.Name = "labelStart_PVA";
            labelStart_PVA.Size = new Size(88, 20);
            labelStart_PVA.TabIndex = 0;
            labelStart_PVA.Text = "Старт шага:";
             
            buttonRun_PVA.BackColor = Color.Green;
            buttonRun_PVA.Location = new Point(405, 426);
            buttonRun_PVA.Name = "buttonRun_PVA";
            buttonRun_PVA.Size = new Size(150, 78);
            buttonRun_PVA.TabIndex = 3;
            buttonRun_PVA.Text = "Выполнить";
            buttonRun_PVA.UseVisualStyleBackColor = false;
            buttonRun_PVA.Click += buttonRun_PVA_Click;
            buttonRun_PVA.MouseDown += buttonRun_MouseDown;
            buttonRun_PVA.MouseEnter += buttonRun_MouseEnter;
            buttonRun_PVA.MouseLeave += buttonRun_MouseLeave;
             
            buttonInfo_PVA.BackColor = Color.Blue;
            buttonInfo_PVA.Location = new Point(305, 426);
            buttonInfo_PVA.Name = "buttonInfo_PVA";
            buttonInfo_PVA.Size = new Size(94, 78);
            buttonInfo_PVA.TabIndex = 4;
            buttonInfo_PVA.Text = "Справка";
            buttonInfo_PVA.UseVisualStyleBackColor = false;
            buttonInfo_PVA.Click += buttonInfo_PVA_Click;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1302, 516);
            Controls.Add(buttonInfo_PVA);
            Controls.Add(buttonRun_PVA);
            Controls.Add(groupBoxInput_PVA);
            Controls.Add(groupBoxOutput_PVA);
            Controls.Add(groupBoxTask_PVA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 18 | Парамонова В.А";
            groupBoxTask_PVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_PVA).EndInit();
            groupBoxOutput_PVA.ResumeLayout(false);
            groupBoxOutput_PVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_PVA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_PVA).EndInit();
            groupBoxInput_PVA.ResumeLayout(false);
            groupBoxInput_PVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_PVA;
        private PictureBox pictureBoxTask_PVA;
        private GroupBox groupBoxOutput_PVA;
        private GroupBox groupBoxInput_PVA;
        private Button buttonRun_PVA;
        private Button buttonInfo_PVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PVA;
        private Label labelResult_PVA;
        private DataGridView dataGridViewFunction_PVA;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFx;
        private Label labelStop_PVA;
        private TextBox textBoxStop_PVA;
        private TextBox textBoxStart_PVA;
        private Label labelStart_PVA;
    }
}