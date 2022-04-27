using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormConfirmacion : Form
    {
        private int option;
        public FormConfirmacion()
        {
            InitializeComponent();
        }
        public int Option { get => option; set => option = value; }

        public FormConfirmacion(string title, string message, string buttonText1, string buttonText2, string buttonText3)
        {
            InitializeComponent();
            Text = title;
            labelConfirmacion.Text = message;
            buttonConfirmacion1.Text = buttonText1;
            buttonConfirmacion2.Text = buttonText2;
            buttonConfirmacion3.Text = buttonText3;
        }
       
        private void buttonConfirmacion1_Click(object sender, EventArgs e)
        {
            Option = 1;
            this.Close();
        }

        private void buttonConfirmacion2_Click(object sender, EventArgs e)
        {
            Option = 2;
            this.Close();
        }

        private void buttonConfirmacion3_Click(object sender, EventArgs e)
        {
            Option = 3;
            this.Close();
        }
    }
}
