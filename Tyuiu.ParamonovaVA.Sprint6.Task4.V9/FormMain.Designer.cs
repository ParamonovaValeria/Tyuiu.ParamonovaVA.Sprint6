namespace Tyuiu.ParamonovaVA.Sprint6.Task4.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            chart_PVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            buttonSave_PVA = new Button();
            buttonHelp_PVA = new Button();
            groupBoxInput_PVA = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBoxStopStep_PVA = new TextBox();
            textBoxStartStep_PVA = new TextBox();
            groupBoxTask_PVA = new GroupBox();
            textBoxTask_PVA = new TextBox();
            buttonDone_PVA = new Button();
            panel2 = new Panel();
            groupBoxOutPut_PVA = new GroupBox();
            textBoxResult_PVA = new TextBox();
            panel3 = new Panel();
            splitter1 = new Splitter();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart_PVA).BeginInit();
            panel1.SuspendLayout();
            groupBoxInput_PVA.SuspendLayout();
            groupBoxTask_PVA.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutPut_PVA.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            
            chartArea1.Name = "ChartArea1";
            chart_PVA.ChartAreas.Add(chartArea1);
            chart_PVA.Location = new Point(9, 11);
            chart_PVA.Name = "chart_SBI";
            chart_PVA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chart_PVA.Series.Add(series1);
            chart_PVA.Size = new Size(710, 295);
            chart_PVA.TabIndex = 0;
            chart_PVA.Text = "chart1";
            chart_PVA.UseWaitCursor = true;
            
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonSave_PVA);
            panel1.Controls.Add(buttonHelp_PVA);
            panel1.Controls.Add(groupBoxInput_PVA);
            panel1.Controls.Add(groupBoxTask_PVA);
            panel1.Controls.Add(buttonDone_PVA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 100);
            panel1.TabIndex = 1;
                        buttonSave_PVA.BackColor = SystemColors.HotTrack;
            buttonSave_PVA.Location = new Point(770, 12);
            buttonSave_PVA.Name = "buttonSave_PVA";
            buttonSave_PVA.Size = new Size(81, 82);
            buttonSave_PVA.TabIndex = 11;
            buttonSave_PVA.Text = "Сохранить";
            buttonSave_PVA.UseVisualStyleBackColor = false;
            buttonSave_PVA.Click += buttonSave_Click;
          
            buttonHelp_PVA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_PVA.Location = new Point(857, 12);
            buttonHelp_PVA.Name = "buttonHelp_PVA";
            buttonHelp_PVA.Size = new Size(66, 82);
            buttonHelp_PVA.TabIndex = 10;
            buttonHelp_PVA.Text = "Справка";
            buttonHelp_PVA.UseVisualStyleBackColor = false;
            buttonHelp_PVA.Click += buttonHelp_Click;
            
            groupBoxInput_PVA.Controls.Add(label2);
            groupBoxInput_PVA.Controls.Add(label3);
            groupBoxInput_PVA.Controls.Add(textBoxStopStep_PVA);
            groupBoxInput_PVA.Controls.Add(textBoxStartStep_PVA);
            groupBoxInput_PVA.Location = new Point(370, 3);
            groupBoxInput_PVA.Name = "groupBoxInput_PVA";
            groupBoxInput_PVA.Size = new Size(287, 91);
            groupBoxInput_PVA.TabIndex = 1;
            groupBoxInput_PVA.TabStop = false;
            groupBoxInput_PVA.Text = "Ввод данных";
            
            label2.AutoSize = true;
            label2.Location = new Point(142, 25);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 13;
            label2.Text = "Конец шага:";
             
            label3.AutoSize = true;
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 11;
            label3.Text = "Старт шага:";
            
            textBoxStopStep_PVA.Location = new Point(146, 43);
            textBoxStopStep_PVA.Name = "textBoxStopStep_PVA";
            textBoxStopStep_PVA.Size = new Size(128, 23);
            textBoxStopStep_PVA.TabIndex = 12;
            
            textBoxStartStep_PVA.Location = new Point(12, 43);
            textBoxStartStep_PVA.Name = "textBoxStartStep_PVA";
            textBoxStartStep_PVA.Size = new Size(128, 23);
            textBoxStartStep_PVA.TabIndex = 10;
            
            groupBoxTask_PVA.Controls.Add(textBoxTask_PVA);
            groupBoxTask_PVA.Location = new Point(3, 3);
            groupBoxTask_PVA.Name = "groupBoxTask_PVA";
            groupBoxTask_PVA.Padding = new Padding(5);
            groupBoxTask_PVA.Size = new Size(361, 91);
            groupBoxTask_PVA.TabIndex = 0;
            groupBoxTask_PVA.TabStop = false;
            groupBoxTask_PVA.Text = "Условие:";
            
            textBoxTask_PVA.BackColor = Color.White;
            textBoxTask_PVA.BorderStyle = BorderStyle.None;
            textBoxTask_PVA.Dock = DockStyle.Fill;
            textBoxTask_PVA.Location = new Point(5, 21);
            textBoxTask_PVA.Multiline = true;
            textBoxTask_PVA.Name = "textBoxTask_PVA";
            textBoxTask_PVA.ReadOnly = true;
            textBoxTask_PVA.Size = new Size(351, 65);
            textBoxTask_PVA.TabIndex = 0;
            textBoxTask_PVA.Text = resources.GetString("textBoxTask_PVA.Text");
            
            buttonDone_PVA.BackColor = Color.Green;
            buttonDone_PVA.Location = new Point(663, 12);
            buttonDone_PVA.Name = "buttonDone_PVA";
            buttonDone_PVA.Size = new Size(101, 82);
            buttonDone_PVA.TabIndex = 9;
            buttonDone_PVA.Text = "Выполнить";
            buttonDone_PVA.UseVisualStyleBackColor = false;
            buttonDone_PVA.Click += buttonDone_Click;
             
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(groupBoxOutPut_PVA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 311);
            panel2.TabIndex = 2;
        
            groupBoxOutPut_PVA.BackColor = Color.White;
            groupBoxOutPut_PVA.Controls.Add(textBoxResult_PVA);
            groupBoxOutPut_PVA.Dock = DockStyle.Fill;
            groupBoxOutPut_PVA.Location = new Point(0, 0);
            groupBoxOutPut_PVA.Name = "groupBoxOutPut_PVA";
            groupBoxOutPut_PVA.Padding = new Padding(5);
            groupBoxOutPut_PVA.Size = new Size(200, 311);
            groupBoxOutPut_PVA.TabIndex = 0;
            groupBoxOutPut_PVA.TabStop = false;
            groupBoxOutPut_PVA.Text = "Вывод:";
            
            textBoxResult_PVA.BackColor = Color.White;
            textBoxResult_PVA.BorderStyle = BorderStyle.None;
            textBoxResult_PVA.Dock = DockStyle.Fill;
            textBoxResult_PVA.Location = new Point(5, 21);
            textBoxResult_PVA.Multiline = true;
            textBoxResult_PVA.Name = "textBoxResult_PVA";
            textBoxResult_PVA.ReadOnly = true;
            textBoxResult_PVA.Size = new Size(190, 285);
            textBoxResult_PVA.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(chart_PVA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(731, 311);
            panel3.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 311);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(224, 3);
            label1.Name = "label1";
            label1.Size = new Size(329, 25);
            label1.TabIndex = 2;
            label1.Text = "Функция 2x-3/(cos(x)-2x) + 5x - sin(x)";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 9 | Парамонова В.А. ";
            ((System.ComponentModel.ISupportInitialize)chart_PVA).EndInit();
            panel1.ResumeLayout(false);
            groupBoxInput_PVA.ResumeLayout(false);
            groupBoxInput_PVA.PerformLayout();
            groupBoxTask_PVA.ResumeLayout(false);
            groupBoxTask_PVA.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutPut_PVA.ResumeLayout(false);
            groupBoxOutPut_PVA.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_PVA;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask_PVA;
        private GroupBox groupBoxOutPut_PVA;
        private TextBox textBoxResult_PVA;
        private GroupBox groupBoxInput_PVA;
        private TextBox textBoxTask_PVA;
        private Label label2;
        private Label label3;
        private TextBox textBoxStopStep_PVA;
        private TextBox textBoxStartStep_PVA;
        private Button buttonHelp_PVA;
        private Button buttonDone_PVA;
        private Button buttonSave_PVA;
        private Label label1;
    }
}