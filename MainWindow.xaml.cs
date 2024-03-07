using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nepesseg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Orszag> orszagok = new ObservableCollection<Orszag>();

        public MainWindow()
        {
            InitializeComponent();
            CreateList();
            dtgAdatok.ItemsSource = orszagok;
        }
        public void CreateList()
        {
            var sorok = File.ReadAllLines("adatok-utf8.txt").ToList();
            sorok.RemoveAt(0);
            foreach (var sor in sorok)
            {
                orszagok.Add(new Orszag(sor));
            }
        }
    }
}
