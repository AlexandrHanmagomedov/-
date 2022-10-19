using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HomeWork6.EnumCard;


namespace HomeWork6 {
    internal class Table {

        List<Card> Deck;
        public int NumberGamers { get; set; }//private set

        List<Gamer> GameTable;

        bool isGameOver = false;

        private void CreateDeck ( ) {
            for ( int i = 0; i < 4; i++ ) {
                for ( int j = 0; j < 9; j++ ) {
                    Deck.Add ( new Card ( ( Suit ) i,
                                          ( Value ) j ) );
                }

            }
        }

        private void ShuffleDeck ( ) {
            Random rand = new Random ( Guid.NewGuid ( ).GetHashCode ( ) );
            int ind, shuffl = 2;
            for ( int j = 0; j < shuffl; j++ ) {
                for ( int i = 0; i < 36; i++ ) {
                    ind = rand.Next ( 0, 36 );
                    Card tempCard = Deck[i];
                    Deck[i] = Deck[ind];
                    Deck[ind] = tempCard;
                }
            }
            
        }


        private void CreateGameTable ( ) {

            ShuffleDeck ( );
            int amountCard = Deck.Count / NumberGamers;
            int indCard = 0;
            for ( int i = 0; i < NumberGamers; i++ ) {
                Queue<Card> set = new Queue<Card> ( amountCard );
                for ( int j = 0; j < amountCard; j++ ) {
                    set.Enqueue ( Deck[indCard++] );
                }
                GameTable.Add ( new Gamer ( set, "Gamer № " + ( i + 1 ).ToString ( ) ) );
            }
        }

        public Table ( int numberGamers ) {
            Deck = new List<Card> ( 36 );
            CreateDeck ( );
            NumberGamers = ( numberGamers < 2 ) ? 2 : numberGamers;
            GameTable = new List<Gamer> ( NumberGamers );
            CreateGameTable ( );
        }

        private void FindBestCard ( out int indGamer ) {
            indGamer = 0;
            for ( int i = 0; i < GameTable.Count; i++ ) {
                if ( GameTable[indGamer].OpenCard ( ).Comparer
                    ( GameTable[i].OpenCard ( ) ) == -1 ) {
                    
                    indGamer = i;//indgamer++
                    
                }
            }
            
        }

        private void Looser ( ) {
            for ( int i = 0; i < GameTable.Count; i++ ) {
                if ( GameTable[i].isLost == true ) {
                    Console.WriteLine ( $" {GameTable[i].Name} is loosser" );
                    GameTable.RemoveAt ( i-- );//GameTable.RemoveAt(i)
                }
            }
            isGameOver=(GameTable.Count == 1);
        }

        public void DeliveryCard ( ) {

            int indGamer;
            while ( !isGameOver ) {
                FindBestCard ( out indGamer );
                for ( int i = 0; i < GameTable.Count; i++ ) {
                    GameTable[indGamer].AddCard ( GameTable[i].OpenCard ( ) );
                    GameTable[i].LostCard ( );
                    GameTable[i].printCard ( );
                    Console.WriteLine ( );
                }
                Looser ( );
            }
            Winner ( );
        }
        private void Winner ( ) {
    
            Console.WriteLine ( $" {GameTable[0].Name} is winner!" );
        }
    }
}
