using System;
using System.Collections.Generic;
using System.Text;

namespace testdoma
{
    public class kamion2
    {
        public int maxcarry { get; set; }
        public int maxfuel { get; set; }
        public int consum { get; set; }
        public int distance { get; set; }
        public int curentcarry { get; set; }
        public int curentfuel { get; set; }

        public kamion2()
        {

            maxcarry = 3000;
            curentcarry = 0;
            maxfuel = 300;
            curentfuel = 300;
            distance = 0;
            consum = 0;
        }
        public void loadcargo()
        {
            if (curentcarry==3000)
            {
                curentcarry = 3000;
            }
            else if (curentcarry < 3000)
            {
                curentcarry += 50;
            }
            
        }
        public void unloadcargo()
        {
            if(curentcarry < 0)
            {
                curentcarry = 0;
            }

            
        }
        public void go()
        {
            if (curentfuel == 0)
            {
                distance += 0;
                curentfuel = 0;
            }
            else if (curentfuel < 0)
            {
                distance += 0;
                curentfuel = 0;
            }
            else if (curentcarry > 1500)
            {
                distance += 20;
                curentfuel -= 40;
            }
            else if (curentcarry < 1500)
            {
                distance += 20;
                curentfuel -= 30;
            }
        }
        public void Consum()
        {
            if (curentfuel == 0)
            {
                consum = 0;
            }
            else if (curentcarry > 1500)
            {
                consum = 40;
            }
            else if (curentcarry < 500)
            {
                consum = 30;
            }
        }
        public void Refuel()
        {
            curentfuel += 75;
        }
    }
}
