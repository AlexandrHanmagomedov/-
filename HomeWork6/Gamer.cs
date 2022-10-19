using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6 {
    internal class Gamer:EventArgs {

        Queue<Card> setCards;

        public string Name { get; set; }
        public bool isLost { get; set; }

        public Gamer ( Queue<Card> setCards, string name ) {
            this.setCards = setCards;
            this.Name = name;//Name = name;
            isLost = false;
        }

        public void AddCard ( Card card ) {
            setCards.Enqueue ( card );
            
        }

        public Card OpenCard ( ) {
            return setCards.Peek ();
        }

        public void LostCard ( ) {
            if ( setCards.Count > 1 ) {
                setCards.Dequeue ( );
            }
            else {
                isLost = true;
            }
        }

        public void printCard ( ) {
            Console.WriteLine ( Name );
            foreach ( Card card in setCards ) {
                Console.WriteLine ( $"{( ( Card ) card ).value} " +
                                    $"{( ( Card ) card ).suit}" );
            }
        }
    }
}
