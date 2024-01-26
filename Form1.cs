using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.C__Assessment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string newText = txtBoxWORD.Text.Trim();
            if (!string.IsNullOrEmpty(newText))
            {
                listBox1.Items.Add(newText);
                listBox1.Update();
                txtBoxWORD.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a word or phrase.");
            }
        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            // Iterate through the selected items and remove them from the ListBox
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int selectedIndex = listBox1.SelectedIndices[i];
                listBox1.Items.RemoveAt(selectedIndex);
            }
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCHANGE_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (listBox1.SelectedItem != null)
            {
                // Get the index of the selected item
                int selectedIndex = listBox1.SelectedIndex;

                // Get the new word from the TextBox
                string newWord = txtBoxWORD.Text.Trim();

                // Check if the new word is not empty
                if (!string.IsNullOrEmpty(newWord))
                {
                    // Replace the selected item with the new word
                    listBox1.Items[selectedIndex] = newWord;
                    listBox1.Update();
                    txtBoxWORD.Clear();
                }
                else
                {
                    MessageBox.Show("Please enter a new word.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a word to change.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
