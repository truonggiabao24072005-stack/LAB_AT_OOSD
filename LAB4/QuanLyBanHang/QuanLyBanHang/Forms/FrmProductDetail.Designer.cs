namespace QuanLyBanHang.Forms {
 partial class FrmProductDetail {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if(disposing && components!=null)components.Dispose();
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblSpecs = new System.Windows.Forms.Label();
            this.txtSpecs = new System.Windows.Forms.TextBox();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
   this.SuspendLayout();
            // lblName
            this.lblName.Name = "lblName";
            this.lblName.Location = new System.Drawing.Point(25, 20);
            this.lblName.Size = new System.Drawing.Size(940, 42);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "CHI TIẾT SẢN PHẨM";
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // lblInfo
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Location = new System.Drawing.Point(25, 80);
            this.lblInfo.Size = new System.Drawing.Size(580, 88);
            this.lblInfo.TabIndex = 1;
            // lblDescription
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Location = new System.Drawing.Point(25, 185);
            this.lblDescription.Size = new System.Drawing.Size(500, 28);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Mô tả sản phẩm";
            // txtDescription
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Location = new System.Drawing.Point(25, 215);
            this.txtDescription.Size = new System.Drawing.Size(570, 90);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.MaxLength = 250;
            this.txtDescription.Multiline = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.ReadOnly = true;
            // lblSpecs
            this.lblSpecs.Name = "lblSpecs";
            this.lblSpecs.Location = new System.Drawing.Point(25, 325);
            this.lblSpecs.Size = new System.Drawing.Size(500, 28);
            this.lblSpecs.TabIndex = 4;
            this.lblSpecs.Text = "Thông số kỹ thuật";
            // txtSpecs
            this.txtSpecs.Name = "txtSpecs";
            this.txtSpecs.Location = new System.Drawing.Point(25, 355);
            this.txtSpecs.Size = new System.Drawing.Size(570, 100);
            this.txtSpecs.TabIndex = 5;
            this.txtSpecs.MaxLength = 250;
            this.txtSpecs.Multiline = true;
            this.txtSpecs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSpecs.ReadOnly = true;
            // picProduct
            this.picProduct.Name = "picProduct";
            this.picProduct.Location = new System.Drawing.Point(625, 100);
            this.picProduct.Size = new System.Drawing.Size(345, 310);
            this.picProduct.TabIndex = 6;
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // btnPrev
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Location = new System.Drawing.Point(625, 430);
            this.btnPrev.Size = new System.Drawing.Size(160, 38);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Ảnh trước";
            this.btnPrev.UseVisualStyleBackColor = true;
            // btnNext
            this.btnNext.Name = "btnNext";
            this.btnNext.Location = new System.Drawing.Point(810, 430);
            this.btnNext.Size = new System.Drawing.Size(160, 38);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Ảnh sau";
            this.btnNext.UseVisualStyleBackColor = true;
            // lblQuantity
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Location = new System.Drawing.Point(25, 485);
            this.lblQuantity.Size = new System.Drawing.Size(170, 28);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Số lượng";
            // numQuantity
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Location = new System.Drawing.Point(135, 480);
            this.numQuantity.Size = new System.Drawing.Size(100, 28);
            this.numQuantity.TabIndex = 10;
            this.numQuantity.Minimum = 1;
            this.numQuantity.Maximum = 1000;
            this.numQuantity.Value = 1;
            // btnAdd
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Location = new System.Drawing.Point(270, 475);
            this.btnAdd.Size = new System.Drawing.Size(190, 38);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm vào giỏ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // btnClose
            this.btnClose.Name = "btnClose";
            this.btnClose.Location = new System.Drawing.Point(815, 525);
            this.btnClose.Size = new System.Drawing.Size(155, 38);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblSpecs);
            this.Controls.Add(this.txtSpecs);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1000, 620);
   this.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Chi tiết sản phẩm";
   this.Name = "FrmProductDetail";
   this.Load += new System.EventHandler(this.FrmProductDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
   this.ResumeLayout(false);
   this.PerformLayout();
  }
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblSpecs;
        private System.Windows.Forms.TextBox txtSpecs;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
 }
}
