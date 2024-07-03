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
        public Card(string lang, decimal cmc, ManaColor color_identity, ManaColor color_indicator, ManaColor colors, int edhrec_rank, Array keywords, object legalities, string mana_cost, string name, string power, string toughness, object prices)
        {
            Lang = lang;
            Cmc = cmc;
            Color_identity = color_identity;
            Color_indicator = color_indicator;
            Colors = colors;
            Edhrec_rank = edhrec_rank;
            Keywords = keywords;
            Legalities = legalities;
            Mana_cost = mana_cost;
            Name = name;
            Power = power;
            Toughness = toughness;
            Prices = prices;
        }

        /// <summary>
        /// Id of the deck list
        /// </summary>
        private int DeckId {  get; set; }
        public int GetDeckId => DeckId;

        /// <summary>
        /// Langue
        /// </summary>
        private string Lang {  get; set; }
        public string GetLang => Lang;

        /// <summary>
        /// Mana Cost
        /// </summary>
        private Decimal Cmc {  get; set; }
        public Decimal GetCmc => Cmc;

        /// <summary>
        /// This card’s color identity.
        /// </summary>
        private ManaColor Color_identity { get; set; }
        public ManaColor GetColorIdentity => Color_identity;

        /// <summary>
        /// The colors in this card’s color indicator, if any. A null value for this field indicates the card does not have one.
        /// </summary>
        private ManaColor Color_indicator { get; set; }
        public ManaColor GetColorIndicator => Color_indicator;

        /// <summary>
        /// This card’s colors, if the overall card has colors defined by the rules. Otherwise the colors will be on the card_faces objects, see below.
        /// </summary>
        private ManaColor Colors {  get; set; }
        public ManaColor GetColors => Colors;

        /// <summary>
        /// This card’s overall rank/popularity on EDHREC. Not all cards are ranked.
        /// </summary>
        private int Edhrec_rank { get; set; }
        public int GetEdhrecRank => Edhrec_rank;

        /// <summary>
        /// An array of keywords that this card uses, such as 'Flying' and 'Cumulative upkeep'. 
        /// </summary>
        private Array Keywords { get; set; }
        public Array GetKeywords => Keywords;

        /// <summary>
        /// An object describing the legality of this card across play formats. Possible legalities are legal, not_legal, restricted, and banned. 
        /// </summary>
        private object Legalities { get; set; }
        public object GetLegalities => Legalities;

        /// <summary>
        /// The mana cost for this card. This value will be any empty string "" if the cost is absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are different values. Multi-faced cards will report this value in card faces. 
        /// </summary>
        private string Mana_cost { get; set; }
        public string GetManaCost => Mana_cost;

        /// <summary>
        /// The name of this card. If this card has multiple faces, this field will contain both names separated by ␣//␣. 
        /// </summary>
        private string Name { get; set; }
        public string GetName => Name;

        /// <summary>
        /// This card’s power, if any. Note that some cards have powers that are not numeric, such as *. 
        /// </summary>
        private string Power { get; set; }
        public string GetPower => Power;

        /// <summary>
        /// This card’s toughness, if any. Note that some cards have toughnesses that are not numeric, such as *. 
        /// </summary>
        private string Toughness { get; set; }
        public string GetToughness => Toughness;

        /// <summary>
        /// Colors of mana that this card could produce. 
        /// </summary>
        private ManaColor Produced_mana { get; set; }
        public ManaColor GetProducedMana => Produced_mana;

        /// <summary>
        /// The type line of this card. 
        /// </summary>
        private string Type_line { get; set; }
        public string GetTypeLine => Type_line;

        /// <summary>
        /// An object containing daily price information for this card, including usd, usd_foil, usd_etched, eur, eur_foil, eur_etched, and tix prices, as strings. 
        /// </summary>
        private object Prices { get; set; }
        public object GetPrices => Prices;

        /// <summary>
        /// The localized text printed on this card, if any. 
        /// </summary>
        private string Printed_text { get; set; }
        public string GetPrintedText => Printed_text;
    }
}
