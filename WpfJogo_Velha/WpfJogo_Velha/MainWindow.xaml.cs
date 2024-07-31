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

namespace WpfJogo_Velha
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        int jogada = 0;
        string imagePath = string.Empty;

        private void verificaJogada()
        {
            if(jogada == 0)
            {
                imagePath = "Kitty.jpg";
                jogada = 1;
            }
            else if(jogada == 1)
            {
                imagePath = "Meloy.jpg";
                jogada = 0;
            }
        }

        private void fimJogo()
        {
            if(jogada == 9) 
            {
                MessageBox.Show("Deu Velha");
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void imgA1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();
       
            imgA1.Source = bitmap;
            imgA1.IsEnabled = false;

        }

        private void imgB1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();

            imgB1.Source = bitmap;
            imgB1.IsEnabled = false;
        }

        private void imgC1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();

            imgC1.Source = bitmap;
            imgC1.IsEnabled = false;
        }

        private void imgA2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();

            imgA2.Source = bitmap;
            imgA2.IsEnabled = false;
        }

        private void imgB2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();

            imgB2.Source = bitmap;
            imgB2.IsEnabled = false;
        }

        private void imgC2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();

            imgC2.Source = bitmap;
            imgC2.IsEnabled = false;
        }

        private void imgA3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();

            imgA3.Source = bitmap;
            imgA3.IsEnabled = false;
        }

        private void imgB3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();

            imgB3.Source = bitmap;
            imgB3.IsEnabled = false;
        }

        private void imgC3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            verificaJogada();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.Relative);
            bitmap.EndInit();

            imgC3.Source = bitmap;
            imgC3.IsEnabled = false;
        }

       
       
    }
}
