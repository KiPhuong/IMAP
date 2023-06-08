namespace IMAP
{
    partial class MainForm
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
            this.btLogout = new System.Windows.Forms.Button();
            this.btSendM = new System.Windows.Forms.Button();
            this.btRef = new System.Windows.Forms.Button();
            this.tbOwn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvBox = new System.Windows.Forms.ListView();
            this.colNum = new System.Windows.Forms.ColumnHeader();
            this.colFrom = new System.Windows.Forms.ColumnHeader();
            this.colSub = new System.Windows.Forms.ColumnHeader();
            this.colDate = new System.Windows.Forms.ColumnHeader();
            this.lbpage = new System.Windows.Forms.Label();
            this.tbPage = new System.Windows.Forms.TextBox();
            this.btNext = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(686, 14);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 40);
            this.btLogout.TabIndex = 2;
            this.btLogout.Text = "Log out";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btSendM
            // 
            this.btSendM.Location = new System.Drawing.Point(469, 14);
            this.btSendM.Name = "btSendM";
            this.btSendM.Size = new System.Drawing.Size(75, 40);
            this.btSendM.TabIndex = 4;
            this.btSendM.Text = "Send mail";
            this.btSendM.UseVisualStyleBackColor = true;
            this.btSendM.Click += new System.EventHandler(this.btSendM_Click);
            // 
            // btRef
            // 
            this.btRef.Location = new System.Drawing.Point(578, 14);
            this.btRef.Name = "btRef";
            this.btRef.Size = new System.Drawing.Size(75, 40);
            this.btRef.TabIndex = 5;
            this.btRef.Text = "Refresh";
            this.btRef.UseVisualStyleBackColor = true;
            this.btRef.Click += new System.EventHandler(this.btRef_Click);
            // 
            // tbOwn
            // 
            this.tbOwn.Location = new System.Drawing.Point(75, 24);
            this.tbOwn.Name = "tbOwn";
            this.tbOwn.Size = new System.Drawing.Size(359, 23);
            this.tbOwn.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Owner: ";
            // 
            // lvBox
            // 
            this.lvBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNum,
            this.colFrom,
            this.colSub,
            this.colDate});
            this.lvBox.FullRowSelect = true;
            this.lvBox.Location = new System.Drawing.Point(21, 71);
            this.lvBox.Name = "lvBox";
            this.lvBox.Size = new System.Drawing.Size(769, 367);
            this.lvBox.TabIndex = 8;
            this.lvBox.UseCompatibleStateImageBehavior = false;
            this.lvBox.View = System.Windows.Forms.View.Details;
            this.lvBox.SelectedIndexChanged += new System.EventHandler(this.lvBox_SelectedIndexChanged);
            // 
            // colNum
            // 
            this.colNum.Text = "#";
            this.colNum.Width = 25;
            // 
            // colFrom
            // 
            this.colFrom.Text = "From";
            this.colFrom.Width = 250;
            // 
            // colSub
            // 
            this.colSub.Text = "Subject";
            this.colSub.Width = 350;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 140;
            // 
            // lbpage
            // 
            this.lbpage.AutoSize = true;
            this.lbpage.Location = new System.Drawing.Point(686, 470);
            this.lbpage.Name = "lbpage";
            this.lbpage.Size = new System.Drawing.Size(10, 15);
            this.lbpage.TabIndex = 32;
            this.lbpage.Text = " ";
            // 
            // tbPage
            // 
            this.tbPage.Enabled = false;
            this.tbPage.Location = new System.Drawing.Point(686, 444);
            this.tbPage.Name = "tbPage";
            this.tbPage.Size = new System.Drawing.Size(35, 23);
            this.tbPage.TabIndex = 31;
            this.tbPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btNext
            // 
            this.btNext.Location = new System.Drawing.Point(736, 444);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(50, 23);
            this.btNext.TabIndex = 30;
            this.btNext.Text = "Next";
            this.btNext.UseVisualStyleBackColor = true;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(620, 444);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(50, 23);
            this.btBack.TabIndex = 29;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(523, 447);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(38, 15);
            this.lbTotal.TabIndex = 28;
            this.lbTotal.Text = "Total: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.lbpage);
            this.Controls.Add(this.tbPage);
            this.Controls.Add(this.btNext);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lvBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOwn);
            this.Controls.Add(this.btRef);
            this.Controls.Add(this.btSendM);
            this.Controls.Add(this.btLogout);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btLogout;
        private Button btSendM;
        private Button btRef;
        private TextBox tbOwn;
        private Label label1;
        private ListView lvBox;
        private ColumnHeader colNum;
        private ColumnHeader colFrom;
        private ColumnHeader colSub;
        private ColumnHeader colDate;
        private Label lbpage;
        private TextBox tbPage;
        private Button btNext;
        private Button btBack;
        private Label lbTotal;
    }
}