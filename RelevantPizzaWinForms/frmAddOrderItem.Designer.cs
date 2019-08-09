namespace RelevantPizzaWinForms
{
    partial class frmAddOrderItem
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
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDetailItems = new System.Windows.Forms.ComboBox();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.cmbDetailType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgOrderItemDetails = new System.Windows.Forms.DataGridView();
            this.btnClearItem = new System.Windows.Forms.Button();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItemDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbItemType
            // 
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(52, 51);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(248, 21);
            this.cmbItemType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbDetailItems);
            this.groupBox1.Controls.Add(this.lblDetailName);
            this.groupBox1.Controls.Add(this.cmbDetailType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // cmbDetailItems
            // 
            this.cmbDetailItems.FormattingEnabled = true;
            this.cmbDetailItems.Location = new System.Drawing.Point(22, 79);
            this.cmbDetailItems.Name = "cmbDetailItems";
            this.cmbDetailItems.Size = new System.Drawing.Size(248, 21);
            this.cmbDetailItems.TabIndex = 10;
            this.cmbDetailItems.Visible = false;
            // 
            // lblDetailName
            // 
            this.lblDetailName.AutoSize = true;
            this.lblDetailName.Location = new System.Drawing.Point(19, 63);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(0, 13);
            this.lblDetailName.TabIndex = 9;
            this.lblDetailName.Visible = false;
            // 
            // cmbDetailType
            // 
            this.cmbDetailType.FormattingEnabled = true;
            this.cmbDetailType.Location = new System.Drawing.Point(22, 31);
            this.cmbDetailType.Name = "cmbDetailType";
            this.cmbDetailType.Size = new System.Drawing.Size(248, 21);
            this.cmbDetailType.TabIndex = 8;
            this.cmbDetailType.SelectedValueChanged += new System.EventHandler(this.CmbDetailType_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Detail Type";
            // 
            // dgOrderItemDetails
            // 
            this.dgOrderItemDetails.AllowUserToAddRows = false;
            this.dgOrderItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrderItemDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrderItemDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderItemDetails.Location = new System.Drawing.Point(52, 270);
            this.dgOrderItemDetails.Name = "dgOrderItemDetails";
            this.dgOrderItemDetails.ReadOnly = true;
            this.dgOrderItemDetails.Size = new System.Drawing.Size(351, 132);
            this.dgOrderItemDetails.TabIndex = 6;
            // 
            // btnClearItem
            // 
            this.btnClearItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearItem.Location = new System.Drawing.Point(314, 241);
            this.btnClearItem.Name = "btnClearItem";
            this.btnClearItem.Size = new System.Drawing.Size(89, 23);
            this.btnClearItem.TabIndex = 11;
            this.btnClearItem.Text = "Clear Items";
            this.btnClearItem.UseVisualStyleBackColor = true;
            this.btnClearItem.Click += new System.EventHandler(this.BtnClearItem_Click);
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(52, 241);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(75, 23);
            this.btnAddDetail.TabIndex = 12;
            this.btnAddDetail.Text = "Add";
            this.btnAddDetail.UseVisualStyleBackColor = true;
            this.btnAddDetail.Click += new System.EventHandler(this.BtnAddDetail_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.Location = new System.Drawing.Point(304, 408);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(99, 23);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(197, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmAddOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.btnClearItem);
            this.Controls.Add(this.dgOrderItemDetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.label2);
            this.Name = "frmAddOrderItem";
            this.Text = "Add Order Item";
            this.Load += new System.EventHandler(this.AddOrderItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderItemDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgOrderItemDetails;
        private System.Windows.Forms.ComboBox cmbDetailType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDetailItems;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.Button btnClearItem;
        private System.Windows.Forms.Button btnAddDetail;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCancel;
    }
}