﻿
using System.Threading.Channels;
using GameBrain;
using MenuSystem;

var gameInstance = new TicTacTwoBrain();

var deepMenu = new Menu(EMenuLevel.Deep, "TIC-TAC-TWO DEEP", new Dictionary<string, MenuItem>
{
    {"Y", new MenuItem()
    {
        Title = "YYYYYY",
        Shortcut = "Y",
        MenuItemAction = null
    }},
});


var optionsMenu = new Menu(EMenuLevel.Secondary, "TIC-TAC-TWO OPTIONS", new Dictionary<string, MenuItem>
{
    {"X", new MenuItem()
    {
        Title = "X Starts",
        Shortcut = "X",
        MenuItemAction = deepMenu.Run
    }},
    {"O", new MenuItem()
    {
        Title = "O Starts",
        Shortcut = "O",
        MenuItemAction = null
    }}
});



var mainMenu = new Menu(EMenuLevel.Main, "TIC-TAC-TWO", new Dictionary<string, MenuItem>
{
    {"O", new MenuItem()
    {
        Title = "Options",
        Shortcut = "O",
        MenuItemAction = optionsMenu.Run
    }},
    {"N", new MenuItem()
    {
        Title = "New game",
        Shortcut = "N",
        MenuItemAction = NewGame
    }}
});

mainMenu.Run();

return;


// ==================================

string NewGame()
{
    

    ConsoleUI.Visualizer.DrawBoard(gameInstance);

    return "Hi";
}





