﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectLibrary
{
    public class Facilities
    {
        public int HotelNr { get; set; }
        public bool Swimmingpool { get; set; }
        public bool Tabletennis { get; set; }
        public bool Pooltable { get; set; }
        public bool Bar { get; set; }

        public Facilities()
        {

        }

        public override string ToString()
        {
            return $"Hotel_No: {HotelNr},\t Swimmingpool: {Swimmingpool},\t Tabletennis: {Tabletennis},\t Pooltable: {Pooltable},\t Bar: {Bar}";
        }
    }
}
