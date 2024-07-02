using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLamp.Components.Objects
{
    public class DeckEDH
    {
        public DeckEDH(string name,
                       List<Card> commander,
                       string description) 
        { 
            Name = name;
            Commander = commander;
            Description = description;
            KeyWords = new List<string>();
            Size = 100;
        }

        /// <summary>
        /// Deck list's name
        /// </summary>
        private string Name { get; set; }
        public string GetName => Name;

        /// <summary>
        /// Commander of the deck (could be dual)
        /// </summary>
        private List<Card> Commander {  get; set; }
        public List<Card> GetCommander => Commander;
        
        /// <summary>
        /// Description of the deck and his playstyle/objectives
        /// </summary>
        private string Description { get; set; }
        public string GetDescription => Description;

        /// <summary>
        /// Deck list importants keywords and mechanics
        /// </summary>
        private List<string> KeyWords { get; set; }
        public List<string> GetKeyWords => KeyWords;

        /// <summary>
        /// Defauld card size of the deck (100 in EDH format)
        /// </summary>
        private int Size { get; set; }
        public int GetSize => Size;
    }
}
