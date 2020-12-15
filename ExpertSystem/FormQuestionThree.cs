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
    public partial class FormQuestionThree : Form
    {
        Model tempModel;
        FormResult FResult;
        public FormQuestionThree()
        {
            InitializeComponent();
        }

        public FormQuestionThree(FormQuestionTwo TwoQ,Model model)
        {
            InitializeComponent();
            tempModel = model;
        }
        private void button2_Click(object sender, EventArgs e) // Показать результат
        {
            tempModel.GetThreeQ(comboBox1.Text);
            FResult = new FormResult(tempModel);
            FResult.Show();
            this.Hide();
        }
    }
}
