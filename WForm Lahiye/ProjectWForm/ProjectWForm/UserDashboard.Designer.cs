namespace ProjectWForm
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrderCustomerIDCard = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOrderCustomerSurname = new System.Windows.Forms.TextBox();
            this.txtOrderCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrderBookCount = new System.Windows.Forms.TextBox();
            this.cmbOrderBookGenres = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.listGiveBook = new System.Windows.Forms.ListBox();
            this.dateTimeGive = new System.Windows.Forms.DateTimePicker();
            this.dateTimeReturn = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOrderBookName = new System.Windows.Forms.ComboBox();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderBookBalances = new System.Windows.Forms.TextBox();
            this.btnGive = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(880, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "USER";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewCustomerToolStripMenuItem,
            this.orderBookToolStripMenuItem});
            this.ordersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.ordersToolStripMenuItem.Text = "Edit";
            // 
            // createNewCustomerToolStripMenuItem
            // 
            this.createNewCustomerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewCustomerToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.createNewCustomerToolStripMenuItem.Name = "createNewCustomerToolStripMenuItem";
            this.createNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.createNewCustomerToolStripMenuItem.Text = "Create New Customer";
            this.createNewCustomerToolStripMenuItem.Click += new System.EventHandler(this.createNewCustomerToolStripMenuItem_Click);
            // 
            // orderBookToolStripMenuItem
            // 
            this.orderBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBookToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.orderBookToolStripMenuItem.Name = "orderBookToolStripMenuItem";
            this.orderBookToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.orderBookToolStripMenuItem.Text = "Create New Book";
            this.orderBookToolStripMenuItem.Click += new System.EventHandler(this.orderBookToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "IDCard";
            // 
            // cmbOrderCustomerIDCard
            // 
            this.cmbOrderCustomerIDCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderCustomerIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderCustomerIDCard.FormattingEnabled = true;
            this.cmbOrderCustomerIDCard.Location = new System.Drawing.Point(7, 57);
            this.cmbOrderCustomerIDCard.Name = "cmbOrderCustomerIDCard";
            this.cmbOrderCustomerIDCard.Size = new System.Drawing.Size(172, 23);
            this.cmbOrderCustomerIDCard.TabIndex = 7;
            this.cmbOrderCustomerIDCard.SelectedValueChanged += new System.EventHandler(this.cmbOrderCustomerIDCard_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(3, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Surname";
            // 
            // txtOrderCustomerSurname
            // 
            this.txtOrderCustomerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderCustomerSurname.Location = new System.Drawing.Point(7, 124);
            this.txtOrderCustomerSurname.Name = "txtOrderCustomerSurname";
            this.txtOrderCustomerSurname.Size = new System.Drawing.Size(172, 21);
            this.txtOrderCustomerSurname.TabIndex = 10;
            // 
            // txtOrderCustomerName
            // 
            this.txtOrderCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderCustomerName.Location = new System.Drawing.Point(7, 188);
            this.txtOrderCustomerName.Name = "txtOrderCustomerName";
            this.txtOrderCustomerName.Size = new System.Drawing.Size(172, 21);
            this.txtOrderCustomerName.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(208, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name";
            // 
            // txtOrderBookCount
            // 
            this.txtOrderBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderBookCount.Location = new System.Drawing.Point(212, 188);
            this.txtOrderBookCount.Name = "txtOrderBookCount";
            this.txtOrderBookCount.Size = new System.Drawing.Size(99, 21);
            this.txtOrderBookCount.TabIndex = 10;
            this.txtOrderBookCount.Text = "1";
            // 
            // cmbOrderBookGenres
            // 
            this.cmbOrderBookGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderBookGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderBookGenres.FormattingEnabled = true;
            this.cmbOrderBookGenres.Location = new System.Drawing.Point(212, 57);
            this.cmbOrderBookGenres.Name = "cmbOrderBookGenres";
            this.cmbOrderBookGenres.Size = new System.Drawing.Size(172, 26);
            this.cmbOrderBookGenres.TabIndex = 7;
            this.cmbOrderBookGenres.SelectedValueChanged += new System.EventHandler(this.cmbOrderBookGenres_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(208, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Genres";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrderList.Location = new System.Drawing.Point(0, 310);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.Size = new System.Drawing.Size(964, 175);
            this.dgvOrderList.TabIndex = 14;
            // 
            // listGiveBook
            // 
            this.listGiveBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listGiveBook.FormattingEnabled = true;
            this.listGiveBook.ItemHeight = 16;
            this.listGiveBook.Location = new System.Drawing.Point(438, 57);
            this.listGiveBook.Name = "listGiveBook";
            this.listGiveBook.Size = new System.Drawing.Size(250, 212);
            this.listGiveBook.TabIndex = 15;
            // 
            // dateTimeGive
            // 
            this.dateTimeGive.Location = new System.Drawing.Point(708, 142);
            this.dateTimeGive.Name = "dateTimeGive";
            this.dateTimeGive.Size = new System.Drawing.Size(200, 20);
            this.dateTimeGive.TabIndex = 16;
            // 
            // dateTimeReturn
            // 
            this.dateTimeReturn.Location = new System.Drawing.Point(708, 185);
            this.dateTimeReturn.Name = "dateTimeReturn";
            this.dateTimeReturn.Size = new System.Drawing.Size(200, 20);
            this.dateTimeReturn.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(769, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(729, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Book Count :";
            // 
            // cmbOrderBookName
            // 
            this.cmbOrderBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrderBookName.FormattingEnabled = true;
            this.cmbOrderBookName.Location = new System.Drawing.Point(212, 122);
            this.cmbOrderBookName.Name = "cmbOrderBookName";
            this.cmbOrderBookName.Size = new System.Drawing.Size(172, 26);
            this.cmbOrderBookName.TabIndex = 20;
            this.cmbOrderBookName.SelectedValueChanged += new System.EventHandler(this.cmbOrderBookName_SelectedValueChanged);
            // 
            // lblBookCount
            // 
            this.lblBookCount.AutoSize = true;
            this.lblBookCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCount.ForeColor = System.Drawing.Color.Red;
            this.lblBookCount.Location = new System.Drawing.Point(830, 57);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(16, 16);
            this.lblBookCount.TabIndex = 21;
            this.lblBookCount.Text = "0";
            // 
            // btnAddList
            // 
            this.btnAddList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddList.ForeColor = System.Drawing.Color.White;
            this.btnAddList.Location = new System.Drawing.Point(438, 276);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(75, 23);
            this.btnAddList.TabIndex = 22;
            this.btnAddList.Text = "Add List";
            this.btnAddList.UseVisualStyleBackColor = false;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.BackColor = System.Drawing.Color.Red;
            this.btnRemoveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveList.ForeColor = System.Drawing.Color.White;
            this.btnRemoveList.Location = new System.Drawing.Point(586, 275);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(102, 23);
            this.btnRemoveList.TabIndex = 23;
            this.btnRemoveList.Text = "Remove List";
            this.btnRemoveList.UseVisualStyleBackColor = false;
            this.btnRemoveList.Click += new System.EventHandler(this.btnRemoveList_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(208, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(208, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Balances";
            // 
            // txtOrderBookBalances
            // 
            this.txtOrderBookBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderBookBalances.Location = new System.Drawing.Point(212, 252);
            this.txtOrderBookBalances.Name = "txtOrderBookBalances";
            this.txtOrderBookBalances.ReadOnly = true;
            this.txtOrderBookBalances.Size = new System.Drawing.Size(99, 21);
            this.txtOrderBookBalances.TabIndex = 24;
            // 
            // btnGive
            // 
            this.btnGive.BackColor = System.Drawing.Color.Gray;
            this.btnGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGive.ForeColor = System.Drawing.Color.White;
            this.btnGive.Location = new System.Drawing.Point(732, 86);
            this.btnGive.Name = "btnGive";
            this.btnGive.Size = new System.Drawing.Size(114, 50);
            this.btnGive.TabIndex = 26;
            this.btnGive.Text = "Give";
            this.btnGive.UseVisualStyleBackColor = false;
            this.btnGive.Click += new System.EventHandler(this.btnGive_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(885, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(964, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOrderBookBalances);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.lblBookCount);
            this.Controls.Add(this.cmbOrderBookName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimeReturn);
            this.Controls.Add(this.dateTimeGive);
            this.Controls.Add(this.listGiveBook);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderCustomerName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbOrderCustomerIDCard);
            this.Controls.Add(this.txtOrderCustomerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrderBookGenres);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtOrderBookCount);
            this.Controls.Add(this.label7);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDashboard_FormClosing);
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderBookToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cmbOrderCustomerIDCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOrderCustomerSurname;
        private System.Windows.Forms.TextBox txtOrderCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOrderBookCount;
        public System.Windows.Forms.ComboBox cmbOrderBookGenres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.ListBox listGiveBook;
        private System.Windows.Forms.DateTimePicker dateTimeGive;
        private System.Windows.Forms.DateTimePicker dateTimeReturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox cmbOrderBookName;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnRemoveList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderBookBalances;
        private System.Windows.Forms.Button btnGive;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}