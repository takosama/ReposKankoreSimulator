using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSimlator
{
    class Game
    {
        public static Form1 f;
        GameSeen.Type nowseen;
        public void Start(Form1 f)
        {
            Game.f = f;
            Reset();
        }

        public GameSeen Next(bool view)
        {
            var nextSeen = ComputeNextSeen(nowseen,null);
            //
            return null;
        }
        GameSeen.Type ComputeNextSeen(GameSeen.Type now,object ships)
        {
            return 0;
        }
       


        public void Reset()
        {
            GameViewer.Reset(GameSeen.None());
        }
    }

    class GameViewer
    {
        static public void Reset(GameSeen gameSeen)
        {
            Game.f.DrawBaseShips(gameSeen.BaseShips);
        }
        static public void View(Command[] commands)
        {
            foreach (var n in commands)
            {
                View(n);
            }
        }
        static public void View(Command command)
        {
            Game.f.ReseveCommand(command);
        }
    }

    class GameSeen
    {
        public enum Type
        {
            Search,
            OpeningAirButtle,
            OpeningUntiAirFire,
            OpeningAirAttack,
        }

        public static GameSeen None()
        {
            return null;
        }
      public  Command[] Commands;
      public  object BaseShips;
      public  object AfterShips;
    }
 
  public  class Command
    {
        GameSeen.Type type;
        public object status;
    }

}
