using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnplashTest_78_Hung
{
    public partial class NUnit_Test_78_Hung : Form
    {
        public NUnit_Test_78_Hung()
        {
            InitializeComponent();
        }

        private void DCH_78_Calcu_Btn_Click(object sender, EventArgs e)
        {
            double DCH_78_a = double.Parse(DCH_78_A_text.Text); 
            double DCH_78_b = double.Parse(DCH_78_B_text.Text); 
            double DCH_78_c = double.Parse(DCH_78_C_text.Text);

            Quadratic_78_Hung DCH_78_quadratic = new Quadratic_78_Hung(DCH_78_a, DCH_78_b, DCH_78_c);
            DCH_78_richText.Text = DCH_78_quadratic.Solve_78_Hung();

        }
    }
}
