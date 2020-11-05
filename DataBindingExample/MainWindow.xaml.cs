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

namespace DataBindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Evento evento;
        public MainWindow()
        {
            InitializeComponent();
            evento = new Evento()
            {
                Title = "Reunión de trabajo",
                Date = new DateTime(2020, 10, 23)
            };
            txtbxnombre.Text = evento.Title;
            datepickfecha.SelectedDate = evento.Date;
            DataContext = evento;


        }

        private void btnmodificar_Click(object sender, RoutedEventArgs e)
        {
            evento.Title = evento.Title.ToLower();
            evento.Date = evento.Date.AddDays(1);
            txtbxnombre.Text = evento.Title;
            datepickfecha.SelectedDate = evento.Date;
            MessageBox.Show(evento.Title + "\n" + evento.Date);
        }
    }
}
