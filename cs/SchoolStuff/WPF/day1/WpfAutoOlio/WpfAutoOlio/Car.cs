using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAutoOlio
{
    public class Car
    {
        public string Color { get; set; }
        public int MaxSpeed
        {
            get
            {
                return maxSpeed;
            }
            set
            {
                if ((value > 0) && (value <= 400))
                {
                    maxSpeed = value;
                }
                else
                {
                    maxSpeed = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private int maxSpeed;
        public Boolean Running { get; set; }
        public string Modle { get; set; }
        public int CurrentSpeed { get; set; }
        public int HorsePower { get; set; }
        public string TransMission { get; set; }
        public int GearCount
        {
            get
            {
                return GearCount;
            }
            set
            {
                if ((value > 0) && (value <= 400))
                {
                    GearCount = value;
                }
                else
                {
                    GearCount = 0;
                    throw new ArgumentOutOfRangeException();
                }
            }
        }


        public void StartEngine()
        {
            Running = true;
        }

        public void StopEngine()
        {
            Running = false;
        }
    }

}
