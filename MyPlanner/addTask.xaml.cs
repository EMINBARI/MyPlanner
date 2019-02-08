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
    /// Логика взаимодействия для addTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        MainWindow mainWindow;
        public AddTask(MainWindow _mainWindow)
        {
            InitializeComponent();
            datePicker.Text = DateTime.Today.ToShortDateString();
            mainWindow = _mainWindow;
        }
       

        #region my buttons defenition


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
        #endregion

        private void CancelBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            
        }
        private Plan nPlan;
        private DateTime chekedDate = DateTime.UtcNow.Date;


        
        private void okBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            nPlan = new Plan();
            
            nPlan.Name = nameTxt.Text;
            nPlan.Date = chekedDate;
           
            if (nameTxt.Text == "")
            {
                MessageBox.Show("Введите название задачи!", "Message", MessageBoxButton.OK);

            }
            else
            {
                mainWindow.plansList.Add(nPlan);
                string tmpS = nameTxt.Text + " " + nPlan.Date.ToShortDateString();
                mainWindow.allPlans.Add(tmpS);

                this.Close();
            }

            
        }
      
    }
}
