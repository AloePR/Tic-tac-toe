using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Crestic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        players gameplayer;

        private List<Button> battons;

        enum players
        {
            crestic,
            nolik

        }

        public MainWindow()
        {

            InitializeComponent();
            this.Height = 700;
            this.Width = 900;
            gameplayer = players.crestic;

        }



        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            sender.GetType().GetProperty("Content").SetValue(sender, "crestic");
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);

            Bot();
            /*switch (gameplayer)
            {
                case players.crestic:
                    
                    break;
                case players.nolik:
                    sender.GetType().GetProperty("Content").SetValue(sender, "nolik");
                    gameplayer = players.crestic;

                    break;

            }*/
            Win();
        }
        private void Win()

        {
            if (button1.Content != "" && button2.Content != "" && button3.Content != "" && button4.Content != "" && button5.Content != "" && button6.Content != "" && button7.Content != "" && button8.Content != "" && button9.Content != "")
            {
                MessageBox.Show("Ничья");
            }
            if (button1.Content == button2.Content  && button2.Content == button3.Content)
            {
                if (button1.Content != "")
                {
                    MessageBox.Show("Игра закончена");
                foreach (Button a in battons)
                {
                    a.IsEnabled = false;
                }

                }


            }
            else if (button4.Content == button5.Content && button5.Content == button6.Content)
            {
                if (button4.Content != "")
                {
                    MessageBox.Show("Игра закончена");
                foreach (Button a in battons)
                {
                    a.IsEnabled = false;
                }

                }
            }
            else if (button7.Content ==  button8.Content  && button8.Content == button9.Content)
            {
                if (button7.Content != "")
                {
                    MessageBox.Show("Игра закончена");
                foreach (Button a in battons)
                {
                    a.IsEnabled = false;
                }

                }

            }
            else if (button1.Content ==  button4.Content  && button4.Content == button7.Content)
            {
                if (button1.Content != "")
                {

                    MessageBox.Show("Игра закончена");
                foreach (Button a in battons)
                {
                    a.IsEnabled = false;
                }
                }

            }
            else if (button2.Content == button5.Content && button5.Content == button8.Content)
            {
                if (button2.Content != "")
                {

                    MessageBox.Show("Игра закончена");
                foreach (Button a in battons)
                {
                    a.IsEnabled = false;
                }
                }

            }
            else if (button3.Content ==  button6.Content && button6.Content == button9.Content)
            {
                if (button3.Content != "")
                {
                    MessageBox.Show("Игра закончена");
                foreach (Button a in battons)
                {

                    a.IsEnabled = false;
                }
                }

            }
            else if (button1.Content == button5.Content && button5.Content == button9.Content)
            {
                if (button1.Content != "")
                {

                    MessageBox.Show("Игра закончена");
                foreach (Button a in battons)
                {
                    a.IsEnabled = false;
                }

                }
            }
            else if (button3.Content == button5.Content && button5.Content == button7.Content)
            {
                if (button3.Content != "")
                {

                    MessageBox.Show("Игра закончена");
                foreach (Button a in battons)
                {
                    a.IsEnabled = false;
                }
                }




            }
            



        }

         void button10_Click(object sender, RoutedEventArgs e)
        {
            battons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            foreach (Button b in battons)
            {
                b.IsEnabled = true;
                b.Content = "";
            }
            if (gameplayer == players.nolik)
            {
                Bot();
            }
        }
        private void Bot()
        {
            int a;
            do
            {
                a = random.Next(battons.Count);
            } while (battons[a].IsEnabled == false && battons.Any(x => x.IsEnabled == true));

            battons[a].IsEnabled = false;
            battons[a].Content = players.nolik.ToString();
            battons.RemoveAt(a);

            Win();
        }


    }
}
