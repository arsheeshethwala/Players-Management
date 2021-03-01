using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MTArsheemahediShethwala
{
    /// <summary>
    /// Interaction logic for BaseballPlayerWindow.xaml
    /// </summary>
    public partial class BaseballPlayerWindow : Window
    {
        BaseballPlayer bp = new BaseballPlayer();
        Player player;
        int tempIndex, temp, List_index = -1;
        public BaseballPlayerWindow()
        {
            InitializeComponent();
            Populate_List();
            Reset_Form();
        }

        private void Button_Help(object sender, RoutedEventArgs e)
        {

            HelpWindow hw = new HelpWindow();
            hw.ShowDialog();
        }

        private void Sign_Out(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sign Out Successfull");
            LoginWindow lw = new LoginWindow();
            lw.Show();
            Close();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if ((!int.TryParse(GamesPlayedT.Text, out temp)) || (!int.TryParse(d1t.Text, out temp)) || (!int.TryParse(d2t.Text, out temp)))
            {
                MessageBox.Show("Enter Valid numbers in " + GamesPlayedL.Content + " and " + d1l.Content + ", " + d2l.Content + "!");
            }
            else
            {
                InsertRecord();
                Reset_Form();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedIndex > -1)//(List.SelectedItem.ToString() != "null")
            {
                MessageBoxResult result = MessageBox.Show("You really want to update record?", "Update Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    UpdateRecord();
                }
                Populate_List();
                Reset_Form();
            }
            else
            {
                MessageBox.Show("Please, select any Player name first from list!");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedIndex > -1)
            {
                MessageBoxResult result = MessageBox.Show("You really want to delete record?", "Update Confirmation", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    DeleteRecord();
                }
                Populate_List();
                Reset_Form();
            }
            else
            {
                MessageBox.Show("Please, select any Player name first from list!");
            }
        }

        public void Populate_List()
        {
            List.Items.Clear();
            foreach (Player p in Program.lstPlayers)
            {
                if (p.PlayerType.ToString() == "BaseballPlayer")
                {
                    List.Items.Add(p.PlayerName);
                }
            }
        }

        public void UpdateRecord()
        {
            BaseballPlayer hp = new BaseballPlayer(PlayerType.BaseballPlayer, int.Parse(PlayerIdT.Text), PlayerNameT.Text, TeamNameT.Text, int.Parse(GamesPlayedT.Text), int.Parse(d1t.Text), int.Parse(d2t.Text));
            Program.lstPlayers[tempIndex] = hp;
            Populate_List();
        }

        public void InsertRecord()
        {
            BaseballPlayer hp = new BaseballPlayer(PlayerType.BaseballPlayer, (new BaseballPlayer()).generateID(), PlayerNameT.Text, TeamNameT.Text, int.Parse(GamesPlayedT.Text), int.Parse(d1t.Text), int.Parse(d2t.Text));
            Program.lstPlayers.Add(hp);
            Populate_List();
        }

        public void DeleteRecord()
        {
            Program.lstPlayers.RemoveAt(tempIndex);
            Populate_List();
        }

        public void Reset_Form()
        {
            PlayerIdT.Visibility = Visibility.Hidden;
            PlayerIdL.Visibility = Visibility.Hidden;

            PlayerIdT.Text = "";
            PlayerIdT.IsReadOnly = true;
            PlayerNameT.Text = "";
            TeamNameT.Text = "";
            GamesPlayedT.Text = "";
            d1t.Text = "";
            d2t.Text = "";

            TotalPointsL.Visibility = Visibility.Hidden;
            TotalPointsT.Visibility = Visibility.Hidden;

            List_index = -1;
        }

        private void List_Click(object sender, EventArgs e)
        {
            List_index = List.SelectedIndex;
            for (int i = 0; i < Program.lstPlayers.Count; i++)
            {
                if (List_index != -1)
                {
                    player = Program.lstPlayers[i];
                    if (player.PlayerType.ToString().Equals("BaseballPlayer"))
                    {
                        bp = (BaseballPlayer)player;
                        if (player.PlayerName.Equals(List.SelectedItem.ToString()))
                        {
                            tempIndex = i;
                            PlayerIdL.Visibility = Visibility.Visible;
                            PlayerIdT.Visibility = Visibility.Visible;
                            TotalPointsL.Visibility = Visibility.Visible;
                            TotalPointsT.Visibility = Visibility.Visible;
                            d1l.Content = "Runs: ";
                            d2l.Content = "Home Runs: ";
                            PlayerIdT.Text = bp.PlayerId.ToString();
                            PlayerIdT.IsReadOnly = true;
                            PlayerNameT.Text = bp.PlayerName;
                            TeamNameT.Text = bp.TeamName;
                            GamesPlayedT.Text = bp.GamesPlayed.ToString();
                            d1t.Text = bp.Runs.ToString();
                            d2t.Text = bp.HomeRuns.ToString();
                            TotalPointsT.Text = bp.TotalPoints.ToString();
                            TotalPointsT.IsReadOnly = true;
                        }
                    }
                }
            }
        }
    }
}
