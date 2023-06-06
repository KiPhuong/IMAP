namespace IMAP
{
    partial class FormSend
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
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.tbSub = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(82, 182);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(500, 277);
            this.rtbBody.TabIndex = 14;
            this.rtbBody.Text = "";
            // 
            // tbSub
            // 
            this.tbSub.Location = new System.Drawing.Point(82, 132);
            this.tbSub.Name = "tbSub";
            this.tbSub.Size = new System.Drawing.Size(500, 23);
            this.tbSub.TabIndex = 13;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(82, 91);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(389, 23);
            this.tbTo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "From:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(82, 12);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(388, 23);
            this.tbFrom.TabIndex = 16;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(82, 50);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(389, 23);
            this.tbName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name:";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(506, 26);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 62);
            this.btSend.TabIndex = 19;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(82, 465);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(499, 23);
            this.tbPath.TabIndex = 35;
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(587, 465);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(73, 23);
            this.btSelect.TabIndex = 34;
            this.btSelect.Text = "Select";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Attachment";
            // 
            // FormSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 509);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.tbSub);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormSend";
            this.Text = "FormSend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbBody;
        private TextBox tbSub;
        private TextBox tbTo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbFrom;
        private TextBox tbName;
        private Label label5;
        private Button btSend;
        private TextBox tbPath;
        private Button btSelect;
        private Label label6;
    }
}