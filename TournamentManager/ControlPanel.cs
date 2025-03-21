/**
* Tournament Manager
* 
* Control panel - Входна точка на приложението - стартиране на приложението от тук.
*/

using System.Windows.Forms;

namespace TournamentManager
{
    class ControlPanel
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ManagerGUI());
        }
    }
}
