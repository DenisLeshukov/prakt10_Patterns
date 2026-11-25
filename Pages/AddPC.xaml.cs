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
    /// Логика взаимодействия для AddPC.xaml
    /// </summary>
    public partial class AddPC : Page
    {
        public string CPU { get; set; } = "";
        public string GPU { get; set; } = "";
        public int RAM { get; set; } 
        public int Disk { get; set; } 

        public AddPC()
        {
            InitializeComponent();
            
            DataContext = this;
        }
        

        private void Add (object sender, RoutedEventArgs e)
        {
            var pc = new PCBuilder()
                .SetCPU(CPU)
                .SetGPU(GPU)
                .SetRAM(RAM)
                .SetDisk(Disk)
                .Build();
            HomePage.PCs.Add(pc);
            string json = JsonSerializer.Serialize(HomePage.PCs);
            File.WriteAllText("PCList.json", json);
            NavigationService.GoBack();
        }
    }
}
