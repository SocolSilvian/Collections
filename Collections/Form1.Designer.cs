
namespace Collections
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.testbutton = new System.Windows.Forms.Button();
            this.collectionsTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testbutton
            // 
            this.testbutton.Location = new System.Drawing.Point(175, 328);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(100, 47);
            this.testbutton.TabIndex = 0;
            this.testbutton.Text = "Test";
            this.testbutton.UseVisualStyleBackColor = true;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // collectionsTestButton
            // 
            this.collectionsTestButton.Location = new System.Drawing.Point(365, 328);
            this.collectionsTestButton.Name = "collectionsTestButton";
            this.collectionsTestButton.Size = new System.Drawing.Size(85, 47);
            this.collectionsTestButton.TabIndex = 1;
            this.collectionsTestButton.Text = "Collections";
            this.collectionsTestButton.UseVisualStyleBackColor = true;
            this.collectionsTestButton.Click += new System.EventHandler(this.collectionsTestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.collectionsTestButton);
            this.Controls.Add(this.testbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.Button collectionsTestButton;
    }
}

