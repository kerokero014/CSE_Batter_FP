using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;
using System;

namespace cse210_batter_csharp.Scripting
{
    // / <summary>
    // / An action to draw all of the actors in the game.
    // / </summary>
    public class HandleCollisionAction : Action
    {
        PhysicsService _physicsService = new PhysicsService();
        AudioService _audioService = new AudioService();
        public HandleCollisionAction(PhysicsService physicsService, AudioService audioService)
        {
            _physicsService = physicsService;
            _audioService = audioService;
        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            Actor _ball = cast["balls"][0]; 
            Actor _paddle = cast["paddle"][0]; 
            List<Actor> bricks = cast["bricks"];
            List<Actor> delete = new List<Actor>();

            if(_physicsService.IsCollision(_ball, _paddle))
            {
              Console.WriteLine("Reversed");
              ReverseOnPaddle(_ball);
              _audioService.PlaySound(Constants.SOUND_BOUNCE);
            }

            foreach(Actor brick in bricks)
            {
                if(_physicsService.IsCollision(_ball, brick))
                {
                    delete.Add(brick);
                    ReverseOnPaddle(_ball);
                }
                

            }
            if(delete.Count >= 1)
                {
                
                    Actor hit = delete[0];
                    cast["bricks"].Remove(hit);
                    _audioService.PlaySound(Constants.SOUND_BOUNCE);
                    
                }


        }

        private void ReverseOnPaddle(Actor actor)
        {
              int x = actor.GetX();
              int y = actor.GetY();
              int dx = actor.GetVelocity().GetX();
              int dy = actor.GetVelocity().GetY();

              dy = dy * -1;

              actor.SetVelocity(new Point(dx, dy));

              int newX = (x + dx);
              int newY = (y + dy);

              

              actor.SetPosition(new Point(newX, newY));
         }

         
            

            
    }

}