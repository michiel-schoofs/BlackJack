using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJackConsole.Models {
    class BlackJackCard:Card {
        public bool FaceUp { get; set; }
        public int Value { get; }

        public BlackJackCard(Suit suit, FaceValue faceValue):base(suit,faceValue){
            throw new NotImplementedException();
        }
        
        public void TurnCard() {
            throw new NotImplementedException();
        }
    }
}
