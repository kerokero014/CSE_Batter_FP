using System;

namespace cse210_batter_csharp
{
    public static class Constants
    {
        public const int MAX_X = 800;
        public const int MAX_Y = 600;
        public const int FRAME_RATE = 30;

        public const int DEFAULT_SQUARE_SIZE = 20;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string IMAGE_BRICK = "./Assets/brick-5.png";
        public const string IMAGE_PADDLE = "./Assets/bat.png";
        public const string IMAGE_BALL = "./Assets/teacher_fun_2.png";

        public const string SOUND_START = "./Assets/Assets_start.wav";
        public const string SOUND_BOUNCE = "./Assets/Assets_boing.wav";
        public const string SOUND_OVER = "./Assets/Assets_over.wav";

        public const int BALL_X = MAX_X / 2;
        public const int BALL_Y = MAX_Y - 125;

        public const int BALL_DX = 8;
        public const int BALL_DY = BALL_DX * -1;

        public const int PADDLE_X = MAX_X / 2;
        public const int PADDLE_Y = MAX_Y - 25;

        public const int BRICK_WIDTH = 48;
        public const int BRICK_HEIGHT = 24;

        public const int BRICK_SPACE = 5;

        public const int PADDLE_SPEED = 15;

        public const int PADDLE_WIDTH = 96;
        public const int PADDLE_HEIGHT = 24;

        public const int BALL_WIDTH = 30;
        public const int BALL_HEIGHT = 30;
    }

}