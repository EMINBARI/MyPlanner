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

namespace MyPlanner
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            IsVisibleLabel();
            
        }

        private void IsVisibleLabel()
        {
            if (allPlans.Any())
            {
                noTasksLabel.Visibility = Visibility.Visible;

            }
            else
            {
                noTasksLabel.Visibility = Visibility.Hidden;
            }
        }


        //список из текущих планов
        public List<Plan> plansList = new List<Plan>();
        public List<string> allPlans = new List<string>();

        //

        private void addTaskBtn_Click(object sender, RoutedEventArgs e)
        {
            AddTask addTaskWin = new AddTask(this);
            addTaskWin.ShowDialog();

            //обработать исключение
            try
            {
                listBoxMain.Items.Clear();
                foreach(var i in allPlans)
                {
                    listBoxMain.Items.Add(i);
                }
                

            }
            catch (ArgumentOutOfRangeException)
            {

            }
            IsVisibleLabel();

        }

        #region my buttons defenition

        private void weekBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            forwardBtn.Background = (Brush)c.ConvertFrom("#FF608EF1");
        }

        private void weekBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            forwardBtn.Background = (Brush)c.ConvertFrom("#FFCFCFCF");
        }

        private void todayBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            todayBtn.Background = (Brush)c.ConvertFrom("#FF608EF1");
        }

        private void todayBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            todayBtn.Background = (Brush)c.ConvertFrom("#FFCFCFCF");
        }

        private void allPlansBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            allPlansBtn.Background = (Brush)c.ConvertFrom("#FF608EF1");
        }

        private void allPlansBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            var c = new BrushConverter();
            allPlansBtn.Background = (Brush)c.ConvertFrom("#FFCFCFCF");
        }


        #endregion

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int i = listBoxMain.Items.IndexOf(listBoxMain.SelectedItem);
                listBoxMain.Items.RemoveAt(listBoxMain.Items.IndexOf(listBoxMain.SelectedItem));
                allPlans.RemoveAt(i);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Choose what you want to delete!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            

            IsVisibleLabel();
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            int i = listBoxMain.SelectedIndex;
            string str = "";
            try
            {
                str = (string)listBoxMain.Items[i];
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Choose what you want to edit!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            try
            {
                EditWin editWin = new EditWin();

                string[] a = str.Split(' ');
                editWin.Fill(a[0], a[1]);

                editWin.ShowDialog();
                String s = editWin.NameEdit + " " + editWin.DateEdit;

                listBoxMain.Items.RemoveAt(i);
                listBoxMain.Items.Insert(i, s);
            }
            catch (IndexOutOfRangeException)
            {

            }
            

            IsVisibleLabel();


        }
        

        private void todayBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            listBoxMain.Items.Clear();


            foreach(var i in allPlans)
            {
                string[] a = i.Split(' ');
                
                if (DateTime.UtcNow.ToShortDateString() == a[1])
                {
                    //MessageBox.Show("Equal!", "Message", MessageBoxButton.OK);
                    listBoxMain.Items.Add(i);
                }
            }

            if (listBoxMain.Items.Count == 0)
            {
                noTasksLabel.Visibility = Visibility.Visible;
            }
            else
            {
                noTasksLabel.Visibility = Visibility.Hidden;
            }
        }

        private void forwardBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {

            listBoxMain.Items.Clear();


            foreach (var i in allPlans)
            {
                string[] a = i.Split(' ');

                if (DateTime.UtcNow.AddDays(1).ToShortDateString() == a[1])
                {
                    listBoxMain.Items.Add(i);
                }
            }

            if (listBoxMain.Items.Count == 0)
            {
                noTasksLabel.Visibility = Visibility.Visible;
            }
            else
            {
                noTasksLabel.Visibility = Visibility.Hidden;
            }
        }

        private void allPlansBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            listBoxMain.Items.Clear();


            foreach (var i in allPlans)
            {
               listBoxMain.Items.Add(i);
            }

            if (listBoxMain.Items.Count == 0)
            {
                noTasksLabel.Visibility = Visibility.Visible;
            }
            else
            {
                noTasksLabel.Visibility = Visibility.Hidden;
            }
        }
    }

}
