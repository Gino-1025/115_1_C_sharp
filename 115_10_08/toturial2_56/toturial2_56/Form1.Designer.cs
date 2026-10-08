namespace toturial2_56
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FacepictureBox = new System.Windows.Forms.PictureBox();
            this.BackpictureBox = new System.Windows.Forms.PictureBox();
            this.showFaceButton = new System.Windows.Forms.Button();
            this.showBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FacepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FacepictureBox
            // 
            this.FacepictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FacepictureBox.Image")));
            this.FacepictureBox.Location = new System.Drawing.Point(539, 56);
            this.FacepictureBox.Name = "FacepictureBox";
            this.FacepictureBox.Size = new System.Drawing.Size(184, 263);
            this.FacepictureBox.TabIndex = 0;
            this.FacepictureBox.TabStop = false;
            // 
            // BackpictureBox
            // 
            this.BackpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BackpictureBox.Image")));
            this.BackpictureBox.Location = new System.Drawing.Point(164, 56);
            this.BackpictureBox.Name = "BackpictureBox";
            this.BackpictureBox.Size = new System.Drawing.Size(184, 263);
            this.BackpictureBox.TabIndex = 1;
            this.BackpictureBox.TabStop = false;
            // 
            // showFaceButton
            // 
            this.showFaceButton.Location = new System.Drawing.Point(575, 346);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(113, 47);
            this.showFaceButton.TabIndex = 2;
            this.showFaceButton.Text = "顯示正面";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // showBackButton
            // 
            this.showBackButton.Location = new System.Drawing.Point(209, 346);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(128, 47);
            this.showBackButton.TabIndex = 3;
            this.showBackButton.Text = "顯示背面";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.BackpictureBox);
            this.Controls.Add(this.FacepictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FacepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox FacepictureBox;
        private System.Windows.Forms.PictureBox BackpictureBox;
        private System.Windows.Forms.Button showFaceButton;
        private System.Windows.Forms.Button showBackButton;
    }
}

