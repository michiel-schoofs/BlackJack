using BlackJackConsole.Models;
using System;

namespace BlackJackConsole {
    class Program {
        static void Main(string[] args) {
            Hand _aHand = new Hand();

            BlackJackCard card = new BlackJackCard(Suit.Diamonds, FaceValue.Five);
            _aHand.AddCard(card);
            card = new BlackJackCard(Suit.Diamonds, FaceValue.Ace);
            _aHand.AddCard(card);

            _aHand.TurnAllCardsFaceUp();

            Console.WriteLine(_aHand.Value);
            Console.ReadLine();
        }
    }
}
