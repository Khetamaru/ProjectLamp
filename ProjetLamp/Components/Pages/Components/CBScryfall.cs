using Microsoft.AspNetCore.Components;
using ProjetLamp.Components.Objects;
using ProjetLamp.Components.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLamp.Components.Pages.Components
{
    public class CBScryfall : ComponentBase
    {
        public Card card = new ScryfallCaller().GetCall<Card>("cards/named?fuzzy=aust+com");
    }
}