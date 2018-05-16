using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace notebook
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生處存檔案的視窗
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            //當按下儲存之後的反應
            if (result == true)
            {
                Textarea.Text = System.IO.File.ReadAllText(dlg.FileName);
            }
        }

        private void SaveasBtn_Click(object sender, RoutedEventArgs e)
        { 
            // 產生處存檔案的視窗
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下儲存之後的反應
            if (result == true)
            {
                // 寫入檔案
                System.IO.File.WriteAllText(dlg.FileName, Textarea.Text);
            }
           
            // 存檔
        }


        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // 直接儲存檔案到c:\temp\aaatxt
            System.IO.File.WriteAllText(@"C:\temp\aaa.txt", Textarea.Text);
        }

        
        private void BigBtn_Click_1(object sender, RoutedEventArgs e)
        {
            // 把texbox裡的字改變成25大小
            Textarea.FontSize = 25;
        }

        private void MiddleBtn_Click(object sender, RoutedEventArgs e)
        {
            // 把texbox裡的字改變成20大小
            Textarea.FontSize = 20;
        }

        private void SmallBtn_Click(object sender, RoutedEventArgs e)
        {
            // 把texbox裡的字改變成15大小
            Textarea.FontSize = 15;
        }

        private void WhiteBtn_Click(object sender, RoutedEventArgs e)
        {
            // 把texbox裡的背景改變成白色
            Textarea.Background = Brushes.White;
        }

        private void BlackBtn_Click(object sender, RoutedEventArgs e)
        {
            // 把texbox裡的背景改變成黑色
            Textarea.Background = Brushes.Black;
        }
    }
}
