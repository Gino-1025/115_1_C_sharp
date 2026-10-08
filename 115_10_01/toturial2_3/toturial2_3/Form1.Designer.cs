namespace toturial2_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.translatrLabel = new System.Windows.Forms.Label();
            this.ItalyLable = new System.Windows.Forms.Label();
            this.SpainLable = new System.Windows.Forms.Label();
            this.GermanyLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(87, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個國家,我告訴你怎說早安";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            // 
            // translatrLabel
            // 
            this.translatrLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translatrLabel.Font = new System.Drawing.Font("Viner Hand ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translatrLabel.Location = new System.Drawing.Point(199, 143);
            this.translatrLabel.Name = "translatrLabel";
            this.translatrLabel.Size = new System.Drawing.Size(454, 83);
            this.translatrLabel.TabIndex = 2;
            this.translatrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItalyLable
            // 
            this.ItalyLable.AutoSize = true;
            this.ItalyLable.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItalyLable.Location = new System.Drawing.Point(42, 266);
            this.ItalyLable.Name = "ItalyLable";
            this.ItalyLable.Size = new System.Drawing.Size(205, 60);
            this.ItalyLable.TabIndex = 3;
            this.ItalyLable.Text = "義大利";
            this.ItalyLable.Click += new System.EventHandler(this.ItalyLable_Click);
            // 
            // SpainLable
            // 
            this.SpainLable.AutoSize = true;
            this.SpainLable.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SpainLable.Location = new System.Drawing.Point(290, 266);
            this.SpainLable.Name = "SpainLable";
            this.SpainLable.Size = new System.Drawing.Size(205, 60);
            this.SpainLable.TabIndex = 4;
            this.SpainLable.Text = "西班牙";
            this.SpainLable.Click += new System.EventHandler(this.label4_Click);
            // 
            // GermanyLable
            // 
            this.GermanyLable.AutoSize = true;
            this.GermanyLable.Font = new System.Drawing.Font("新細明體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GermanyLable.Location = new System.Drawing.Point(564, 266);
            this.GermanyLable.Name = "GermanyLable";
            this.GermanyLable.Size = new System.Drawing.Size(145, 60);
            this.GermanyLable.TabIndex = 5;
            this.GermanyLable.Text = "德國";
            this.GermanyLable.Click += new System.EventHandler(this.GermanyLable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GermanyLable);
            this.Controls.Add(this.SpainLable);
            this.Controls.Add(this.ItalyLable);
            this.Controls.Add(this.translatrLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label translatrLabel;
        private System.Windows.Forms.Label ItalyLable;
        private System.Windows.Forms.Label SpainLable;
        private System.Windows.Forms.Label GermanyLable;
    }
}

