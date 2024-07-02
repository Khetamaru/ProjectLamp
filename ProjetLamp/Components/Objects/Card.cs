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
            this.lang = lang;
            this.cmc = cmc;
            this.color_identity = color_identity;
            this.color_indicator = color_indicator;
            this.colors = colors;
            this.edhrec_rank = edhrec_rank;
            this.keywords = keywords;
            this.legalities = legalities;
            this.mana_cost = mana_cost;
            this.name = name;
            this.power = power;
            this.toughness = toughness;
            this.prices = prices;
        }

        /// <summary>
        /// Id of the deck list
        /// </summary>
        private int deckId {  get; set; }
        public int GetDeckId => deckId;

        /// <summary>
        /// Langue
        /// </summary>
        private string lang {  get; set; }
        public string GetLang => lang;

        /// <summary>
        /// Mana Cost
        /// </summary>
        private Decimal cmc {  get; set; }
        public Decimal GetCmc => cmc;

        /// <summary>
        /// This card’s color identity.
        /// </summary>
        private ManaColor color_identity { get; set; }
        public ManaColor GetColorIdentity => color_identity;

        /// <summary>
        /// The colors in this card’s color indicator, if any. A null value for this field indicates the card does not have one.
        /// </summary>
        private ManaColor color_indicator { get; set; }
        public ManaColor GetColorIndicator => color_indicator;

        /// <summary>
        /// This card’s colors, if the overall card has colors defined by the rules. Otherwise the colors will be on the card_faces objects, see below.
        /// </summary>
        private ManaColor colors {  get; set; }
        public ManaColor GetColors => colors;

        /// <summary>
        /// This card’s overall rank/popularity on EDHREC. Not all cards are ranked.
        /// </summary>
        private int edhrec_rank { get; set; }
        public int GetEdhrecRank => edhrec_rank;

        /// <summary>
        /// An array of keywords that this card uses, such as 'Flying' and 'Cumulative upkeep'. 
        /// </summary>
        private Array keywords { get; set; }
        public Array GetKeywords => keywords;

        /// <summary>
        /// An object describing the legality of this card across play formats. Possible legalities are legal, not_legal, restricted, and banned. 
        /// </summary>
        private object legalities { get; set; }
        public object GetLegalities => legalities;

        /// <summary>
        /// The mana cost for this card. This value will be any empty string "" if the cost is absent. Remember that per the game rules, a missing mana cost and a mana cost of {0} are different values. Multi-faced cards will report this value in card faces. 
        /// </summary>
        private string mana_cost { get; set; }
        public string GetManaCost => mana_cost;

        /// <summary>
        /// The name of this card. If this card has multiple faces, this field will contain both names separated by ␣//␣. 
        /// </summary>
        private string name { get; set; }
        public string GetName => name;

        /// <summary>
        /// This card’s power, if any. Note that some cards have powers that are not numeric, such as *. 
        /// </summary>
        private string power { get; set; }
        public string GetPower => power;

        /// <summary>
        /// This card’s toughness, if any. Note that some cards have toughnesses that are not numeric, such as *. 
        /// </summary>
        private string toughness { get; set; }
        public string GetToughness => toughness;

        /// <summary>
        /// Colors of mana that this card could produce. 
        /// </summary>
        private ManaColor produced_mana { get; set; }
        public ManaColor GetProducedMana => produced_mana;

        /// <summary>
        /// The type line of this card. 
        /// </summary>
        private string type_line { get; set; }
        public string GetTypeLine => type_line;

        /// <summary>
        /// An object containing daily price information for this card, including usd, usd_foil, usd_etched, eur, eur_foil, eur_etched, and tix prices, as strings. 
        /// </summary>
        private object prices { get; set; }
        public object GetPrices => prices;

        /// <summary>
        /// The localized text printed on this card, if any. 
        /// </summary>
        private string printed_text { get; set; }
        public string GetPrintedText => printed_text;
    }
}
