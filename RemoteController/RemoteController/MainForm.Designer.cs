namespace RemoteControllerForOOP
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCManufacturer = new System.Windows.Forms.RadioButton();
            this.rdoBManufacturer = new System.Windows.Forms.RadioButton();
            this.rdoAManufacturer = new System.Windows.Forms.RadioButton();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtSendingContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCManufacturer);
            this.groupBox1.Controls.Add(this.rdoBManufacturer);
            this.groupBox1.Controls.Add(this.rdoAManufacturer);
            this.groupBox1.Font = new System.Drawing.Font("游ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "メーカー選択";
            // 
            // rdoCManufacturer
            // 
            this.rdoCManufacturer.AutoSize = true;
            this.rdoCManufacturer.Font = new System.Drawing.Font("游ゴシック", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoCManufacturer.Location = new System.Drawing.Point(271, 73);
            this.rdoCManufacturer.Name = "rdoCManufacturer";
            this.rdoCManufacturer.Size = new System.Drawing.Size(91, 39);
            this.rdoCManufacturer.TabIndex = 2;
            this.rdoCManufacturer.Text = "C社";
            this.rdoCManufacturer.UseVisualStyleBackColor = true;
            this.rdoCManufacturer.CheckedChanged += new System.EventHandler(this.Manufacturer_RadioButton_CheckedChanged);
            // 
            // rdoBManufacturer
            // 
            this.rdoBManufacturer.AutoSize = true;
            this.rdoBManufacturer.Font = new System.Drawing.Font("游ゴシック", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoBManufacturer.Location = new System.Drawing.Point(147, 73);
            this.rdoBManufacturer.Name = "rdoBManufacturer";
            this.rdoBManufacturer.Size = new System.Drawing.Size(91, 39);
            this.rdoBManufacturer.TabIndex = 1;
            this.rdoBManufacturer.Text = "B社";
            this.rdoBManufacturer.UseVisualStyleBackColor = true;
            this.rdoBManufacturer.CheckedChanged += new System.EventHandler(this.Manufacturer_RadioButton_CheckedChanged);
            // 
            // rdoAManufacturer
            // 
            this.rdoAManufacturer.AutoSize = true;
            this.rdoAManufacturer.Font = new System.Drawing.Font("游ゴシック", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rdoAManufacturer.Location = new System.Drawing.Point(24, 73);
            this.rdoAManufacturer.Name = "rdoAManufacturer";
            this.rdoAManufacturer.Size = new System.Drawing.Size(91, 39);
            this.rdoAManufacturer.TabIndex = 0;
            this.rdoAManufacturer.Text = "A社";
            this.rdoAManufacturer.UseVisualStyleBackColor = true;
            this.rdoAManufacturer.CheckedChanged += new System.EventHandler(this.Manufacturer_RadioButton_CheckedChanged);
            // 
            // btnPower
            // 
            this.btnPower.BackColor = System.Drawing.Color.HotPink;
            this.btnPower.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPower.Location = new System.Drawing.Point(26, 212);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(104, 55);
            this.btnPower.TabIndex = 1;
            this.btnPower.Text = "電源";
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOne.Location = new System.Drawing.Point(26, 296);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(104, 56);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnTwo.Location = new System.Drawing.Point(147, 296);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(104, 56);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnThree.Location = new System.Drawing.Point(271, 296);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(104, 56);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(271, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "6";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(147, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 56);
            this.button2.TabIndex = 6;
            this.button2.Text = "5";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(26, 373);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 56);
            this.button3.TabIndex = 5;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(271, 448);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 56);
            this.button4.TabIndex = 10;
            this.button4.Text = "9";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.Location = new System.Drawing.Point(147, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 56);
            this.button5.TabIndex = 9;
            this.button5.Text = "8";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(26, 448);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 56);
            this.button6.TabIndex = 8;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtSendingContent
            // 
            this.txtSendingContent.Font = new System.Drawing.Font("游ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSendingContent.Location = new System.Drawing.Point(26, 625);
            this.txtSendingContent.Name = "txtSendingContent";
            this.txtSendingContent.ReadOnly = true;
            this.txtSendingContent.Size = new System.Drawing.Size(349, 59);
            this.txtSendingContent.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("游ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "送信内容";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(422, 727);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSendingContent);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "リモコンアプリ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAManufacturer;
        private System.Windows.Forms.RadioButton rdoCManufacturer;
        private System.Windows.Forms.RadioButton rdoBManufacturer;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtSendingContent;
        private System.Windows.Forms.Label label1;
    }
}

