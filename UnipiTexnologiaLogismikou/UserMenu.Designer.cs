namespace UnipiTexnologiaLogismikou
{
    partial class UserMenu
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
            this.emailbutton = new System.Windows.Forms.Button();
            this.uploadbutton = new System.Windows.Forms.Button();
            this.forumbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // emailbutton
            // 
            this.emailbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emailbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emailbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.emailbutton.Location = new System.Drawing.Point(91, 174);
            this.emailbutton.Name = "emailbutton";
            this.emailbutton.Size = new System.Drawing.Size(120, 23);
            this.emailbutton.TabIndex = 0;
            this.emailbutton.Text = "Email to Instructor";
            this.emailbutton.UseVisualStyleBackColor = true;
            this.emailbutton.Click += new System.EventHandler(this.emailbutton_Click);
            // 
            // uploadbutton
            // 
            this.uploadbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uploadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.uploadbutton.Location = new System.Drawing.Point(287, 174);
            this.uploadbutton.Name = "uploadbutton";
            this.uploadbutton.Size = new System.Drawing.Size(120, 23);
            this.uploadbutton.TabIndex = 1;
            this.uploadbutton.Text = "Upload your Thesis";
            this.uploadbutton.UseVisualStyleBackColor = true;
            this.uploadbutton.Click += new System.EventHandler(this.uploadbutton_Click);
            // 
            // forumbutton
            // 
            this.forumbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forumbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forumbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.forumbutton.Location = new System.Drawing.Point(474, 174);
            this.forumbutton.Name = "forumbutton";
            this.forumbutton.Size = new System.Drawing.Size(120, 23);
            this.forumbutton.TabIndex = 2;
            this.forumbutton.Text = "Visit Forum";
            this.forumbutton.UseVisualStyleBackColor = true;
            this.forumbutton.Click += new System.EventHandler(this.forumbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnipiTexnologiaLogismikou.Properties.Resources.b;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.forumbutton);
            this.Controls.Add(this.uploadbutton);
            this.Controls.Add(this.emailbutton);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserMenu_FormClosing);
            this.Load += new System.EventHandler(this.UserMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button emailbutton;
        private System.Windows.Forms.Button uploadbutton;
        private System.Windows.Forms.Button forumbutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}