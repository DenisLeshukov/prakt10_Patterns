using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt10_Leshukov.Models
{
    public class PC
    {
        public string CPU { get; }
        public string GPU { get;  }
        public int RAM { get;  }
        public int HardDisk { get; }
        public PC (string _CPU, string _GPU, int _RAM,int _HardDisk)
        {
            CPU = _CPU;
            GPU = _GPU;
            RAM = _RAM;
            HardDisk = _HardDisk;
        }
    }
 
    public class PCBuilder
    {
        private string _CPU = string.Empty;
        private string _GPU = string.Empty;
        private int _RAM = 0;
        private int _HardDisk = 0;

        public PCBuilder SetCPU (string _cpu)
        {
            _CPU = _cpu;
            return this;
            
        }public PCBuilder SetGPU (string _gpu)
        {
            _GPU = _gpu;
            return this;

        }
        public PCBuilder SetRAM (int _ram)
        {
            _RAM = _ram;
            return this;

        }
        public PCBuilder SetDisk (int _disk)
        {
            _HardDisk = _disk;
            return this;

        }
        public PCBuilder Clone ()
        {
            return new PCBuilder()
                .SetCPU(_CPU)
                .SetGPU(_GPU)
                .SetRAM(_RAM)
                .SetDisk(_HardDisk);
        }
        public PC Build ()
        {
            return new PC(_CPU, _GPU, _RAM, _HardDisk);
        }
    }

}
