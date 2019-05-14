﻿using DesignPatterns.Dinosaur;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodExample2 : FactoryMethodExample
    {
        public override IDinosaur MakeADinosaur()
        {
            return new Stegosaurus();
        }
    }
}
