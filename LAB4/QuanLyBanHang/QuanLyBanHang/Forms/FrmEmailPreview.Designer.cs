namespace QuanLyBanHang.Forms {
 partial class FrmEmailPreview {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if(disposing && components!=null)components.Dispose();
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();

   this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Size = new System.Drawing.Size(800, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "EMAIL XÁC NHẬN ĐẶT HÀNG";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // txtBody
            this.txtBody.Name = "txtBody";
            this.txtBody.Location = new System.Drawing.Point(25, 85);
            this.txtBody.Size = new System.Drawing.Size(800, 455);
            this.txtBody.TabIndex = 1;
            this.txtBody.MaxLength = 32767;
            this.txtBody.Multiline = true;
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.ReadOnly = true;
            // btnClose
            this.btnClose.Name = "btnClose";
            this.btnClose.Location = new System.Drawing.Point(670, 565);
            this.btnClose.Size = new System.Drawing.Size(155, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.btnClose);
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(850, 630);
   this.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Nội dung email xác nhận";
   this.Name = "FrmEmailPreview";
   this.Load += new System.EventHandler(this.FrmEmailPreview_Load);

   this.ResumeLayout(false);
   this.PerformLayout();
  }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Button btnClose;
 }
}
