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

namespace oldProject
{
    public partial class MainWindow : Window
    {
        List<string> states;
        List<string> actions;
        Father father;

        public MainWindow()
        {
            InitializeComponent();

            states = new List<string>() { "S0", "S1", "S2", "S3" };
            actions = new List<string>()
            {
                "Брать ремень",
                "Ругать сына",
                "Успокаивать сына",
                "Надеяться",
                "Радоваться",
                "Ликовать"
            };

            father = new Father(states, actions);

            labelCurrentState.Content = father.currentState;
            labelCurrentAction.Content = "none";
        }
        private void myGif_MediaEnded(object sender, RoutedEventArgs e)
        {
            y0.Position = new TimeSpan(0, 0, 1);
            y1.Position = new TimeSpan(0, 0, 1);
            y2.Position = new TimeSpan(0, 0, 1);
            y3.Position = new TimeSpan(0, 0, 1);
            y4.Position = new TimeSpan(0, 0, 1);
            y5.Position = new TimeSpan(0, 0, 1);
        }

        private void Click_get2(object sender, RoutedEventArgs e)
        {
            father.setState("2");
            labelCurrentAction.Content = father.currentAction;
            selectAnimation();
        }

        private void Click_get5(object sender, RoutedEventArgs e)
        {
            father.setState("5");
            labelCurrentAction.Content = father.currentAction;
            selectAnimation();
        }

        void selectAnimation()
        {
            labelCurrentState.Content = father.currentState;

            startImg.Visibility = Visibility.Hidden;
            y0.Visibility = Visibility.Hidden;
            y1.Visibility = Visibility.Hidden;
            y2.Visibility = Visibility.Hidden;
            y3.Visibility = Visibility.Hidden;
            y4.Visibility = Visibility.Hidden;
            y5.Visibility = Visibility.Hidden;

            if (father.currentAction.Equals(actions[0])) y0.Visibility = Visibility.Visible;
            if (father.currentAction.Equals(actions[1])) y1.Visibility = Visibility.Visible;
            if (father.currentAction.Equals(actions[2])) y2.Visibility = Visibility.Visible;
            if (father.currentAction.Equals(actions[3])) y3.Visibility = Visibility.Visible;
            if (father.currentAction.Equals(actions[4])) y4.Visibility = Visibility.Visible;
            if (father.currentAction.Equals(actions[5])) y5.Visibility = Visibility.Visible;
        }
    }
}
