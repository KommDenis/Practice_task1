namespace practice_task1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonOpenAddresses = new System.Windows.Forms.Button();
            this.labelAddressId = new System.Windows.Forms.Label();
            this.textBoxAddressId = new System.Windows.Forms.TextBox();
            this.buttonLinkAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(62, 200);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(228, 200);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(348, 198);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(429, 198);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(510, 198);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 203);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(190, 203);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(26, 13);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age";
            // 
            // buttonOpenAddresses
            // 
            this.buttonOpenAddresses.Location = new System.Drawing.Point(592, 198);
            this.buttonOpenAddresses.Name = "buttonOpenAddresses";
            this.buttonOpenAddresses.Size = new System.Drawing.Size(140, 23);
            this.buttonOpenAddresses.TabIndex = 8;
            this.buttonOpenAddresses.Text = "Manage Addresses";
            this.buttonOpenAddresses.UseVisualStyleBackColor = true;
            this.buttonOpenAddresses.Click += new System.EventHandler(this.buttonOpenAddresses_Click);
            // 
            // labelAddressId
            // 
            this.labelAddressId.AutoSize = true;
            this.labelAddressId.Location = new System.Drawing.Point(12, 240);
            this.labelAddressId.Name = "labelAddressId";
            this.labelAddressId.Size = new System.Drawing.Size(58, 13);
            this.labelAddressId.TabIndex = 9;
            this.labelAddressId.Text = "Address ID";
            // 
            // textBoxAddressId
            // 
            this.textBoxAddressId.Location = new System.Drawing.Point(76, 237);
            this.textBoxAddressId.Name = "textBoxAddressId";
            this.textBoxAddressId.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddressId.TabIndex = 10;
            // 
            // buttonLinkAddress
            // 
            this.buttonLinkAddress.Location = new System.Drawing.Point(182, 235);
            this.buttonLinkAddress.Name = "buttonLinkAddress";
            this.buttonLinkAddress.Size = new System.Drawing.Size(75, 23);
            this.buttonLinkAddress.TabIndex = 11;
            this.buttonLinkAddress.Text = "Link Address";
            this.buttonLinkAddress.UseVisualStyleBackColor = true;
            this.buttonLinkAddress.Click += new System.EventHandler(this.buttonLinkAddress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLinkAddress);
            this.Controls.Add(this.textBoxAddressId);
            this.Controls.Add(this.labelAddressId);
            this.Controls.Add(this.buttonOpenAddresses);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Custom NoSQL DB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonOpenAddresses;
        private System.Windows.Forms.Label labelAddressId;
        private System.Windows.Forms.TextBox textBoxAddressId;
        private System.Windows.Forms.Button buttonLinkAddress;
    }
}
