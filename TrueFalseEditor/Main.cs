using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Main : Form
    {
        TrueFalseEngine engine;

        public Main()
        {
            InitializeComponent();
        }

        private void BottonNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Add("Замля круглая?", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void BottonSave_Click(object sender, EventArgs e)
        {
            engine.Save();
        }

        private void BottonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = engine.Count;
                nudNumber.Value = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            engine.Add($"#{engine.Count + 1}", true);
            nudNumber.Maximum = engine.Count;
            nudNumber.Value = engine.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            engine.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum--;
            nudNumber.Value--;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            engine[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
            engine[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbQuestion.Text = engine[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = engine[(int)nudNumber.Value - 1].TrueFalse;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Данный вопрос отсутствует");
            }
        }
        private void BottonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void about_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Автор: Алексей Самохвалов\nВсе права защищены\nВерсия 1.0", "О программе");
            }
        }

        private void imSaveAs_Click_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                return;
            if (engine == null)
            {
                engine = new TrueFalseEngine(dlg.FileName);
                engine.Add("123", true);
                engine.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                MessageBox.Show("Файл сохранен"); ;
            }
        }

    }
}
