namespace Task5
{
    partial class FormReplace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxSearch = new TextBox();
            label2 = new Label();
            textBoxReplace = new TextBox();
            buttonReplace = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Текст для поиска";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(12, 42);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(776, 69);
            textBoxSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 123);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Текст для замены";
            // 
            // textBoxReplace
            // 
            textBoxReplace.Location = new Point(16, 165);
            textBoxReplace.Multiline = true;
            textBoxReplace.Name = "textBoxReplace";
            textBoxReplace.Size = new Size(772, 79);
            textBoxReplace.TabIndex = 3;
            // 
            // buttonReplace
            // 
            buttonReplace.Dock = DockStyle.Bottom;
            buttonReplace.Location = new Point(0, 421);
            buttonReplace.Name = "buttonReplace";
            buttonReplace.Size = new Size(800, 29);
            buttonReplace.TabIndex = 4;
            buttonReplace.Text = "Заменить";
            buttonReplace.UseVisualStyleBackColor = true;
            buttonReplace.Click += buttonReplace_Click;
            // 
            // FormReplace
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReplace);
            Controls.Add(textBoxReplace);
            Controls.Add(label2);
            Controls.Add(textBoxSearch);
            Controls.Add(label1);
            Name = "FormReplace";
            Text = "FormReplace";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxSearch;
        private Label label2;
        private TextBox textBoxReplace;
        private Button buttonReplace;
    }
}