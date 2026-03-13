namespace WinFormsTemplate
{
    partial class Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // button1
            this.button1.Location = new System.Drawing.Point(100, 100);
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.Text = "Click Me";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.button1);
            this.Text = "WinForms Template";

            this.ResumeLayout(false);
        }
    }
}
