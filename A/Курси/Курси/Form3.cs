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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void coursesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coursesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.dataSet1.Courses);

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.coursesTableAdapter.search(this.dataSet1.Courses, idCourseToolStripTextBox.Text, idTeacherToolStripTextBox.Text, предметToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void refreshToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.coursesTableAdapter.Refresh(this.dataSet1.Courses);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F1 = new Form1();
            F1.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form F2 = new Form2();
            F2.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
