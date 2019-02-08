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
using System.Windows.Shapes;

namespace MyPlanner
{
    /// <summary>
    /// Логика взаимодействия для EditWin.xaml
    /// </summary>
    public partial class EditWin : Window
    {
        public EditWin()
        {
            InitializeComponent();
        }
        

        public String NameEdit
        {
            get { return textbox1.Text; }
            set { textbox1.Text = value; }
        }
        public String DateEdit
        {
            get { return textbox2.Text; }
            set { textbox2.Text = value; }
        }

        public void Fill(String n, String d)
        {
            NameEdit = n;
            DateEdit = d;

        }


        private void CancelBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            CancelBtn.Background = (Brush)c.ConvertFrom("#FFE63030");
        }

        private void CancelBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            CancelBtn.Background = (Brush)c.ConvertFrom("#FFF1F1F1");

        }

        private void okBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            okBtn.Background = (Brush)c.ConvertFrom("#FF22B213");

        }

        private void okBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            okBtn.Background = (Brush)c.ConvertFrom("#FFF1F1F1");

        }

        private void okBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
