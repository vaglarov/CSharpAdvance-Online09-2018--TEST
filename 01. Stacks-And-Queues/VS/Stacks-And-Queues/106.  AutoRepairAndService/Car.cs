namespace _106.__AutoRepairAndService
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Car
    {
        public Car(string name,bool isServised=false)
        {
            this.CarName = name;
            this.IsServised = false;
        }
        public string CarName { get; set; }

        public bool IsServised { get; set; }


    }
}
