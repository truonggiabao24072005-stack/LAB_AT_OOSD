namespace QuanLyBanHang.Forms {
 partial class FrmCart {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if(disposing && components!=null)components.Dispose();
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.dgvCart_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCart_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCart_UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCart_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCart_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQty = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
   this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(900, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "GIỎ HÀNG HIỆN TẠI";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // dgvCart
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Location = new System.Drawing.Point(25, 80);
            this.dgvCart.Size = new System.Drawing.Size(950, 340);
            this.dgvCart.TabIndex = 1;
            this.dgvCart.ReadOnly = true;
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AutoGenerateColumns = false;
            this.dgvCart.MultiSelect = false;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.EnableHeadersVisualStyles = false;
            this.dgvCart.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(232, 239, 244);
            this.dgvCart.ColumnHeadersHeight = 32;
            this.dgvCart.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvCart_Code.Name = "dgvCart_Code";
            this.dgvCart_Code.DataPropertyName = "Code";
            this.dgvCart_Code.HeaderText = "Mã SP";
            this.dgvCart_Code.FillWeight = 65F;
            this.dgvCart_Code.ReadOnly = true;
            this.dgvCart.Columns.Add(this.dgvCart_Code);
            this.dgvCart_Name.Name = "dgvCart_Name";
            this.dgvCart_Name.DataPropertyName = "Name";
            this.dgvCart_Name.HeaderText = "Tên sản phẩm";
            this.dgvCart_Name.FillWeight = 180F;
            this.dgvCart_Name.ReadOnly = true;
            this.dgvCart.Columns.Add(this.dgvCart_Name);
            this.dgvCart_UnitPrice.Name = "dgvCart_UnitPrice";
            this.dgvCart_UnitPrice.DataPropertyName = "UnitPrice";
            this.dgvCart_UnitPrice.HeaderText = "Đơn giá";
            this.dgvCart_UnitPrice.FillWeight = 100F;
            this.dgvCart_UnitPrice.ReadOnly = true;
            this.dgvCart_UnitPrice.DefaultCellStyle.Format = "N0";
            this.dgvCart_UnitPrice.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvCart.Columns.Add(this.dgvCart_UnitPrice);
            this.dgvCart_Quantity.Name = "dgvCart_Quantity";
            this.dgvCart_Quantity.DataPropertyName = "Quantity";
            this.dgvCart_Quantity.HeaderText = "Số lượng";
            this.dgvCart_Quantity.FillWeight = 70F;
            this.dgvCart_Quantity.ReadOnly = true;
            this.dgvCart.Columns.Add(this.dgvCart_Quantity);
            this.dgvCart_Total.Name = "dgvCart_Total";
            this.dgvCart_Total.DataPropertyName = "Total";
            this.dgvCart_Total.HeaderText = "Thành tiền";
            this.dgvCart_Total.FillWeight = 110F;
            this.dgvCart_Total.ReadOnly = true;
            this.dgvCart_Total.DefaultCellStyle.Format = "N0";
            this.dgvCart_Total.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvCart.Columns.Add(this.dgvCart_Total);
            // lblQty
            this.lblQty.Name = "lblQty";
            this.lblQty.Location = new System.Drawing.Point(25, 455);
            this.lblQty.Size = new System.Drawing.Size(170, 28);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "Số lượng";
            // numQuantity
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Location = new System.Drawing.Point(120, 450);
            this.numQuantity.Size = new System.Drawing.Size(100, 28);
            this.numQuantity.TabIndex = 3;
            this.numQuantity.Minimum = 1;
            this.numQuantity.Maximum = 1000;
            this.numQuantity.Value = 1;
            // btnUpdate
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Location = new System.Drawing.Point(250, 445);
            this.btnUpdate.Size = new System.Drawing.Size(155, 38);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // btnRemove
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Location = new System.Drawing.Point(420, 445);
            this.btnRemove.Size = new System.Drawing.Size(155, 38);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Xóa sản phẩm";
            this.btnRemove.UseVisualStyleBackColor = true;
            // btnCheckout
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Location = new System.Drawing.Point(650, 445);
            this.btnCheckout.Size = new System.Drawing.Size(200, 38);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Tính tiền / Đặt hàng";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // lblTotal
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Location = new System.Drawing.Point(25, 510);
            this.lblTotal.Size = new System.Drawing.Size(750, 35);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Tiền hàng tạm tính: 0đ";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // btnClose
            this.btnClose.Name = "btnClose";
            this.btnClose.Location = new System.Drawing.Point(820, 540);
            this.btnClose.Size = new System.Drawing.Size(155, 38);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClose);
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1000, 610);
   this.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Giỏ hàng";
   this.Name = "FrmCart";
   this.Load += new System.EventHandler(this.FrmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();
  }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCart_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCart_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCart_UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCart_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCart_Total;
 }
}
