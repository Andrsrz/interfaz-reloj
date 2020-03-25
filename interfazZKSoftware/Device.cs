using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// API
using ZKSoftwareAPI;

namespace interfazZKSoftware
{
    public class Device
    {
        public int originalID { get; set; }
        public ZKSoftwareAPI.ZKSoftware originalDevice { get; set; }
        public string originalIP { get; set; }
        public bool originalIsConnected { get; set; }

        public Device(ZKSoftware device, string IP, int ID, bool isConnected)
        {
            originalID = ID;
            originalDevice = device;
            originalIP = IP;
            originalIsConnected = isConnected;
        }
    }
}
