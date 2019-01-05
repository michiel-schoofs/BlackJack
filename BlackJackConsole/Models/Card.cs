using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackConsole.Models {
    class Card {
        public FaceValue FaceValue { get; set; }
        public Suit Suit { get; set; }

        public Card(Suit suit, FaceValue faceValue) {
            throw new NotImplementedException();
        }
    }
}
