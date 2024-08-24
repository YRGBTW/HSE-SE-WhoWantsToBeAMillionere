using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;



namespace WhoWantsToBeAMillionere_lab03
{

    public partial class Welcome : Form
    {
        string connectionString = "Data Source = \"C:\\Users\\PCevd\\WWTBM_lab03.db\";Version=3;";
        bool[] selectedTips = new bool[5];
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            ;
        }
        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }
        private void OkW_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 1)
            {
                MessageBox.Show("Введено пустое имя!");
            }
            else if (checkedListBox1.SelectedItems.Count == 0)
            {

                MessageBox.Show($"Вы должны выбрать несгораемую сумму.", "Лимит выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (checkedListBox2.CheckedItems.Count < 3)
            {
                MessageBox.Show($"Вы должны выбрать 3 подсказки.", "Лимит выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (int elem in checkedListBox2.CheckedIndices)
                {
                    selectedTips[elem] = true;
                }
                var frm = new Form1(selectedTips, textBox1.Text, checkedListBox1.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;

                frm.ShowDialog();
            }
        }

        private void declineW_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedCount = checkedListBox2.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
            {
                if (selectedCount >= 3)
                {
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show($"Вы можете выбрать максимум {3} элементов.", "Лимит выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int selectedCount = checkedListBox1.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
            {
                if (selectedCount >= 1)
                {
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show($"Вы можете выбрать максимум {1} элемент.", "Лимит выбора", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void topUsers_Click(object sender, EventArgs e)
        {
            Form1.ShowLeaderBoard();
        }


    }
}
