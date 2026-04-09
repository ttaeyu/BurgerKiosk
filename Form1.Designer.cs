namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            groupBox1 = new GroupBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            rbChicken = new RadioButton();
            rbBulgogi = new RadioButton();
            rbHam = new RadioButton();
            groupBox2 = new GroupBox();
            cbSource = new CheckBox();
            cbCheese = new CheckBox();
            cbCoke = new CheckBox();
            cbFries = new CheckBox();
            groupBox3 = new GroupBox();
            lblTotal = new Label();
            listOrder = new ListBox();
            btnOrder = new Button();
            btnClear = new Button();
            lblError = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(344, 50);
            label1.TabIndex = 0;
            label1.Text = "버거 주문 키오스크";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(rbChicken);
            groupBox1.Controls.Add(rbBulgogi);
            groupBox1.Controls.Add(rbHam);
            groupBox1.ForeColor = Color.Red;
            groupBox1.Location = new Point(26, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(178, 270);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(90, 36);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(90, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(90, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // rbChicken
            // 
            rbChicken.AutoSize = true;
            rbChicken.ForeColor = Color.Purple;
            rbChicken.Location = new Point(6, 188);
            rbChicken.Name = "rbChicken";
            rbChicken.Size = new Size(73, 19);
            rbChicken.TabIndex = 2;
            rbChicken.TabStop = true;
            rbChicken.Text = "치킨버거";
            rbChicken.UseVisualStyleBackColor = true;
            // 
            // rbBulgogi
            // 
            rbBulgogi.AutoSize = true;
            rbBulgogi.ForeColor = Color.Purple;
            rbBulgogi.Location = new Point(6, 110);
            rbBulgogi.Name = "rbBulgogi";
            rbBulgogi.Size = new Size(85, 19);
            rbBulgogi.TabIndex = 1;
            rbBulgogi.TabStop = true;
            rbBulgogi.Text = "불고기버거";
            rbBulgogi.UseVisualStyleBackColor = true;
            // 
            // rbHam
            // 
            rbHam.AutoSize = true;
            rbHam.ForeColor = Color.Purple;
            rbHam.Location = new Point(6, 35);
            rbHam.Name = "rbHam";
            rbHam.Size = new Size(61, 19);
            rbHam.TabIndex = 0;
            rbHam.TabStop = true;
            rbHam.Text = "햄버거";
            rbHam.UseVisualStyleBackColor = true;
            rbHam.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbSource);
            groupBox2.Controls.Add(cbCheese);
            groupBox2.Controls.Add(cbCoke);
            groupBox2.Controls.Add(cbFries);
            groupBox2.ForeColor = Color.Red;
            groupBox2.Location = new Point(223, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(113, 170);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            groupBox2.Enter += groupBox2_Enter_1;
            // 
            // cbSource
            // 
            cbSource.AutoSize = true;
            cbSource.ForeColor = Color.Purple;
            cbSource.Location = new Point(14, 111);
            cbSource.Name = "cbSource";
            cbSource.Size = new Size(78, 19);
            cbSource.TabIndex = 3;
            cbSource.Text = "소스 추가";
            cbSource.UseVisualStyleBackColor = true;
            // 
            // cbCheese
            // 
            cbCheese.AutoSize = true;
            cbCheese.ForeColor = Color.Purple;
            cbCheese.Location = new Point(14, 86);
            cbCheese.Name = "cbCheese";
            cbCheese.Size = new Size(78, 19);
            cbCheese.TabIndex = 2;
            cbCheese.Text = "치즈 추가";
            cbCheese.UseVisualStyleBackColor = true;
            // 
            // cbCoke
            // 
            cbCoke.AutoSize = true;
            cbCoke.ForeColor = Color.Purple;
            cbCoke.Location = new Point(14, 61);
            cbCoke.Name = "cbCoke";
            cbCoke.Size = new Size(50, 19);
            cbCoke.TabIndex = 1;
            cbCoke.Text = "콜라";
            cbCoke.UseVisualStyleBackColor = true;
            // 
            // cbFries
            // 
            cbFries.AutoSize = true;
            cbFries.ForeColor = Color.Purple;
            cbFries.Location = new Point(14, 36);
            cbFries.Name = "cbFries";
            cbFries.Size = new Size(74, 19);
            cbFries.TabIndex = 0;
            cbFries.Text = "감자튀김";
            cbFries.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(listOrder);
            groupBox3.ForeColor = Color.Red;
            groupBox3.Location = new Point(384, 107);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 206);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문내역";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.ForeColor = Color.Blue;
            lblTotal.Location = new Point(31, 183);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(73, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "총금액 : 0원";
            // 
            // listOrder
            // 
            listOrder.FormattingEnabled = true;
            listOrder.Location = new Point(18, 31);
            listOrder.Name = "listOrder";
            listOrder.Size = new Size(176, 139);
            listOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = SystemColors.ButtonHighlight;
            btnOrder.Location = new Point(384, 334);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(91, 48);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            btnClear.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnClear.ForeColor = SystemColors.ButtonHighlight;
            btnClear.Location = new Point(490, 334);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 48);
            btnClear.TabIndex = 5;
            btnClear.Text = "초기화";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(384, 316);
            lblError.Name = "lblError";
            lblError.Size = new Size(39, 15);
            lblError.TabIndex = 6;
            lblError.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 410);
            Controls.Add(lblError);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Buger Kiosk v1.0";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton rbHam;
        private RadioButton rbChicken;
        private RadioButton rbBulgogi;
        private GroupBox groupBox2;
        private CheckBox cbSource;
        private CheckBox cbCheese;
        private CheckBox cbCoke;
        private CheckBox cbFries;
        private GroupBox groupBox3;
        private Label lblTotal;
        private ListBox listOrder;
        private Button btnOrder;
        private Button btnClear;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblError;
    }
}
