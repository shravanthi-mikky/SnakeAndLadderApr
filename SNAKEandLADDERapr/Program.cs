// See https://aka.ms/new-console-template for more information


using SNAKEandLADDERapr;

Console.WriteLine("Welcome to Snake and Ladder Simulator!!!");

game player1 = new();
game player2 = new();
Console.WriteLine("Player 1: ");
player1.Describe();
Console.WriteLine("Player 2: ");
player2.Describe();
player1.PlayTillEnd(player2);