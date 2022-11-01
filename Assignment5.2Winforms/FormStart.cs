namespace Assignment5._2Winforms
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            


        }

        Dictionary<string, Person> blackBook = new Dictionary<string, Person>();

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridBlackBookview.Rows.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
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

        //public static DialogResult InputBox(string title, string promptText, ref string value)
        //{
        //    Form searchForm = new Form();
        //    Label label = new Label();
        //    TextBox textBox = new TextBox();
        //    Button buttonOk = new Button();
        //    Button buttonCancel = new Button();

        //    searchForm.Text = title;
        //    label.Text = promptText;

        //    buttonOk.Text = "OK";
        //    buttonCancel.Text = "Cancel";
        //    buttonOk.DialogResult = DialogResult.OK;
        //    buttonCancel.DialogResult = DialogResult.Cancel;




        //}
    }
}