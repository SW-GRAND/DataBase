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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void teachersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teachersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.dataSet1.Teachers);

        }

        private void searchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teachersTableAdapter.search(this.dataSet1.Teachers, idTeacherToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void serchToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.teachersTableAdapter.Serch(this.dataSet1.Teachers, idTeacherToolStripTextBox.Text, парольToolStripTextBox.Text);
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
                this.teachersTableAdapter.Refresh(this.dataSet1.Teachers);
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
            Form F3 = new Form3();
            F3.ShowDialog();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
