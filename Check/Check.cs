using System.Collections.Generic;

namespace Engine
{
    public static class Check
    {
        public static (int bull, int cow) Try(List<int> hiddenNumber, List<int> playerNumber)
        {
            int bull = 0;
            int cow = 0;

            foreach (var item in playerNumber)
            {
                if (hiddenNumber[item] == playerNumber[item])
                {
                    bull++;
                }
            }

            
            for (int indexP = 0; indexP < playerNumber.Count; indexP++)
            {
                for (int indexH = 0; indexH < hiddenNumber.Count; indexH++)
                {
                    if (indexP == indexH & playerNumber[indexP] == hiddenNumber[indexH])
                    {
                        cow++;
                    }
                }
            }

            var tuple = (bull, cow);

            return tuple;

        }
    }
}
