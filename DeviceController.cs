using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_quiz_2
{
    public class DeviceController : IDevice
    {
        public string DeviceType;

        public DeviceController(string deviceType)
        {
            DeviceType = deviceType;
        }
        public void Activate()
        {
            Console.WriteLine($"This {DeviceType} is active");
        }
    }
}
