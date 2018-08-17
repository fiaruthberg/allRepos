using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp.Domain
{
    public class Elevator
    {
        public string name { get; set; }
        public int lowestFloor { get; set; }
        public int highestFloor { get; set; }
        public int currentFloor { get; set; }
        public int timeUntilMaintenance { get; set; }
        public string onOrOff
        {
            get
            {
                if (timeUntilMaintenance > 0)
                    return "på";

                    return "av";
            }
        }

        public Elevator(string a, int b, int c, int d, int e)
        {
            name = a;
            lowestFloor = b;
            highestFloor = c;
            currentFloor = d;
            timeUntilMaintenance = e;
        }
        public Elevator(string a, int b, int c)
        {
            name = a;
            lowestFloor = b;
            highestFloor = c;
            currentFloor = 5;
            timeUntilMaintenance = 10;
        }

        public void GoUp()
        {
            if (timeUntilMaintenance > 0)
            {
                if (currentFloor < highestFloor)
                {
                    currentFloor++;
                    timeUntilMaintenance--;
                }
            }
        }


        public string Report()
        {
            return $"Hissen {name} är på våning {currentFloor}. Hissen är {onOrOff}. Tills underhåll: {timeUntilMaintenance}";
        }

        public void GoDown()
        {
            if (timeUntilMaintenance > 0)
            {
                if (currentFloor > lowestFloor)
                {
                    currentFloor--;
                    timeUntilMaintenance--;
                }
            }
            
        }

    }
}
