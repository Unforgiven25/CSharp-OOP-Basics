﻿using System;
using System.Collections.Generic;
using System.Text;


class Cargo
{
    private int cargoWeight;
    private string cargoType;

    public Cargo(int cargoWeight,string cargoType)
    {
        CargoWeight = cargoWeight;
        CargoType = cargoType;
    }
    public int CargoWeight
    {
        get { return cargoWeight; }
        set { cargoWeight = value; }
    }
    public string CargoType
    {
        get { return cargoType; }
        set { cargoType = value; }
    }
}
