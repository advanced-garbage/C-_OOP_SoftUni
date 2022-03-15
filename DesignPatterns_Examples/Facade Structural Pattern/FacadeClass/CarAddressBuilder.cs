﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.FacadeClass
{
    public class CarAddressBuilder : CarBuilderFacade
    {
        public CarAddressBuilder(Car car) : base() {
            this.Car = car;
        }

        public CarAddressBuilder WithCity(string city)
        {
            Car.City = city;
            return this;
        }

        public CarAddressBuilder WithAddress(string address)
        {
            Car.Address = address;
            return this;
        }
    }
}
