using Mcs.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcs.ControlMaster {
    public class HostTransportCommand : JsonMessage {
        public string PropertyOne { get; set; }
        public int PropertyTwo { get; set; }
    }
}
