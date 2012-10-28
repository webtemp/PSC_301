using System;
using System.Text;
using System.Windows.Forms;

namespace Moo_Moo
{
    public enum Condition
    {
        WIN, LOOSE, NEW_GAME, RESET
    }

    public static class ResetGame
    {
        public static void WithCondition(Condition condition){
            if (condition == Condition.NEW_GAME)
            {
                
            }
            else if (condition == Condition.RESET)
            {
                // Same as new game ?
            }
            else if (condition == Condition.LOOSE)
            {
                // Player Looses! Sorry
            }
            else if (condition == Condition.WIN)
            {
                // Player WINS !
            }
        }
    }
}
