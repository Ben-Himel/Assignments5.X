using System.CodeDom.Compiler;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Assignment5._3winforms
{
    public partial class FormLrnMgmnt : Form
    {
        private Label labelStuID;
        private Label labelStuName;
        private Label labelGPA;
        private TextBox textBoxStuID;
        private TextBox textBoxStuName;
        private TextBox textBoxGPA;
        private Label labelSave;
        private Button buttonInputStu;
        private Button buttonSave;
        private Button buttonDelete;
        private Label label1;
        public ArrayList students;
        public FormLrnMgmnt()
        {
            InitializeComponent();
            students = new ArrayList();
            
        }



        private void InitializeComponent()
        {
            this.labelStuID = new System.Windows.Forms.Label();
            this.labelStuName = new System.Windows.Forms.Label();
            this.labelGPA = new System.Windows.Forms.Label();
            this.textBoxStuID = new System.Windows.Forms.TextBox();
            this.textBoxStuName = new System.Windows.Forms.TextBox();
            this.textBoxGPA = new System.Windows.Forms.TextBox();
            this.labelSave = new System.Windows.Forms.Label();
            this.buttonInputStu = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStuID
            // 
            this.labelStuID.AutoSize = true;
            this.labelStuID.Location = new System.Drawing.Point(8, 20);
            this.labelStuID.Name = "labelStuID";
            this.labelStuID.Size = new System.Drawing.Size(62, 15);
            this.labelStuID.TabIndex = 0;
            this.labelStuID.Text = "Student ID";
            // 
            // labelStuName
            // 
            this.labelStuName.AutoSize = true;
            this.labelStuName.Location = new System.Drawing.Point(8, 49);
            this.labelStuName.Name = "labelStuName";
            this.labelStuName.Size = new System.Drawing.Size(83, 15);
            this.labelStuName.TabIndex = 1;
            this.labelStuName.Text = "Student Name";
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Location = new System.Drawing.Point(8, 78);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(29, 15);
            this.labelGPA.TabIndex = 2;
            this.labelGPA.Text = "GPA";
            // 
            // textBoxStuID
            // 
            this.textBoxStuID.Location = new System.Drawing.Point(97, 12);
            this.textBoxStuID.Name = "textBoxStuID";
            this.textBoxStuID.Size = new System.Drawing.Size(100, 23);
            this.textBoxStuID.TabIndex = 3;
            // 
            // textBoxStuName
            // 
            this.textBoxStuName.Location = new System.Drawing.Point(97, 41);
            this.textBoxStuName.Name = "textBoxStuName";
            this.textBoxStuName.Size = new System.Drawing.Size(100, 23);
            this.textBoxStuName.TabIndex = 4;
            // 
            // textBoxGPA
            // 
            this.textBoxGPA.Location = new System.Drawing.Point(97, 70);
            this.textBoxGPA.Name = "textBoxGPA";
            this.textBoxGPA.Size = new System.Drawing.Size(100, 23);
            this.textBoxGPA.TabIndex = 5;
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.Location = new System.Drawing.Point(170, 143);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(103, 30);
            this.labelSave.TabIndex = 6;
            this.labelSave.Text = "Save student with \r\nhighest GPA";
            // 
            // buttonInputStu
            // 
            this.buttonInputStu.Location = new System.Drawing.Point(8, 117);
            this.buttonInputStu.Name = "buttonInputStu";
            this.buttonInputStu.Size = new System.Drawing.Size(75, 23);
            this.buttonInputStu.TabIndex = 7;
            this.buttonInputStu.Text = "New Student";
            this.buttonInputStu.UseVisualStyleBackColor = true;
            this.buttonInputStu.Click += new System.EventHandler(this.buttonInputStu_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(170, 117);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save Best";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(89, 117);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Delete last\r\nStudent";
            // 
            // FormLrnMgmnt
            // 
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonInputStu);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.textBoxGPA);
            this.Controls.Add(this.textBoxStuName);
            this.Controls.Add(this.textBoxStuID);
            this.Controls.Add(this.labelGPA);
            this.Controls.Add(this.labelStuName);
            this.Controls.Add(this.labelStuID);
            this.Name = "FormLrnMgmnt";
            this.Text = "Learning Managment";
            this.Load += new System.EventHandler(this.FormLrnMgmnt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonInputStu_Click(object sender, EventArgs e)
        {

            try
            {                
                Student stu = new Student(Convert.ToInt32(textBoxStuID.Text.Trim()),
                        textBoxStuName.Text.Trim(), Convert.ToDouble(textBoxGPA.Text.Trim()));
                students.Add(stu);
                //stu.ID = textBoxStuID.Text.ToString();
                students.TrimToSize(); 
                MessageBox.Show($"Student {stu.ID} " +  //TODO chante Stu.ID to a refernace pull from array list
                    $"has been added to Students list.", "Student Added", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine(ex.ToString());
                //throw;
            }
            finally
            {
                textBoxGPA.Clear();
                textBoxStuID.Clear();
                textBoxStuName.Clear();
            }
            
        }

        private void FormLrnMgmnt_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e) //TODO test this block of code
        {
            Student bestStu = (Student)students[0];
            for(int i = 0; i < students.Count; i++)
            {
                Student stu = (Student)students[i];
                if(stu.GPA > bestStu.GPA)
                    bestStu = stu;
            }

            StreamWriter writer = new StreamWriter("BestGPA.txt");
            writer.WriteLine($"{bestStu.ID.ToString()}\n" +
                $"{bestStu.Name.ToString()}\n" +
                $"{bestStu.GPA.ToString()}");
            writer.Close();

            MessageBox.Show("Best Student Saved to \"BestGPA.txt\"","Student Saved",MessageBoxButtons.OK);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (students.Count > 0)
            {
                students.RemoveAt(students.Count - 1);
                MessageBox.Show("Last student Entered\ndeleted from Student List", "Student Deleted", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("No students to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //TODO Delete Student
    }
}