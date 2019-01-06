using BlackJackConsole.Models;
using System;

namespace BlackJackConsole {
    class Program {
        static void Main(string[] args) {
            Deck deck = new Deck();
            for(int i = 0; i < 52; i++) {
                Console.WriteLine(deck.Draw());
            }
            Console.ReadLine();
        }
    }
}
