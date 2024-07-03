using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLamp.Components.Objects
{
    public class ManaColor
    {
        public ManaColor(int w, int k, int g, int r, int b)
        {
            this.w = w;
            this.k = k;
            this.g = g;
            this.r = r;
            this.b = b;
        }
        /// <summary>
        /// White
        /// </summary>
        private readonly int w;
        /// <summary>
        /// Black
        /// </summary>
        private readonly int k;
        /// <summary>
        /// Green
        /// </summary>
        private readonly int g;
        /// <summary>
        /// Red
        /// </summary>
        private readonly int r;
        /// <summary>
        /// Blue
        /// </summary>
        private readonly int b;

        /// <summary>
        /// Get Color Sum
        /// </summary>
        public string GetColorMix => w + "-" + k + "-" + g + "-" + r + "-" + b; 
    }
}
