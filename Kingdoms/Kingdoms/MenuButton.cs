using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace Kingdoms
{
    
    class MenuButton
    {

        public Vector2 Pos { get; set; }       
        Texture2D Bild;
        Color Hover;
        SpriteFont sText;
        public string Text { get; set; }
        public enum BState { hover, pressed, normal }
        public BState state { get; set; }
        public bool active { get; set; }
        Game1 game;

        /// <summary>
        /// skapar en ny knapp med textur och text
        /// </summary>
        public MenuButton(Game1 Pgame)
        {
            game = Pgame;
            active = true;
            Bild = game.Content.Load<Texture2D>("MenuButton");
            sText = game.Content.Load<SpriteFont>("MenuFont");
        }

        /// <summary>
        /// säger till var knappen ska vara och i vilket state
        /// </summary>
        /// <param name="Bpos"></param>
        public void Initialize(Vector2 Bpos)
        {            
            Pos = Bpos;            
            state = BState.normal;             
        }

        /// <summary>
        /// uppdaterar var man håller musen och kollar om man hovrar knappen
        /// kollar sedan om man klickar på en knappen
        /// </summary>
        public void Update()
        {
            MouseState mus = Mouse.GetState();

            if (active == true)
            {
                if (mus.X >= Pos.X && mus.X <= (Pos.X + Bild.Width) && mus.Y >= Pos.Y && mus.Y <= (Pos.Y + Bild.Height))
                {
                    state = BState.hover;
                    if (mus.LeftButton == ButtonState.Pressed)
                        state = BState.pressed;
                }
                else
                    state = BState.normal;


                switch (state)
                {
                    case BState.hover:
                        Hover = new Color(240, 240, 240, 160);

                        break;
                    case BState.normal:
                        Hover = new Color(155, 155, 155, 185);

                        break;
                    case BState.pressed:
                        Hover = new Color(200, 200, 200, 175);

                        break;
                }
            }
            else
                Hover = new Color(100, 100, 100, 100);
        }

        /// <summary>
        /// målar upp knappen och texten
        /// </summary>
        /// <param name="SB"></param>
        public void Draw(SpriteBatch SB)
        {
            SB.Draw(Bild, Pos, Hover);
            SB.DrawString(sText, Text, new Vector2(Pos.X + 32, Pos.Y + 16), Color.White);
        }

        


    }
}
