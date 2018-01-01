using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Kingdoms
{
    public class Tile
    {

        public Rectangle Bild { get; set; }
        Rectangle Animation;

        public int typ { get; set; }


        int tSize = 32;
        public Vector2 Pos { get; set; }

        public void SetTile(int val, int X, int Y)
        {
            switch (val)
            {
                case 0: // gräs1
                    Bild = new Rectangle(0, 0, tSize, tSize);
                    break;

                case 1: // gräs2
                    Bild = new Rectangle(0, 32, tSize, tSize);
                    break;

                case 2: // skog1
                    Bild = new Rectangle(96, 32, tSize, tSize);
                    break;

                case 3: // skog2
                    Bild = new Rectangle(192, 96, tSize, tSize);
                    break;

                case 4: // sten
                    Bild = new Rectangle(128, 96, tSize, tSize);
                    break;

                case 5: // väg hori
                    Bild = new Rectangle(64, 0, tSize, tSize);
                    break;

                case 6: // väg vert
                    Bild = new Rectangle(96, 0, tSize, tSize);
                    break;

                case 7: // väg ↓→
                    Bild = new Rectangle(192, 0, tSize, tSize);
                    break;

                case 8: // väg →↑
                    Bild = new Rectangle(224, 0, tSize, tSize);
                    break;

                case 9: // väg ↑→
                    Bild = new Rectangle(128, 0, tSize, tSize);
                    break;

                case 10: // väg →↓
                    Bild = new Rectangle(160, 0, tSize, tSize);
                    break;

                case 11: // vatten1
                    Bild = new Rectangle(32, 32, tSize, tSize);
                    break;

                case 12: //Neutralt slott
                    Bild = new Rectangle(64, 32, tSize, tSize);
                    break;

                case 13: // strand top
                    Bild = new Rectangle(96, 64, tSize, tSize);
                    break;

                case 14: // strand bot
                    Bild = new Rectangle(64, 64, tSize, tSize);
                    break;

                case 15: // strand h
                    Bild = new Rectangle(0, 64, tSize, tSize);
                    break;

                case 16: // strand v
                    Bild = new Rectangle(32, 64, tSize, tSize);
                    break;

                case 17: // strand v bot ut
                    Bild = new Rectangle(32, 96, tSize, tSize);
                    break;

                case 18: // strand h bot ut
                    Bild = new Rectangle(0, 96, tSize, tSize);
                    break;

                case 19: // strand h top ut
                    Bild = new Rectangle(64, 96, tSize, tSize);
                    break;

                case 20: // strand v top ut
                    Bild = new Rectangle(96, 96, tSize, tSize);
                    break;

                case 21: // stran h top in
                    Bild = new Rectangle(0, 128, tSize, tSize);
                    break;

                case 22: // strand v top in
                    Bild = new Rectangle(0, 160, tSize, tSize);
                    break;

                case 23: // strand h bot in
                    Bild = new Rectangle(32, 128, tSize, tSize);
                    break;

                case 24: // strand v bot in
                    Bild = new Rectangle(32, 160, tSize, tSize);
                    break;

                case 25: // n hus
                    Bild = new Rectangle(32, 0, tSize, tSize);
                    break;

                case 26: // blå hus
                    Bild = new Rectangle(128, 32, tSize, tSize);
                    break;

                case 27: // blå slott
                    Bild = new Rectangle(128, 64, tSize, tSize);
                    break;

                case 28: // grön hus
                    Bild = new Rectangle(160, 32, tSize, tSize);
                    break;

                case 29: // grön slott
                    Bild = new Rectangle(160, 64, tSize, tSize);
                    break;

                case 30: // gul hus
                    Bild = new Rectangle(192, 32, tSize, tSize);
                    break;

                case 31: // gul slott
                    Bild = new Rectangle(192, 64, tSize, tSize);
                    break;

                case 32: // röd hus
                    Bild = new Rectangle(224, 32, tSize, tSize);
                    break;
                case 33: // röd slott
                    Bild = new Rectangle(224, 64, tSize, tSize);
                    break;
                case 34: // 4-vägs kors
                    Bild = new Rectangle(160, 96, tSize, tSize);
                    break;
                case 35: // 3-vägs kors ↓
                    Bild = new Rectangle(64, 128, tSize, tSize);
                    break;
                case 36: // 3-vägs kors <-
                    Bild = new Rectangle(96, 128, tSize, tSize);
                    break;
                case 37: // 3-vägs kors ↑
                    Bild = new Rectangle(128, 128, tSize, tSize);
                    break;
                case 38: // 3-väs kors →
                    Bild = new Rectangle(160, 128, tSize, tSize);
                    break;
                case 39: //väg slut →
                    Bild = new Rectangle(64, 160, tSize, tSize);
                    break;
                case 40: //väg slut <-
                    Bild = new Rectangle(96, 160, tSize, tSize);
                    break;
                case 41: //väg slut ↓
                    Bild = new Rectangle(128, 160, tSize, tSize);
                    break;
                case 42: //väg slut ↑
                    Bild = new Rectangle(160, 160, tSize, tSize);
                    break;
                case 43: //n slott
                    Bild = new Rectangle(64, 32, tSize, tSize);
                    break;



                //mer vägar och sånt kommer...
                //osv ↑→↓
            }
            Pos = new Vector2(X, Y);
            typ = val;
        }

        public void Update()
        {




        }

    }
}


