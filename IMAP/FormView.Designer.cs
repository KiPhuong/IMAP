namespace IMAP
{
    partial class FormView
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
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.btReply = new System.Windows.Forms.Button();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "From: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "To: ";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(69, 15);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(472, 23);
            this.tbFrom.TabIndex = 2;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(69, 44);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(472, 23);
            this.tbTo.TabIndex = 3;
            // 
            // btReply
            // 
            this.btReply.Location = new System.Drawing.Point(575, 18);
            this.btReply.Name = "btReply";
            this.btReply.Size = new System.Drawing.Size(75, 50);
            this.btReply.TabIndex = 5;
            this.btReply.Text = "Reply";
            this.btReply.UseVisualStyleBackColor = true;
            this.btReply.Click += new System.EventHandler(this.btReply_Click);
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(69, 98);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(472, 340);
            this.rtbBody.TabIndex = 6;
            this.rtbBody.Text = "";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 450);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.btReply);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormView";
            this.Text = "FormView";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbFrom;
        private TextBox tbTo;
        private Button btReply;
        private RichTextBox rtbBody;
    }
}