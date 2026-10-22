using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建立表單並初始化所有視覺元件。
        public Form1()
        {
            InitializeComponent();
        }

        // 讀取原價與折扣百分比，計算並顯示特價。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 宣告用來儲存原價、折扣百分比與計算結果的變數。
            decimal originalPrice;
            decimal discounPercentage;
            decimal salePrice;

            // 將文字框中的輸入內容轉換為十進位數值。
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discounPercentage = decimal.Parse(discountPercentageTextBox.Text);

            // 依照原價扣除折扣金額，計算商品特價。
            salePrice = originalPrice*(1 - discounPercentage / 100);

            // 將計算結果以貨幣格式顯示在結果標籤中。
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 關閉特價計算器視窗。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.  
            this.Close();
        }
    }
}
