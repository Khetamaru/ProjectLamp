using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLamp.Components.Toolbox
{
    public class ScryfallCaller : APICaller
    {
        public ScryfallCaller() : base("https://api.scryfall.com/", true) 
        { 
        }
    }
}
