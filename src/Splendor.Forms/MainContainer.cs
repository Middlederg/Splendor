using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splendor.Forms
{
    public partial class MainContainer : Form
    {
        private MainMenu mainMenu;
        private PrepareGame prepareGame;
        private ConfigurationView configurationView;

        public MainContainer()
        {
            InitializeComponent();

            mainMenu = new MainMenu();
            prepareGame = new PrepareGame() { Visible = false };
            configurationView = new ConfigurationView() { Visible = false };

            mainMenu.OnButtonClicked += OnButtonClickedOnMenu;
            prepareGame.OnBackButtonClicked += OnBackToMenu;
            prepareGame.OnPlayButtonClicked += OnPlayButtonClickedOnPrepareGame;
            configurationView.OnBackButtonClicked += OnBackToMenu;

            MainPanel.Controls.Add(mainMenu);
            MainPanel.Controls.Add(prepareGame);
            MainPanel.Controls.Add(configurationView);
        }

        private void OnBackToMenu(object sender, EventArgs e)
        {
            ShowMainMenu();
        }

        private void OnButtonClickedOnMenu(object sender, ValueEventArgs<MenuOption> e)
        {
            switch (e.Value)
            {
                case MenuOption.Play:
                    ShowPrepareGame();
                    break;
                case MenuOption.Tournament:
                    break;
                case MenuOption.Season:
                    break;
                case MenuOption.Configuration:
                    ShowConfiguration();
                    break;
                case MenuOption.Exit:
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void OnPlayButtonClickedOnPrepareGame(object sender, EventArgs e)
        {
            ShowMainMenu();
        }

        private void ShowMainMenu()
        {
            prepareGame.Visible = false;
            configurationView.Visible = false;
            mainMenu.Visible = true;
        }

        private void ShowPrepareGame()
        {          
            mainMenu.Visible = false;
            prepareGame.Visible = true;
        }

        private void ShowConfiguration()
        {
            mainMenu.Visible = false;
            prepareGame.Visible = false;
            configurationView.Visible = true;
        }
    }
}
