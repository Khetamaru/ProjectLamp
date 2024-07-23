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
        public string searchtext = "";

        public void search()
        {
            card = new ScryfallCaller().GetCall<Card>("cards/named?fuzzy=" + searchtext.Replace(" ", "+"));
        }

        public string cardUri => card != null ? card.image_uris.normal : "https://t3.ftcdn.net/jpg/05/62/05/20/360_F_562052065_yk3KPuruq10oyfeu5jniLTS4I2ky3bYX.jpg";
    }
}