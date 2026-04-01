using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PckStudio.Forms.Additional_Popups
{
    public partial class AddParameterPrompt : MetroFramework.Forms.MetroForm
    {
        public KeyValuePair<string, string> Parameter => new KeyValuePair<string, string>(keyTextBox.Text, valueTextBox.Text);

        public AddParameterPrompt(KeyValuePair<string, string> parameter)
            : this(parameter.Key, parameter.Value)
        {

        }

        public AddParameterPrompt(string name, string value)
        {
            InitializeComponent();
            keyTextBox.Text = name;
            valueTextBox.Text = value;
        }

        public AddParameterPrompt()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}