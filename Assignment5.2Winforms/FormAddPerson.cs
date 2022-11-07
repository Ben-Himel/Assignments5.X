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
    public partial class FormAddPerson : Form
    {
        
        public FormAddPerson()
        {
            InitializeComponent();
        }
        //Dictionary<string, Person> blackBook = new Dictionary<string, Person>();

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if(textBoxAddresss == null || textBoxFirstName == null || textBoxLastName == null 
                || textBoxMobile == null || textBoxWork == null)
            {
                MessageBox.Show("Ensure All fields have values", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Person person = new Person(textBoxFirstName.Text, textBoxLastName.Text,
                    Convert.ToInt32(textBoxMobile.Text), Convert.ToInt32(textBoxWork.Text),
                    textBoxAddresss.Text);
                FormStart.instance.blackBook.Add(person.FirstName, person);

                FormStart.instance.dataGridBB.Rows.Add(person.FirstName, person.LastName,
                    person.MobilePhone, person.WorkPhone, person.Address);
            }
            


        }
    }
}
