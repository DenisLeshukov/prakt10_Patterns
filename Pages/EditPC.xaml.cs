using prakt10_Leshukov.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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

namespace prakt10_Leshukov.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditPC.xaml
    /// </summary>
    public partial class EditPC : Page
    {
        public PC PC = new PC();
        public EditPC(PC selectedPc)
        {
            InitializeComponent();
            PC = selectedPc;
            DataContext = PC;
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
           
            string json = JsonSerializer.Serialize(HomePage.PCs);
            File.WriteAllText("PCList.json", json);
            NavigationService.GoBack();
        }
    }
}
