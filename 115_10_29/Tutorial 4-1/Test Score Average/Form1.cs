using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化表單上的所有控制項與介面設定。
            InitializeComponent();
        }

        /// <summary>
        /// 讀取三次測驗成績、計算平均值，並顯示計算結果。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 設定及格與高分門檻，分數低於及格門檻時顯示不及格。
            const double PASSING_SCORE = 60;
            const double HIGH_SCORE = 95;

            double test1, test2, test3, average;

            try
                {
                // 從三個文字方塊讀取測驗成績。
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);
                // 計算三次測驗成績的平均值。
                average = (test1 + test2 + test3) / 3.0;
                // 將平均成績顯示在結果標籤中，並格式化為小數點後一位。
                averageLabel.Text = average.ToString("F1");
                // 平均成績低於 60 時顯示不及格訊息。
                if (average < PASSING_SCORE)
                {
                    MessageBox.Show("平均成績低於 60.0，結果為不及格。", "成績結果");
                }
                else if (average >= HIGH_SCORE)
                {
                    MessageBox.Show("恭喜您獲得高分！", "成績結果");
                }
                else
                {
                    // 平均成績達到及格門檻但未達高分門檻時，顯示及格訊息。
                    MessageBox.Show("平均成績達到 60.0，結果為及格。", "成績結果");
                }
            }
            catch (Exception ex)
            {
                // 輸入數值超出 double 可表示的範圍時，顯示錯誤訊息。
                MessageBox.Show(ex.Message, "輸入錯誤",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 清除所有測驗成績與平均成績，並將焦點移回第一個輸入欄位。
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除三個文字方塊與平均成績標籤的內容。
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            // 清除後將輸入焦點移回第一次測驗成績欄位。
            test1TextBox.Focus();
        }

        /// <summary>
        /// 關閉測驗成績平均值表單。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前的表單。
            this.Close();
        }
    }
}
