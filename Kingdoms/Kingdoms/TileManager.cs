using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.Media;
using System.IO;
using System.Text.RegularExpressions;


namespace Kingdoms
{
    public class TileManager
    {

        Texture2D TileSet;   
        
        public Tile[,] Map {get;set;} 
        int MapH=16;
        int MapW=26;
        int viewH=16-1;
        int viewW=26-1;
        int TileValue;

        Vector2 CamPos;
        string thiskey;
        string lastkey;

        
             

        Random rand; //tillfällig



        public TileManager(ContentManager Content)
        {
            TileSet = Content.Load<Texture2D>("Graphics4");
                                    
        }

        public void initialize()
        {           

            CamPos = new Vector2(0, 0);
            rand = new Random();
            Map = new Tile[26,16];

            if (Map[25, 15] == null)
            {
                for (int x = 0; x <= MapW-1; x++)
                {
                    for (int y = 0; y <= MapH-1; y++)
                    {
                        TileValue = rand.Next(0,5);
                        Map[x, y] = new Tile();
                        Map[x, y].SetTile(TileValue, x, y);
                    }
                }
                Map[10, 10].SetTile(27, 10, 10);
            }
        }
        

        public void LoadMap(string mapname)
        {
            StreamReader srFile = new StreamReader("Maps/" + mapname);
            string strLine = "";            
            int X = 0;
            int Y = 0;

            try
            {
                do
                {
                    strLine = srFile.ReadLine();
                    string[] splitThis = Regex.Split(strLine.Substring(0, strLine.Length - 1), ",");

                    for (X = 0; X <= MapW - 1; X++)
                    {
                        if (splitThis[X] == "")
                            Map[X, Y].SetTile(0, X, Y);
                        else if (X <= 25)
                            Map[X, Y].SetTile(Convert.ToInt32(splitThis[X]), X, Y);
                    }

                    X = 0;
                    Y += 1;

                } while (!srFile.EndOfStream && Y <= MapH);
            }
            catch
            { 
            
            
            }

            srFile.Close();
            srFile.Dispose();

        }


        public void SaveMap(string mapname)
        {
        
        }
        

        public void MoveCam()
        {
            KeyboardState key = Keyboard.GetState();


            if (key.IsKeyDown(Keys.Up) == true && CamPos.Y > 0)
                thiskey = "Up";
            else if (key.IsKeyDown(Keys.Down) == true && (CamPos.Y + viewH) < 31)
                thiskey = "Down";
            else if (key.IsKeyDown(Keys.Left) == true && CamPos.X > 0)
                thiskey = "Left";
            else if (key.IsKeyDown(Keys.Right) == true && (CamPos.X + viewW) < 31)
                thiskey = "Right";
            else if (key.IsKeyDown(Keys.C) == true)
                thiskey = "Castle";
            else
                thiskey = "";


            if (thiskey == "Up")
                CamPos.Y -= 1;
            if (thiskey == "Down")
                CamPos.Y += 1;
            if (thiskey == "Left")
                CamPos.X -= 1;
            if (thiskey=="Right")
                CamPos.X += 1;
            if (thiskey == "Castle" && thiskey != lastkey)            
                Map[10, 10].SetTile(27, 10, 10);

            
            lastkey = thiskey;

        }


        public void Update()
        {
            MoveCam();            


            for (int x = 0; x <= viewW; x++)
            {
                for (int y = 0; y <= viewH; y++)
                {
                    Map[x,y].Update();
                }
            }
                        
            
                                           

        }


        public void Draw(SpriteBatch SB)
        {
            for (int x = 0; x <= viewW; x++)
            {
                for (int y = 0; y <= viewH; y++)
                {
                    SB.Draw(TileSet, new Rectangle(x * 32, y * 32, 32, 32), Map[x,y].Bild, Color.White);                    
                }
            }

            
            
                      
        
        }








    }
}
