using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class FormReplace : Form
    {
        public delegate void TextReplacedEventHandler(string searchText, string replaceText);

        public event TextReplacedEventHandler TextReplaced;

        private readonly Form1 _mainForm;

        public FormReplace(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; 
        }
       
        private void buttonReplace_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = textBoxSearch.Text;
                string replaceText = textBoxReplace.Text;

                if (string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Поле поиска не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TextReplaced?.Invoke(searchText, replaceText); 

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при замене текста: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
