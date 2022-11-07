using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5._2Winforms
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if(FormStart.instance.blackBook[textBoxSerch.Text] != null)
            {
                Person searchPerson = FormStart.instance.blackBook[textBoxSerch.Text];
                MessageBox.Show($"Name: {searchPerson.FirstName} {searchPerson.LastName}" +
                    $"\n Cell: {searchPerson.MobilePhone} Work: {searchPerson.WorkPhone}" +
                    $"\n Address: {searchPerson.Address}", $"Search for \"{searchPerson.FirstName}");

            }

        }
    }
}
