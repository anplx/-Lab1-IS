using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class FormQuestionOne : Form
    {
        FormQuestionTwo TwoQ;
        Model tempModel;
        public FormQuestionOne()
        {
            InitializeComponent();
        }

        public FormQuestionOne(Form1 Main,Model model)
        {
            InitializeComponent();
            tempModel = model;
        }
        private void button2_Click(object sender, EventArgs e) // Следующий вопрос
        {
            TwoQ = new FormQuestionTwo(this, tempModel);
            tempModel.GetOneQ(comboBox1.Text);
            TwoQ.Show();
            this.Hide();
        }
    }
}
