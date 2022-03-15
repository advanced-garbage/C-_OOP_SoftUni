using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.FacadeClass
{
    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car) : base() {
            this.Car = car;
        }

        public CarInfoBuilder WithType(string type)
        {
            Car.Type = type;
            return this;
        }

        public CarInfoBuilder WithColor(string color)
        {
            Car.Color = color; 
            return this;
        }

        public CarInfoBuilder WithNumOfDoors(int num)
        {
            Car.NumOfDoors = num;
            return this;
        }
    }
}
