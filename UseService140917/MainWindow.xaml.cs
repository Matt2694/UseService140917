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

namespace UseService140917
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window_Loaded);
        }

        private PersonService.PersonWcfServiceClient _service = new PersonService.PersonWcfServiceClient();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PersonService.PersonDTO[] _personer = _service.GetAllePersoner();
            foreach(PersonService.PersonDTO person in _personer)
            {
                list1.Items.Add("Address: " + person.Adresse + "\t" + "District: " + person.Distrikt + "\t" + "Last Name: " + person.Efternavn + "\t" + "First Name: " + person.Fornavn + "\t" + "Person Number: " + person.Personnr + "\t" + "Post Number: " + person.Postnr + "\t" + "Telephone Number: " + person.Tlfnr + "\t" + "Version: " + person.Version);
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
