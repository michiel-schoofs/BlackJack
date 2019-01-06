using System.Collections.Generic;
using BlackJackConsole.Models;

namespace BlackJackConsole.tests.Models.DeckStubs {
    class PlayerWinsDealerBurnsDeck : Deck {

        public PlayerWinsDealerBurnsDeck() {
            _cards = new List<BlackJackCard>
            {
                //dealer
                new BlackJackCard(Suit.Clubs, FaceValue.Seven),
                new BlackJackCard(Suit.Clubs, FaceValue.Seven),
            
                //player
                new BlackJackCard(Suit.Clubs, FaceValue.Nine),
                new BlackJackCard(Suit.Clubs, FaceValue.Nine),

                //dealer
                new BlackJackCard(Suit.Clubs, FaceValue.Ten),
            };
        }
    }
}
