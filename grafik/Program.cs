using System;
using Raylib_cs;

namespace grafik
{
    class Program
    {
        static void Main(string[] args)
        {


            Raylib.InitWindow(800, 600, "Jag är bäst");

            string scene = "intro";

            float x = 0;
            float y = 0;

            while (!Raylib.WindowShouldClose())
            {

                Raylib.BeginDrawing();

                if (scene == "intro")
                {
                    Raylib.ClearBackground(Color.BLACK);
                    Raylib.DrawText("Intro, tryck space for att starta spelet", 100, 50, 20, Color.WHITE);

                    x = 30;
                    y = 30;

                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    {
                        scene = "game";
                    }

                }

                else if (scene == "game")
                {
                    Raylib.ClearBackground(Color.BLUE);
                    Raylib.DrawText("starta spelet!", 100, 50, 20, Color.WHITE);

                    Raylib.DrawRectangle((int)x, (int)y, 30, 30, Color.WHITE);


                    if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    {
                        x += 0.1f;
                    }

                    else if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                    {
                        x -= 0.1f;
                    }

                    else if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                    {
                        y += 0.1f;

                    }

                    else if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                    {
                        y -= 0.1f;

                    }



                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "intro";
                    }

                    if (y > Raylib.GetScreenHeight() || x > Raylib.GetScreenWidth() || y < 0 || x < 0)
                    {
                        scene = "gameover";
                    }

                }


                else if (scene == "gameover")
                {
                    Raylib.ClearBackground(Color.RED);
                    Raylib.DrawText("GAME OVER! Tryck tabb for att starta om", 100, 50, 20, Color.WHITE);


                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
                    {
                        scene = "intro";
                    }

                }










                Raylib.EndDrawing();

            }


        }
    }
}
