/**
 * Tournament Manager
 * 
 * Engine class - Предоставя всички необходими команди и методи за да функционира системата
 */

using System;
using System.Windows.Forms;

namespace TournamentManager
{
    internal class Engine
    {
        
        //Разбъркай отборите
        public void ShuffleTeams(string[] teamsList)
        {
            Random randomNumber = new Random(); 
            for (int i = teamsList.Length - 1; i > 0; i--)
            {
                int j = randomNumber.Next(0, i + 1);
                (teamsList[j], teamsList[i]) = (teamsList[i], teamsList[j]);
            }
        }

        //Разпредели турнирите с 32 отбора в 8 групи по 4 отбора
        public void ManageNext32(string[] teamsList)
        {
            ShuffleTeams(teamsList);

            DialogResult continueToGrups = MessageBox.Show(
                "Do you want to load the Team - Grupe Model?",
                "Team - Grupe Model",
                MessageBoxButtons.YesNo
            );

            if (continueToGrups == DialogResult.Yes)
            {
                for (int i = 0; i < teamsList.Length; i++)
                {
                    if (i >= 0 && i <= 3)
                    {
                        DialogResult response1 = MessageBox.Show(
                           $"Team {i + 1} in grupe A is {teamsList[i]}",
                           "Team - Grupe Model",
                           MessageBoxButtons.OKCancel
                        );

                        if (response1 == DialogResult.Cancel)
                        {
                            break;

                        }
                    }
                    else if (i >= 4 && i <= 7)
                    {
                        DialogResult response2 = MessageBox.Show(
                            $"Team {i - 3} in grupe B is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response2 == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                    else if (i >= 8 && i <= 11)
                    {
                        DialogResult response3 = MessageBox.Show(
                            $"Team {i - 7} in grupe C is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response3 == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                    else if (i >= 12 && i <= 15)
                    {
                        DialogResult response4 = MessageBox.Show(
                            $"Team {i - 11} in grupe D is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response4 == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                    else if (i >= 16 && i <= 19)
                    {
                        DialogResult response5 = MessageBox.Show(
                            $"Team {i - 15} in grupe E is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response5 == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                    else if (i >= 20 && i <= 23)
                    {
                        DialogResult response6 = MessageBox.Show(
                            $"Team {i - 19} in grupe F is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response6 == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                    else if (i >= 24 && i <= 27)
                    {
                        DialogResult response7 = MessageBox.Show(
                            $"Team {i - 23} in grupe G is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response7 == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                    else if (i >= 28 && i <= 31)
                    {
                        DialogResult response8 = MessageBox.Show(
                            $"Team {i - 27} in grupe H is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response8 == DialogResult.Cancel)
                        {
                            break;
                        }

                        if (i == 31)
                        {
                            MessageBox.Show("All teams are managed to the groups");
                        }
                    }
                }
            }
            else
            {
                // не прави нищо при несъгласие за продължаване напред към групите
            }
        }


        //Разпредели турнирите с 16 отбора в 4 групи по 4 отбора
        public void ManageNext16(string[] teamsList)
        {
            ShuffleTeams(teamsList);

            DialogResult continueToGroups = MessageBox.Show(
                "Do you want to load the Team - Grupe Model?",
                "Team - Grupe Model",
                MessageBoxButtons.YesNo
            );

            if (continueToGroups == DialogResult.Yes)
            {
                for (int i = 0; i < teamsList.Length; i++)
                {
                    if (i >= 0 && i <= 3)
                    {
                        DialogResult response1 = MessageBox.Show(
                           $"Team {i + 1} in grupe A is {teamsList[i]}",
                           "Team - Grupe Model",
                           MessageBoxButtons.OKCancel
                        );

                        if (response1 == DialogResult.Cancel)
                        {
                            break;

                        }
                    }
                    else if (i >= 4 && i <= 7)
                    {
                        DialogResult response2 = MessageBox.Show(
                             $"Team {i - 3} in grupe B is {teamsList[i]}",
                             "Team - Grupe Model",
                             MessageBoxButtons.OKCancel
                         );

                        if (response2 == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                    else if (i >= 8 && i <= 11)
                    {
                        DialogResult response3 = MessageBox.Show(
                            $"Team {i - 7} in grupe C is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response3 == DialogResult.Cancel)
                        {
                            break;
                        }
                    }
                    else if (i >= 12 && i <= 15)
                    {
                        DialogResult response4 = MessageBox.Show(
                            $"Team {i - 11} in grupe D is {teamsList[i]}",
                            "Team - Grupe Model",
                            MessageBoxButtons.OKCancel
                        );

                        if (response4 == DialogResult.Cancel)
                        {
                            break;
                        }

                        if (i == 15)
                        {
                            MessageBox.Show("All teams are managed to the groups");
                        }
                    }
                }
            }
            else
            {
                // не прави нищо при несъгласие за продължаване напред към групите
            }

        }

    }
}
