namespace herrac_ve_satis_tetbiqi
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
            label1 = new Label();
            txtBasePrice = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            btnAddProduct = new Button();
            listBoxProducts = new ListBox();
            label3 = new Label();
            txtNewBid = new TextBox();
            label4 = new Label();
            txtBuyerName = new TextBox();
            btnMakeBid = new Button();
            btnFinishAuction = new Button();
            lblResult = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 76);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 0;
            label1.Text = "Məhsul adı:";
          
            // 
            // txtBasePrice
            // 
            txtBasePrice.Location = new Point(169, 26);
            txtBasePrice.Name = "txtBasePrice";
            txtBasePrice.Size = new Size(140, 27);
            txtBasePrice.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 32);
            label2.Name = "label2";
            label2.Size = new Size(143, 23);
            label2.TabIndex = 2;
            label2.Text = "Başlanğıc qiymət:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(169, 76);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(140, 27);
            txtProductName.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.DarkSeaGreen;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(161, 133);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(148, 29);
            btnAddProduct.TabIndex = 4;
            btnAddProduct.Text = "Məhsul əlavə et";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // listBoxProducts
            // 
            listBoxProducts.FormattingEnabled = true;
            listBoxProducts.IntegralHeight = false;
            listBoxProducts.Location = new Point(490, 58);
            listBoxProducts.Name = "listBoxProducts";
            listBoxProducts.Size = new Size(329, 144);
            listBoxProducts.TabIndex = 5;
            listBoxProducts.SelectedIndexChanged += listBoxProducts_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 38);
            label3.Name = "label3";
            label3.Size = new Size(150, 23);
            label3.TabIndex = 6;
            label3.Text = "Yeni təklif qiyməti:";
            // 
            // txtNewBid
            // 
            txtNewBid.Location = new Point(169, 38);
            txtNewBid.Name = "txtNewBid";
            txtNewBid.Size = new Size(140, 27);
            txtNewBid.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 83);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 8;
            label4.Text = "Alıcı adı:";
            // 
            // txtBuyerName
            // 
            txtBuyerName.Location = new Point(169, 83);
            txtBuyerName.Name = "txtBuyerName";
            txtBuyerName.Size = new Size(140, 27);
            txtBuyerName.TabIndex = 9;
            // 
            // btnMakeBid
            // 
            btnMakeBid.BackColor = Color.DarkSeaGreen;
            btnMakeBid.FlatAppearance.BorderSize = 0;
            btnMakeBid.FlatStyle = FlatStyle.Flat;
            btnMakeBid.ForeColor = Color.White;
            btnMakeBid.Location = new Point(8, 143);
            btnMakeBid.Name = "btnMakeBid";
            btnMakeBid.Size = new Size(148, 29);
            btnMakeBid.TabIndex = 10;
            btnMakeBid.Text = "Təklif et";
            btnMakeBid.UseVisualStyleBackColor = false;
            btnMakeBid.Click += btnMakeBid_Click;
            // 
            // btnFinishAuction
            // 
            btnFinishAuction.BackColor = Color.DarkSeaGreen;
            btnFinishAuction.FlatAppearance.BorderSize = 0;
            btnFinishAuction.FlatStyle = FlatStyle.Flat;
            btnFinishAuction.ForeColor = Color.White;
            btnFinishAuction.Location = new Point(169, 143);
            btnFinishAuction.Name = "btnFinishAuction";
            btnFinishAuction.Size = new Size(148, 29);
            btnFinishAuction.TabIndex = 11;
            btnFinishAuction.Text = "Hərracı bitir";
            btnFinishAuction.UseVisualStyleBackColor = false;
            btnFinishAuction.Click += btnFinishAuction_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.LightYellow;
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(490, 332);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(329, 52);
            lblResult.TabIndex = 12;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBasePrice);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Location = new Point(14, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 188);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Məhsul məlumatları";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtNewBid);
            groupBox2.Controls.Add(btnFinishAuction);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnMakeBid);
            groupBox2.Controls.Add(txtBuyerName);
            groupBox2.Location = new Point(14, 233);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 188);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Təklif bölməsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 32);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(490, 26);
            label6.Name = "label6";
            label6.Size = new Size(144, 23);
            label6.TabIndex = 15;
            label6.Text = "Məhsullar siyahısı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(490, 298);
            label7.Name = "label7";
            label7.Size = new Size(110, 23);
            label7.TabIndex = 16;
            label7.Text = "Nəticə paneli";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(850, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblResult);
            Controls.Add(listBoxProducts);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Hərrac və Satış Tətbiqi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBasePrice;
        private Label label2;
        private TextBox txtProductName;
        private Button btnAddProduct;
        private ListBox listBoxProducts;
        private Label label3;
        private TextBox txtNewBid;
        private Label label4;
        private TextBox txtBuyerName;
        private Button btnMakeBid;
        private Button btnFinishAuction;
        private Label lblResult;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
