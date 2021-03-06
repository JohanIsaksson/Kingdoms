﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

//Huvudmenyn i spelet
namespace Kingdoms
{
    public class MainMenu
    {
        MenuButton NewGame;
        MenuButton LoadGame;
        MenuButton Exit;

        Texture2D BG;
        Rectangle BGrect;
        Texture2D musb;
        Vector2 musp;

        Game1 game;

        public MainMenu(Game1 game1)
        {
            game = game1;
            NewGame = new MenuButton(game);
            LoadGame = new MenuButton(game);
            Exit = new MenuButton(game);

            musb = game.Content.Load<Texture2D>("mus2");
            BG = game.Content.Load<Texture2D>("grassBack");
                        
        }

        
        /// <summary>
        /// initialiserar menyn efter höjd och bredd på fönstret
        /// </summary>
        /// <param name="W"></param>
        /// <param name="H"></param>
        public void Initialize(int W,int H)
        {
            NewGame.Initialize(new Vector2((W / 2) - 128, (H / 2) - 100));
            NewGame.Text = "New Game";
            LoadGame.Initialize(new Vector2((W / 2) - 128, (H / 2) - 32));
            LoadGame.Text = "Load Game";
            LoadGame.active = false;
            Exit.Initialize(new Vector2((W / 2) - 128, (H / 2) + 36));
            Exit.Text = "Exit";


            BGrect = new Rectangle(0, 0, 1080, 1920);
            
        }

        
        /// <summary>
        /// uppdater knappar och mus i menyn
        /// </summary>
        public void Update()
        {
            NewGame.Update();
            LoadGame.Update();
            Exit.Update();


            MouseState mus = Mouse.GetState();
            musp = new Vector2(mus.X,mus.Y);

            if (NewGame.state == MenuButton.BState.pressed)
                game.state = Game1.GameState.NewGame;
            else if (LoadGame.state == MenuButton.BState.pressed)
                game.state = Game1.GameState.LoadGame;
            else if (Exit.state == MenuButton.BState.pressed)
                game.state = Game1.GameState.Exit;
                
            


        }

        
        /// <summary>
        /// målar upp allt
        /// </summary>
        /// <param name="SB"></param>
        public void Draw(SpriteBatch SB)
        {
            SB.Draw(BG, new Vector2(0, 0),BGrect, Color.White);

            NewGame.Draw(SB);
            LoadGame.Draw(SB);
            Exit.Draw(SB);

            SB.Draw(musb, musp, Color.White);
        }

        
    }

    
}
