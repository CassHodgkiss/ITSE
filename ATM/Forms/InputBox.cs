using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class InputBox : Form
    {
        public InputBox(string title, string prompt)
        {
            InitializeComponent();
            Text = title;
            Prompt_L.Text = prompt;
        }

        private void Submit_B_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
