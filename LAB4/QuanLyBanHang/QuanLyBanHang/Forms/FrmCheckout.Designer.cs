namespace QuanLyBanHang.Forms {
 partial class FrmCheckout {
  private System.ComponentModel.IContainer components = null;
  protected override void Dispose(bool disposing) {
   if(disposing && components!=null)components.Dispose();
   base.Dispose(disposing);
  }
  private void InitializeComponent() {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecipient = new System.Windows.Forms.Label();
            this.lblCard = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.cboShipping = new System.Windows.Forms.ComboBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblOwner = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.lblCsv = new System.Windows.Forms.Label();
            this.txtCsv = new System.Windows.Forms.TextBox();
            this.lblCardType = new System.Windows.Forms.Label();
            this.cboCard = new System.Windows.Forms.ComboBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.dtExpiry = new System.Windows.Forms.DateTimePicker();
            this.lblScenario = new System.Windows.Forms.Label();
            this.cboScenario = new System.Windows.Forms.ComboBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.chkEmailFail = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMock = new System.Windows.Forms.Label();

   this.SuspendLayout();
            // lblTitle
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Location = new System.Drawing.Point(25, 15);
            this.lblTitle.Size = new System.Drawing.Size(950, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ĐẶT HÀNG VÀ THANH TOÁN";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // lblRecipient
            this.lblRecipient.Name = "lblRecipient";
            this.lblRecipient.Location = new System.Drawing.Point(25, 65);
            this.lblRecipient.Size = new System.Drawing.Size(460, 30);
            this.lblRecipient.TabIndex = 1;
            this.lblRecipient.Text = "Thông tin người nhận";
            this.lblRecipient.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblRecipient.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // lblCard
            this.lblCard.Name = "lblCard";
            this.lblCard.Location = new System.Drawing.Point(520, 65);
            this.lblCard.Size = new System.Drawing.Size(455, 30);
            this.lblCard.TabIndex = 2;
            this.lblCard.Text = "Thông tin thẻ tín dụng";
            this.lblCard.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblCard.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // lblName
            this.lblName.Name = "lblName";
            this.lblName.Location = new System.Drawing.Point(25, 110);
            this.lblName.Size = new System.Drawing.Size(140, 28);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Họ tên *";
            // txtName
            this.txtName.Name = "txtName";
            this.txtName.Location = new System.Drawing.Point(175, 105);
            this.txtName.Size = new System.Drawing.Size(305, 28);
            this.txtName.TabIndex = 4;
            this.txtName.MaxLength = 100;
            // lblAddress
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Location = new System.Drawing.Point(25, 165);
            this.lblAddress.Size = new System.Drawing.Size(140, 28);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Địa chỉ *";
            // txtAddress
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Location = new System.Drawing.Point(175, 160);
            this.txtAddress.Size = new System.Drawing.Size(305, 28);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.MaxLength = 250;
            // lblPhone
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Location = new System.Drawing.Point(25, 220);
            this.lblPhone.Size = new System.Drawing.Size(140, 28);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Điện thoại *";
            // txtPhone
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Location = new System.Drawing.Point(175, 215);
            this.txtPhone.Size = new System.Drawing.Size(305, 28);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.MaxLength = 20;
            // lblRegion
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Location = new System.Drawing.Point(25, 275);
            this.lblRegion.Size = new System.Drawing.Size(140, 28);
            this.lblRegion.TabIndex = 9;
            this.lblRegion.Text = "Khu vực";
            // cboRegion
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Location = new System.Drawing.Point(175, 270);
            this.cboRegion.Size = new System.Drawing.Size(305, 28);
            this.cboRegion.TabIndex = 10;
            this.cboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // lblShipping
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Location = new System.Drawing.Point(25, 330);
            this.lblShipping.Size = new System.Drawing.Size(140, 28);
            this.lblShipping.TabIndex = 11;
            this.lblShipping.Text = "Loại giao hàng";
            // cboShipping
            this.cboShipping.Name = "cboShipping";
            this.cboShipping.Location = new System.Drawing.Point(175, 325);
            this.cboShipping.Size = new System.Drawing.Size(305, 28);
            this.cboShipping.TabIndex = 12;
            this.cboShipping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // lblNumber
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Location = new System.Drawing.Point(520, 165);
            this.lblNumber.Size = new System.Drawing.Size(120, 28);
            this.lblNumber.TabIndex = 13;
            this.lblNumber.Text = "Số thẻ *";
            // txtNumber
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Location = new System.Drawing.Point(665, 160);
            this.txtNumber.Size = new System.Drawing.Size(310, 28);
            this.txtNumber.TabIndex = 14;
            this.txtNumber.MaxLength = 16;
            this.txtNumber.UseSystemPasswordChar = true;
            // lblOwner
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Location = new System.Drawing.Point(520, 220);
            this.lblOwner.Size = new System.Drawing.Size(120, 28);
            this.lblOwner.TabIndex = 15;
            this.lblOwner.Text = "Chủ thẻ *";
            // txtOwner
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Location = new System.Drawing.Point(665, 215);
            this.txtOwner.Size = new System.Drawing.Size(310, 28);
            this.txtOwner.TabIndex = 16;
            this.txtOwner.MaxLength = 100;
            // lblCsv
            this.lblCsv.Name = "lblCsv";
            this.lblCsv.Location = new System.Drawing.Point(520, 275);
            this.lblCsv.Size = new System.Drawing.Size(120, 28);
            this.lblCsv.TabIndex = 17;
            this.lblCsv.Text = "Mã CSV *";
            // txtCsv
            this.txtCsv.Name = "txtCsv";
            this.txtCsv.Location = new System.Drawing.Point(665, 270);
            this.txtCsv.Size = new System.Drawing.Size(310, 28);
            this.txtCsv.TabIndex = 18;
            this.txtCsv.MaxLength = 4;
            this.txtCsv.UseSystemPasswordChar = true;
            // lblCardType
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Location = new System.Drawing.Point(520, 110);
            this.lblCardType.Size = new System.Drawing.Size(120, 28);
            this.lblCardType.TabIndex = 19;
            this.lblCardType.Text = "Loại thẻ";
            // cboCard
            this.cboCard.Name = "cboCard";
            this.cboCard.Location = new System.Drawing.Point(665, 105);
            this.cboCard.Size = new System.Drawing.Size(310, 28);
            this.cboCard.TabIndex = 20;
            this.cboCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // lblExpiry
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Location = new System.Drawing.Point(520, 330);
            this.lblExpiry.Size = new System.Drawing.Size(120, 28);
            this.lblExpiry.TabIndex = 21;
            this.lblExpiry.Text = "Hết hạn";
            // dtExpiry
            this.dtExpiry.Name = "dtExpiry";
            this.dtExpiry.Location = new System.Drawing.Point(665, 325);
            this.dtExpiry.Size = new System.Drawing.Size(310, 28);
            this.dtExpiry.TabIndex = 22;
            this.dtExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtExpiry.CustomFormat = "MM/yyyy";
            this.dtExpiry.ShowUpDown = true;
            // lblScenario
            this.lblScenario.Name = "lblScenario";
            this.lblScenario.Location = new System.Drawing.Point(520, 385);
            this.lblScenario.Size = new System.Drawing.Size(140, 28);
            this.lblScenario.TabIndex = 23;
            this.lblScenario.Text = "Kết quả giả lập";
            // cboScenario
            this.cboScenario.Name = "cboScenario";
            this.cboScenario.Location = new System.Drawing.Point(665, 380);
            this.cboScenario.Size = new System.Drawing.Size(310, 28);
            this.cboScenario.TabIndex = 24;
            this.cboScenario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            // lblNote
            this.lblNote.Name = "lblNote";
            this.lblNote.Location = new System.Drawing.Point(25, 385);
            this.lblNote.Size = new System.Drawing.Size(455, 65);
            this.lblNote.TabIndex = 25;
            this.lblNote.Text = "Người nhận có thể khác người mua. Giao nhanh miễn phí từ 1 triệu; giao trong ngày miễn phí từ 5 triệu.";
            // chkEmailFail
            this.chkEmailFail.Name = "chkEmailFail";
            this.chkEmailFail.Location = new System.Drawing.Point(520, 425);
            this.chkEmailFail.Size = new System.Drawing.Size(440, 28);
            this.chkEmailFail.TabIndex = 26;
            this.chkEmailFail.Text = "Giả lập dịch vụ email lỗi";
            this.chkEmailFail.AutoSize = true;
            // lblTotal
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Location = new System.Drawing.Point(25, 495);
            this.lblTotal.Size = new System.Drawing.Size(950, 80);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Bấm Tính tổng để xem chi phí trước khi xác nhận.";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(17, 60, 104);
            // btnCalculate
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Location = new System.Drawing.Point(25, 600);
            this.btnCalculate.Size = new System.Drawing.Size(180, 38);
            this.btnCalculate.TabIndex = 28;
            this.btnCalculate.Text = "Tính tổng";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // btnSubmit
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Location = new System.Drawing.Point(230, 600);
            this.btnSubmit.Size = new System.Drawing.Size(200, 38);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Xác nhận đặt hàng";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // btnOrders
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Location = new System.Drawing.Point(455, 600);
            this.btnOrders.Size = new System.Drawing.Size(210, 38);
            this.btnOrders.TabIndex = 30;
            this.btnOrders.Text = "Xem đơn / Đối soát";
            this.btnOrders.UseVisualStyleBackColor = true;
            // btnNew
            this.btnNew.Name = "btnNew";
            this.btnNew.Location = new System.Drawing.Point(690, 600);
            this.btnNew.Size = new System.Drawing.Size(220, 38);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "Đặt lại sau từ chối";
            this.btnNew.UseVisualStyleBackColor = true;
            // btnClose
            this.btnClose.Name = "btnClose";
            this.btnClose.Location = new System.Drawing.Point(820, 675);
            this.btnClose.Size = new System.Drawing.Size(155, 38);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // lblMock
            this.lblMock.Name = "lblMock";
            this.lblMock.Location = new System.Drawing.Point(25, 665);
            this.lblMock.Size = new System.Drawing.Size(770, 38);
            this.lblMock.TabIndex = 33;
            this.lblMock.Text = "LAB: thanh toán và email dùng Adapter giả lập, không thu tiền hoặc gửi thư thật.";
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecipient);
            this.Controls.Add(this.lblCard);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.cboShipping);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.txtOwner);
            this.Controls.Add(this.lblCsv);
            this.Controls.Add(this.txtCsv);
            this.Controls.Add(this.lblCardType);
            this.Controls.Add(this.cboCard);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.dtExpiry);
            this.Controls.Add(this.lblScenario);
            this.Controls.Add(this.cboScenario);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.chkEmailFail);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblMock);
   this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
   this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
   this.ClientSize = new System.Drawing.Size(1000, 735);
   this.Font = new System.Drawing.Font("Segoe UI", 9F);
   this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
   this.MaximizeBox = false;
   this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
   this.Text = "Đặt hàng - Thanh toán";
   this.Name = "FrmCheckout";
   this.Load += new System.EventHandler(this.FrmCheckout_Load);

   this.ResumeLayout(false);
   this.PerformLayout();
  }
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecipient;
        private System.Windows.Forms.Label lblCard;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ComboBox cboRegion;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.ComboBox cboShipping;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.Label lblCsv;
        private System.Windows.Forms.TextBox txtCsv;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.ComboBox cboCard;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DateTimePicker dtExpiry;
        private System.Windows.Forms.Label lblScenario;
        private System.Windows.Forms.ComboBox cboScenario;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.CheckBox chkEmailFail;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMock;
 }
}
