using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWork6.EnumCard;


namespace HomeWork6 {
    internal class Card {
        public Suit suit {get;set;}
        public Value value { get;set;}

        public Card ( Suit suit, Value value ) {
            this.suit = suit;
            this.value = value;
        }

        public int Comparer ( Card card ) {
            return value > card.value ? 1 : ( ( value < card.value ) ? -1 : 0 );
        }




    }
}
