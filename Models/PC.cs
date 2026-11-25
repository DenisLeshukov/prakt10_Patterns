using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt10_Leshukov.Models
{
    public class PC
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int HardDisk { get; set; }
        public PC()
        {

        }
        public PC (string _CPU, string _GPU, int _RAM,int _HardDisk)
        {
            CPU = _CPU;
            GPU = _GPU;
            RAM = _RAM;
            HardDisk = _HardDisk;
        }
    }

}
