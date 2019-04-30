namespace UnipiTexnologiaLogismikou
{
    partial class EmailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mailtextBox = new System.Windows.Forms.TextBox();
            this.messagetextBox = new System.Windows.Forms.TextBox();
            this.senmailbutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(167, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(167, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // mailtextBox
            // 
            this.mailtextBox.Location = new System.Drawing.Point(245, 86);
            this.mailtextBox.Name = "mailtextBox";
            this.mailtextBox.Size = new System.Drawing.Size(178, 20);
            this.mailtextBox.TabIndex = 2;
            // 
            // messagetextBox
            // 
            this.messagetextBox.Location = new System.Drawing.Point(245, 123);
            this.messagetextBox.Multiline = true;
            this.messagetextBox.Name = "messagetextBox";
            this.messagetextBox.Size = new System.Drawing.Size(178, 160);
            this.messagetextBox.TabIndex = 3;
            // 
            // senmailbutton
            // 
            this.senmailbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.senmailbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.senmailbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.senmailbutton.Location = new System.Drawing.Point(245, 312);
            this.senmailbutton.Name = "senmailbutton";
            this.senmailbutton.Size = new System.Drawing.Size(178, 23);
            this.senmailbutton.TabIndex = 4;
            this.senmailbutton.Text = "Send Email";
            this.senmailbutton.UseVisualStyleBackColor = true;
            this.senmailbutton.Click += new System.EventHandler(this.senmailbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.backbutton.Location = new System.Drawing.Point(300, 355);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(75, 23);
            this.backbutton.TabIndex = 5;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UnipiTexnologiaLogismikou.Properties.Resources.b;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.senmailbutton);
            this.Controls.Add(this.messagetextBox);
            this.Controls.Add(this.mailtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmailForm";
            this.Text = "EmailForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmailForm_FormClosing);
            this.Load += new System.EventHandler(this.EmailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mailtextBox;
        private System.Windows.Forms.TextBox messagetextBox;
        private System.Windows.Forms.Button senmailbutton;
        private System.Windows.Forms.Button backbutton;
    }
}