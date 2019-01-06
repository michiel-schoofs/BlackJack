using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackConsole.Models {
    class BlackJack {
        public const bool FaceDown = false;
        public const bool FaceUp = true;
        private Deck _deck;  

        public Hand DealerHand { get; set; }
        public Hand PlayerHand { get; set; }

        public BlackJack() {
            throw new NotImplementedException();
        }

        public BlackJack(Deck deck) {
            throw new NotImplementedException();
        }

        private void Deal() {
            throw new NotImplementedException();
        }

        public string GameSummary() {
            throw new NotImplementedException();
        }

        public void GivePlayerAnotherCard() {
            throw new NotImplementedException();
        }

        private void LetDealerFinalize() {
            throw new NotImplementedException();
        }

        public void PassToDealer() {
            throw new NotImplementedException();
        }
    }
}
