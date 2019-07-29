using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchThree
{
    public static class RandomiserUtilities
    {

        public static void RemoveWeightIfPossibleTileMatch(ref Dictionary<string, int> sanitisedTileWeights, string typeOne, string typeTwo)
        {
            if (typeOne == typeTwo)
                sanitisedTileWeights[typeOne] = 0;
        }

        public static void RemoveWeightIfBelowOne(ref Dictionary<string, int> sanitisedTileWeights)
        {
            foreach (var weight in sanitisedTileWeights.Where(w => w.Value < 1).ToList())
                sanitisedTileWeights[weight.Key] = 0;
        }
    }
}
