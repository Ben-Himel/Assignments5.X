using System;

namespace Assignment5._2Winforms
{
    public partial class FormStart : Form
    {
        public static FormStart instance;
        internal Dictionary<string, Person> blackBook = new Dictionary<string, Person>(); // INTERNAL KEY WORD !!!!!!!
        public DataGridView dataGridBB;

        public FormStart()
        {
            InitializeComponent();  
            instance = this;
            //BlackBook = _blackBook;
            dataGridBB = dataGridBlackBookview;

        }

        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridBlackBookview.Rows.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            blackBook.Clear();
            foreach(Person person in blackBook.Values)
            {
                dataGridBlackBookview.Rows.Add(person.FirstName, person.LastName, 
                    person.MobilePhone, person.WorkPhone,
                    person.Address);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch search = new FormSearch();
            search.ShowDialog();
            //MessageBox.Show("Enter Last Name", "Search");
            //Form searchForm = new Form();
            //searchForm.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddPerson addPerson = new FormAddPerson();
            addPerson.ShowDialog();
        }
    }
}