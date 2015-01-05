using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject.Core
{
    public class Judge
    {
        public Play Winner(Play play1, Play play2)
        {
            var rules = new List<List<Play>>()
            {
                new List<Play>() { Play.Rock, Play.Scissor }
            };
            var set = new SortedSet<Play>(new Play[] { play1, play2 });

            if (set.First() == Play.Scissor && set.Last() == Play.Rock)
                return set.Last();
            if (set.First() == Play.Papper && set.Last() == Play.Rock)
                return set.First();
            if (set.First() == Play.Scissor && set.Last() == Play.Papper)
                return set.First();

            throw new InvalidOperationException("Unkonw element causing invalid state");
        }
    }

    public enum Play
    {
        Scissor = 1, Papper = 2, Rock = 3
    }
}
