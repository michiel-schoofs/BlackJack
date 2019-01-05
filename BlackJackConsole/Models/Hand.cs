using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackConsole.Models {
    class Hand {
        private IList<BlackJackCard> _cards;
        public IEnumerable<BlackJackCard> Cards { get; set; }

        public Hand() {
            throw new NotImplementedException();
        }

        public void AddCard(BlackJackCard blackJackCard) {
            throw new NotImplementedException();
        }

        public void TurnAllCardsFaceUp() {
            throw new NotImplementedException();
        }

        private int CalculateValue() {
            throw new NotImplementedException();
        }
    }
}
