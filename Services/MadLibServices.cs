using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveToSeven.Services
{
    public class MadLibServices
    {
        public string madLib = "";

        public string FormMadLib(string place, string adjective, string animal, string adverb, string presentTenseVerb, string humanName, string amount, string itemPlural, string vehicle, string country)
        {
            madLib = "One day you wake up at " + place + " and you see a very " + adjective + " " + animal + "." + " The " + animal + " is " + adverb + " " + presentTenseVerb + " right next to you. Unfortunately you " + humanName + ", is terrified of the " + animal + "." + " All you have are " + amount + " " + itemPlural + " in your pocket. Luckily for you a giant " + vehicle + " arrives " + "and you are taken all the way to " + country + ", where you are no longer afraid.";
            return madLib;
        }
    }
}