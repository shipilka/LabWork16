namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            try
            {
                FormReplace formReplace = new FormReplace(this);

                formReplace.TextReplaced += FormReplace_TextReplaced;

                formReplace.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� �������� ����� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormReplace_TextReplaced(string searchText, string replaceText)
        {
            try
            {
                textBox1.Text = textBox1.Text.Replace(searchText, replaceText);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"������ ��� ������ ������ (ArgumentNullException): {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������ ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
