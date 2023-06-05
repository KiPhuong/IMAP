namespace IMAP
{
    partial class FormReply
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(68, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(389, 23);
            this.tbName.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Name:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(68, 12);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(388, 23);
            this.tbFrom.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "From:";
            // 
            // tbSub
            // 
            this.tbSub.Location = new System.Drawing.Point(67, 127);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(500, 23);
            this.tbSub.TabIndex = 22;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(68, 88);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(389, 23);
            this.tbTo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "To:";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(67, 171);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(500, 277);
            this.rtbBody.TabIndex = 28;
            this.rtbBody.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Body:";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(492, 35);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 50);
            this.btSend.TabIndex = 29;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // FormReply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 467);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormReply";
            this.Text = "FormReply";
            this.Load += new System.EventHandler(this.FormReply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbName;
        private Label label5;
        private TextBox tbFrom;
        private Label label1;
        private TextBox tbSub;
        private TextBox tbTo;
        private Label label3;
        private Label label2;
        private RichTextBox rtbBody;
        private Label label4;
        private Button btSend;
    }
}