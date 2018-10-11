using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers {
	public partial class InitialForm : Form {
		public InitialForm() {
			InitializeComponent();
		}

        private bool checkName(string name)
        {
            if (name == "")
            {
                label2.Text = "Empty player name field.";
                return false;
            }
            label2.Text = "";
            return true;
        }

        private void OpenNewForm(Form form)
        {
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form));
            }

            if (checkName(textBox1.Text))
            {
                Singleton.Instance.name = textBox1.Text;
                this.Hide();
                var form2 = form;
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            OpenNewForm(new CreateServerForm());
        }

		private void button2_Click(object sender, EventArgs e) {
            OpenNewForm(new JoinServerForm());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
