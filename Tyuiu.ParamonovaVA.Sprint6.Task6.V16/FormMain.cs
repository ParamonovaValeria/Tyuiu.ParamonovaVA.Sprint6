using Tyuiu.ParamonovaVA.Sprint6.Task6.V16.Lib;


namespace Tyuiu.ParamonovaVA.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_SKE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SKE.ShowDialog();
            openFilePath = openFileDialogTask_SKE.FileName;
            textBoxInPut_SKE.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_SKE.Text = "¬вод данных: " + openFilePath;
            buttonDone_SKE.Enabled = true;
        }

        private void buttonDone_SKE_Click(object sender, EventArgs e)
        {
            textBoxOutPut_SKE.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonDone_SKE_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SKE.BackColor = Color.Green;
        }

        private void buttonDone_SKE_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SKE.BackColor = Color.LightGreen;
        }

        private void buttonInfo_SKE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}