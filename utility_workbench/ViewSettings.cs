using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utility_workbench
{
    public partial class ViewSettings : Form
    {
        public ViewSettings()
        {
            InitializeComponent();

            BindingSource bindingSource1 = new BindingSource();
            bindingSource1.DataSource = Properties.Settings.Default;

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.DataSource = bindingSource1;

            //DataGridViewTextBoxColumn settingsNameCol = new DataGridViewTextBoxColumn();
            //settingsNameCol.HeaderText = "Settings Name";
            //settingsNameCol.Name = "settingsName";
            //settingsNameCol.DataPropertyName = "Name";
            //dataGridView1.Columns.Add(settingsNameCol);

            //DataGridViewTextBoxColumn settingsValueCol = new DataGridViewTextBoxColumn();
            //settingsValueCol.HeaderText = "Settings Value";
            //settingsValueCol.Name = "settingsValue";
            //settingsValueCol.DataPropertyName = "Value";
            //dataGridView1.Columns.Add(settingsValueCol);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.my.Default.Save();
        }
    }
}
