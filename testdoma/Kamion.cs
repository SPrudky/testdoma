using System;
using System.Collections.Generic;
using System.Text;

namespace testdoma
{
    public class Kamion
    {
        public int maxcarry { get; set; }
        public int maxfuel { get; set; }
        public int consum { get; set; }
        public int distance { get; set; }
        public int curentcarry { get; set; }
        public int curentfuel { get; set; }

        public Kamion()
        {
            maxcarry = 2000;
            curentcarry = 0;
            maxfuel = 250;
            curentfuel = 250;
            distance = 0;
            consum = 0;
        }
        public void Loadcargo()
        {
            if (curentcarry == 2000)
            {
                curentcarry = 2000;
            }
            else if (curentcarry < 2000)
            {
                curentcarry += 50;
            }
            
        }
        public void Unloadcargo()
        {
            if (curentcarry == 0)
            {
                curentcarry = 0;
            }
            else if (curentcarry > 0)
            {
                curentcarry = 0;
            }
        }
        public void Go()
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
            else if (curentcarry > 500)
            {
                curentfuel -= 30;
                distance += 20;
            }
            else if (curentcarry < 500)
            {
                curentfuel -= 20;
                distance += 20;
            }

            
        }
        public void Consum()
        {
            if (curentfuel == 0)
            {
                consum = 0;
            }
            else if (curentcarry > 500)
            {
                consum = 30;
            }
            else if (curentcarry<500)
            {
                consum = 20;
            }
        } 
        public void Refuel()
        {
            curentfuel += 50;
            if (curentfuel > 250)
            {
                curentfuel = 250;
            }
        }
    }
}
