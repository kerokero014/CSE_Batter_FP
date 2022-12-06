using System;
using System.Collections.Generic;
using Raylib_cs;
using cse210_batter_csharp.Casting;

namespace cse210_batter_csharp.Services
{
    public class OutputService
    {
        private Raylib_cs.Color _backgroundColor = Raylib_cs.Color.BLACK;
        private Dictionary<string, Raylib_cs.Texture2D> _textures
            = new Dictionary<string, Raylib_cs.Texture2D>();

        public OutputService()
        {

        }

        public void OpenWindow(int width, int height, string title, int frameRate)
        {
            Raylib.InitWindow(width, height, title);
            Raylib.SetTargetFPS(frameRate);
        }

        public void CloseWindow()
        {
            Raylib.CloseWindow();
        }

        public void StartDrawing()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(_backgroundColor);
        }

        public void EndDrawing()
        {
            Raylib.EndDrawing();
        }


        public void DrawBox(int x, int y, int width, int height)
        {
            Raylib.DrawRectangle(x, y, width, height, Raylib_cs.Color.BLUE);            
        }

        public void DrawImage(int x, int y, string image)
        {
            if (!_textures.ContainsKey(image))
            {
                Raylib_cs.Texture2D loaded = Raylib.LoadTexture(image);
                _textures[image] = loaded;
            }

            Raylib_cs.Texture2D texture = _textures[image];
            Raylib.DrawTexture(texture, x, y, Raylib_cs.Color.WHITE);
        }

        public void DrawText(int x, int y, string text, bool darkText)
        {
            Raylib_cs.Color color = Raylib_cs.Color.WHITE;

            if (darkText)
            {
                color = Raylib_cs.Color.BLACK;
            }

            Raylib.DrawText(text,
                x + Constants.DEFAULT_TEXT_OFFSET,
                y + Constants.DEFAULT_TEXT_OFFSET,
                Constants.DEFAULT_FONT_SIZE,
                color);
        }

        public void DrawActor(Actor actor)
        {
            int x = actor.GetX();
            int y = actor.GetY();
            int width = actor.GetWidth();
            int height = actor.GetHeight();


            if (actor.HasImage())
            {
                string image = actor.GetImage();
                DrawImage(x, y, image);
            }
            else if (actor.HasText())
            {
                bool darkText = true;
                string text = actor.GetText();
                DrawText(x, y, text, darkText);
            }
            else
            {
                DrawBox(x, y, width, height);
            }
        }

        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }

    }

}