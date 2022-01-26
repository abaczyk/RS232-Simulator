using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_4
{
    public partial class TransmitterForm : Form
    {
        public TransmitterForm()
        {
            InitializeComponent();
            receiver.Show();
        }

        private void convertToBinaryButton_Click(object sender, EventArgs e)
        {
            binaryTextBox.Text = converter.ASCIIToBinary(ASCIItextBox.Text).ToString();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            receiver.binaryTextBox.Text = binaryTextBox.Text;
        }
    }
}
