namespace HotelHW
{
    partial class CardOfClient
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
            this.fullName = new System.Windows.Forms.Label();
            this.BirthDay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AnimalsCheck = new System.Windows.Forms.CheckBox();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fullName.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.Location = new System.Drawing.Point(78, 70);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(50, 30);
            this.fullName.TabIndex = 0;
            this.fullName.Text = "123";
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BirthDay.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDay.Location = new System.Drawing.Point(78, 125);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(50, 30);
            this.BirthDay.TabIndex = 1;
            this.BirthDay.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(183, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество дней";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Карточка гостя";
            // 
            // AnimalsCheck
            // 
            this.AnimalsCheck.AutoSize = true;
            this.AnimalsCheck.Enabled = false;
            this.AnimalsCheck.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnimalsCheck.Location = new System.Drawing.Point(85, 299);
            this.AnimalsCheck.Name = "AnimalsCheck";
            this.AnimalsCheck.Size = new System.Drawing.Size(192, 21);
            this.AnimalsCheck.TabIndex = 6;
            this.AnimalsCheck.Text = "Путешествую с животными";
            this.AnimalsCheck.UseVisualStyleBackColor = true;
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaymentLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaymentLabel.Location = new System.Drawing.Point(78, 188);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(50, 30);
            this.PaymentLabel.TabIndex = 7;
            this.PaymentLabel.Text = "123";
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DaysLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysLabel.Location = new System.Drawing.Point(78, 247);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(50, 30);
            this.DaysLabel.TabIndex = 8;
            this.DaysLabel.Text = "123";
            // 
            // CardOfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.PaymentLabel);
            this.Controls.Add(this.AnimalsCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.fullName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CardOfClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardOfClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AnimalsCheck;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.Label DaysLabel;
    }
}