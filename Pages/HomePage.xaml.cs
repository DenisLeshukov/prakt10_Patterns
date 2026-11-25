using prakt10_Leshukov.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage :Page
    {
        public PC selectedPC { get; set; }
        public static ObservableCollection<PC> PCs { get; set; } = new();

        public HomePage ()
        {
            InitializeComponent( );
           
            if (File.Exists("PCList.json"))
            {
                string json = File.ReadAllText("PCList.json");
                PCs = JsonSerializer.Deserialize<ObservableCollection<PC>>(json);

               
            }
            DataContext = this;
        }

        private void GoToAdd (object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate( new AddPC());
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            var copyPC = new PCBuilder()
                .SetCPU(selectedPC.CPU)
                .SetGPU(selectedPC.GPU)
                .SetRAM(selectedPC.RAM)
                .SetDisk(selectedPC.HardDisk)
                .Clone()
                .Build();
            PCs.Add(copyPC);
            string json = JsonSerializer.Serialize(PCs);
            File.WriteAllText("PCList.json", json);
           
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            if (selectedPC == null)
            {
                MessageBox.Show("Выберите одну из сборок");
                return;
            }
            NavigationService.Navigate(new EditPC(selectedPC));
        }
    }
}
