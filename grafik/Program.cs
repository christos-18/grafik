using System;
using Raylib_cs;

namespace grafik
{
    class Program
    {
        static void Main(string[] args)
        {


            Raylib.InitWindow(800, 600, "Jag är bäst");

            float x = 0;
            float y = 0;

            while(!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                 x += 0.1f;
                }

             else if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
              {
                    x -= 0.1f;
                }

                else if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    y += 0.1f;

                }

                else if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    y -= 0.1f;

                }



                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLUE);

                Raylib.DrawRectangle((int)x, (int)y, 30, 30, Color.WHITE);


                Raylib.EndDrawing();

            }

            
        }
    }
}
