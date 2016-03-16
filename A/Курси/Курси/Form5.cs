using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курси
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F1 = new Form1();
            F1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F2 = new Form2();
            F2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form F3 = new Form3();
            F3.ShowDialog();
        }

        private void listOfStudyingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.listOfStudyingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.dataSet1.Students);
            // TODO: This line of code loads data into the 'dataSet1.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.dataSet1.Teachers);
            // TODO: This line of code loads data into the 'dataSet1.ListOfStudying' table. You can move, or remove it, as needed.
            this.listOfStudyingTableAdapter.Fill(this.dataSet1.ListOfStudying);

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.listOfStudyingTableAdapter.Search(this.dataSet1.ListOfStudying, idlistToolStripTextBox.Text, idCourseToolStripTextBox.Text, idStudentToolStripTextBox.Text, idTeacherToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form F4 = new Form4();
            F4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.listOfStudyingTableAdapter.Refresh(this.dataSet1.ListOfStudying);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
