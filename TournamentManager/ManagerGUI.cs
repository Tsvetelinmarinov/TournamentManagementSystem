/**
 * Tournament Manager
 * 
 * GUI - Графичен потребителски интерфейс на приложението
 */

using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Remoting.Channels;

namespace TournamentManager
{
    partial class ManagerGUI : Form
    {
        public ManagerGUI()
        {
            LoadSystemComponents();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(Width, Height);
            MinimumSize = new Size(Width, Height);
        }

        private void LoadSystemComponents()
        {
            Size = new Size(1000, 700);
            Text = "Pro Evolution Soccer 2013 BUL MOD 7 Tournament Manager";
            Icon = new Icon("C:\\Games\\KONAMI\\Pro Evolution Soccer 2013\\Tournament Manager\\Tournament Management System\\TournamentManager\\Source\\Icon\\Fasticon-World-Cup-2006-Ball-football-camp.ico");
            BackColor = Color.GhostWhite;

            PictureBox managerLogo = new PictureBox();
            managerLogo.Image = Image.FromFile("C:\\Games\\KONAMI\\Pro Evolution Soccer 2013\\Tournament Manager\\Tournament Management System\\TournamentManager\\Source\\Images\\manager.jpg");
            managerLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            managerLogo.Size = new Size(1000, 400);
            managerLogo.Location = new Point(0, 0);
            Controls.Add(managerLogo);

            PictureBox info = new PictureBox();
            info.Image = Image.FromFile("C:\\Games\\KONAMI\\Pro Evolution Soccer 2013\\Tournament Manager\\Tournament Management System\\TournamentManager\\Source\\Icon\\information.png");
            info.SetBounds(5, 410, 30, 30);
            info.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(info);

            ToolTip infoTip = new ToolTip();
            infoTip.SetToolTip(info, "Choose a tournament and wait the manager to manage the teams to the groups");

            Label tournament1 = new Label();
            tournament1.Text = "FIFA World Cup Russia";
            tournament1.Font = new Font("Cascadia Code", 16, FontStyle.Italic);
            tournament1.Size = new Size(295, 30);
            tournament1.ForeColor = Color.DarkGray;
            tournament1.Location = new Point(200, 470);
            tournament1.MouseEnter += (sender, action) => tournament1.ForeColor = Color.Black;
            tournament1.MouseLeave += (sender, action) => tournament1.ForeColor = Color.DarkGray;
            tournament1.MouseClick += (sender, action) => new Engine().ManageNext32(new Database().fifaWorldCupTeams);
            Controls.Add(tournament1);

            Label tournament2 = new Label();
            tournament2.Text = "UEFA Euro France";
            tournament2.Font = new Font("Cascadia Code", 16, FontStyle.Italic);
            tournament2.Size = new Size(240, 30);
            tournament2.ForeColor = Color.DarkGray;
            tournament2.Location = new Point(540, 470);
            tournament2.MouseEnter += (sender, action) => tournament2.ForeColor = Color.Black;
            tournament2.MouseLeave += (sender, action) => tournament2.ForeColor = Color.DarkGray;
            tournament2.MouseClick += (sender, action) => new Engine().ManageNext16(new Database().uefaEuroTeams);
            Controls.Add(tournament2);

            Label tournament3 = new Label();
            tournament3.Text = "UEFA Champions League";
            tournament3.Font = new Font("Cascadia Code", 16, FontStyle.Italic);
            tournament3.Size = new Size(300, 30);
            tournament3.ForeColor = Color.DarkGray;
            tournament3.Location = new Point(200, 540);
            tournament3.MouseEnter += (sender, action) => tournament3.ForeColor = Color.Black;
            tournament3.MouseLeave += (sender, action) => tournament3.ForeColor = Color.DarkGray;
            tournament3.MouseClick += (sender, action) => new Engine().ManageNext32(new Database().championsLeagueTeams);
            Controls.Add(tournament3);

            Label tournament4 = new Label();
            tournament4.Text = "UEFA Europe League";
            tournament4.Font = new Font("Cascadia Code", 16, FontStyle.Italic);
            tournament4.Size = new Size(300, 30);
            tournament4.ForeColor = Color.DarkGray;
            tournament4.Location = new Point(540, 540);
            tournament4.MouseEnter += (sender, action) => tournament4.ForeColor = Color.Black;
            tournament4.MouseLeave += (sender, action) => tournament4.ForeColor = Color.DarkGray;
            tournament4.MouseClick += (sender, action) => new Engine().ManageNext32(new Database().uefaEuropeLeagueTeams);
            Controls.Add(tournament4);

            Label about = new Label();
            about.Text = "programmer: Tsvetelin Marinov              place: Sofia, Bulgaria, EU              date: Friday 21 March 2025";
            about.Size = new Size(1000, 17);
            about.Font = new Font("Cascadia Code", 10, FontStyle.Italic);
            about.Location = new Point(20, 610);
            about.ForeColor = Color.DarkGray;
            Controls.Add(about);

            PictureBox pesLogo = new PictureBox();
            pesLogo.Image = Image.FromFile("C:\\Games\\KONAMI\\Pro Evolution Soccer 2013\\Tournament Manager\\Tournament Management System\\TournamentManager\\Source\\Images\\Pes2013.jpg");
            pesLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pesLogo.Size = new Size(1000, 35);
            pesLogo.Location = new Point(0, 630);
            Controls.Add(pesLogo);
        }
    }
}
