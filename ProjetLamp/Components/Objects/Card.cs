using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjetLamp.Components.Objects
{
    public class Card
    {
        /// <summary>
        /// Id of the deck list
        /// </summary>
        public string id {  get; set; }

        /// <summary>
        /// Langue
        /// </summary>
        public string lang {  get; set; }

        /// <summary>
        /// Mana Cost
        /// </summary>
        public Decimal cmc {  get; set; }

        /// <summary>
        /// This card’s color identity.
        /// </summary>
        public string[] color_identity { get; set; }

        /// <summary>
        /// The colors in this card’s color indicator, if any. A null value for this field indicates the card does not have one.
        /// </summary>
        public string[] color_indicator { get; set; }

        /// <summary>
        /// This card’s colors, if the overall card has colors defined by the rules. Otherwise the colors will be on the card_faces objects, see below.
        /// </summary>
        public string[] colors {  get; set; }

        /// <summary>
        /// This card’s overall rank/popularity on EDHREC. Not all cards are ranked.
        /// </summary>
        public int edhrec_rank { get; set; }

        /// <summary>
        /// An array of keywords that this card uses, such as 'Flying' and 'Cumulative upkeep'. 
        /// </summary>
        public string[] keywords { get; set; }

        /// <summary>
        /// An object describing the legality of this card across play formats. Possible legalities are legal, not_legal, restricted, and banned. 
        /// </summary>
        public Legalities legalities { get; set; }

        /// <summary>
        /// The mana cost for this card. This value will be any empty string "" if the cost is absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are different values. Multi-faced cards will report this value in card faces. 
        /// </summary>
        public string mana_cost { get; set; }

        /// <summary>
        /// The name of this card. If this card has multiple faces, this field will contain both names separated by ␣//␣. 
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// This card’s power, if any. Note that some cards have powers that are not numeric, such as *. 
        /// </summary>
        public string power { get; set; }

        /// <summary>
        /// This card’s toughness, if any. Note that some cards have toughnesses that are not numeric, such as *. 
        /// </summary>
        public string toughness { get; set; }

        /// <summary>
        /// Colors of mana that this card could produce. 
        /// </summary>
        public string[] produced_mana { get; set; }

        /// <summary>
        /// The type line of this card. 
        /// </summary>
        public string type_line { get; set; }

        /// <summary>
        /// An object containing daily price information for this card, including usd, usd_foil, usd_etched, eur, eur_foil, eur_etched, and tix prices, as strings. 
        /// </summary>
        public Prices prices { get; set; }

        /// <summary>
        /// The localized text printed on this card, if any. 
        /// </summary>
        public string printed_text { get; set; }

        public Image_Uris image_uris { get; set; }
    }
}
