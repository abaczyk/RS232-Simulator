using System;
using System.Windows.Forms;

namespace Projekt_4
{
    public partial class ReceiverForm : Form
    {
        public ReceiverForm()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            ASCIITextBox.Text = obscenitiesHandler.changeStringToAsterisks(converter.binaryToASCII(binaryTextBox.Text));
        }
    }
}
