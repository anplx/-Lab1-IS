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
    public partial class FormQuestionTwo : Form
    {
        FormQuestionThree ThreeQ;
        Model tempModel;
        public FormQuestionTwo()
        {
            InitializeComponent();
        }

        public FormQuestionTwo(FormQuestionOne OneQ,Model model)
        {
            InitializeComponent();
            tempModel = model;
        }
        private void button2_Click(object sender, EventArgs e) //Следующий вопрос
        {
            ThreeQ = new FormQuestionThree(this, tempModel);
            tempModel.GetTwoQ(numericUpDown1.Value);
            ThreeQ.Show();
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }
    }
}
