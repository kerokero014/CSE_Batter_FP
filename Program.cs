using System;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Scripting;
using System.Collections.Generic;

namespace cse210_batter_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Bricks
            cast["bricks"] = new List<Actor>();
            // Bricks _brick1 = new Bricks(10, 10);
            // Bricks _brick2 = new Bricks(100, 10);
            // Bricks _brick3 = new Bricks(200, 10);
            // cast["bricks"].Add(_brick1);
            // cast["bricks"].Add(_brick2);
            // cast["bricks"].Add(_brick3);

            for (int c = 0;c < 8;c++){
                for(int r = 0;r <15;r++){
                    Bricks _brick = new Bricks(20 + (50 * r), 10 + (30 * c));
                    cast["bricks"].Add(_brick);
                }
            }

            // TODO: Add your bricks here

            // The Ball (or balls if desired)
            cast["balls"] = new List<Actor>();
            Ball _ball = new Ball(Constants.MAX_X /2, Constants.MAX_Y /2);
            cast["balls"].Add(_ball);

            // TODO: Add your ball here

            // The paddle
            cast["paddle"] = new List<Actor>();
            Paddle _paddle = new Paddle(Constants.MAX_X /2, 550);
            cast["paddle"].Add(_paddle);
            // TODO: Add your paddle here

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            ControlActorsAction _CAA = new ControlActorsAction(inputService);
            script["input"].Add(_CAA);

            script["update"] = new List<Action>();
            HandleOffScreenAction _HOSA = new HandleOffScreenAction(physicsService);
            MoveActorsAction _MAA = new MoveActorsAction();
            HandleCollisionAction _HCA = new HandleCollisionAction(physicsService, audioService);
            script["update"].Add(_HOSA);
            script["update"].Add(_MAA);
            script["update"].Add(_HCA);

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Batter", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}