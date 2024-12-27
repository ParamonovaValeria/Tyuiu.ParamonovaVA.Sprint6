using Tyuiu.ParamonovaVA.Sprint6.Task4.V9.Lib;

namespace Tyuiu.ParamonovaVA.Sprint6.Task4.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_PVA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_PVA.Text);

                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);
                chart_PVA.ChartAreas[0].AxisX.Title = "X";
                chart_PVA.ChartAreas[0].AxisY.Title = "Y";
                textBoxResult_PVA.Text = "";
                for (int i = 0; i < valueArray.Length; i++)
                {
                    chart_PVA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_PVA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы РППб-24-1 Парамонова Валерия Алексеевна", "", MessageBoxButtons.OK);
        }
        private void buttonSave_Click(Object sender, EventArgs e)
        {
            try
            {
                string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
                string path = Path.Combine(paths);
                File.WriteAllText(path, textBoxResult_PVA.Text);
                DialogResult dialogResult = MessageBox.Show("" + path + " \n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
