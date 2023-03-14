using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lingo
{
    public partial class mainForm : Form
    {
        bool isPlaying = false;
        string gekozenWoord = string.Empty;
        int pogingen = 0;
        List<char> gekozenLetters = new List<char>();

        static string[] woorden = new string[]
{
        "appel",
        "banaan",
        "kat",
        "hond",
        "olifant",
        "bloem",
        "gitaar",
        "huis",
        "ijs",
        "jas",
        "kangoeroe",
        "citroen",
        "aap",
        "bal",
        "boot",
        "dans",
        "fiets",
        "klok",
        "koe",
        "lamp",
        "neus",
        "oor",
        "potlood",
        "stoel",
        "tijger",
        "vogel",
        "zee",
        "zwaan",
        "boom",
        "duim",
        "ei",
        "fles",
        "goud",
        "haar",
        "ijsbeer",
        "judo",
        "kaas",
        "leeuw",
        "muis",
        "noot",
        "olie",
        "paard",
        "regen",
        "schaap",
        "toren",
        "uier",
        "verf",
        "winkel",
        "xylofoon",
        "yoghurt",
        "zeep",
        "appeltaart",
        "brood",
        "chocolade",
        "diamant",
        "envelop",
        "friet",
        "groen",
        "haai",
        "ijsje",
        "jacht",
        "kruis",
        "laser",
        "molen",
        "nacht",
        "olijf",
        "pinda",
        "quiz",
        "rijst",
        "schelp",
        "toeter",
        "ui",
        "vlag",
        "wortel",
        "xylofoon",
        "yacht",
        "zeester",
        "aardbei",
        "bloemkool",
        "cavia",
        "dennenboom",
        "egel",
        "fazant",
        "giraffe",
        "hamer",
        "ijsberg",
        "judo",
        "kast",
        "luipaard",
        "muur",
        "nijlpaard",
        "olifantenpoot",
        "pauw",
        "quizzen",
        "raket",
        "spin",
        "tegel",
        "uil",
        "vleugel",
        "wafel",
        "xylofoons",
        "yoghurtijs",
        "zebraprint",
        "aapje",
        "berg",
        "champignon",
        "dak",
        "elektriciteit",
        "flamingo",
        "gazon",
        "hamburger",
        "ijsvogel",
        "jaguar",
        "kreeft",
        "lam",
        "marmot",
        "narcis",
        "olijfolie",
        "papegaai"

        };

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                isPlaying = false;
                mainButton.Text = "START";
                return;
            }
            if (!isPlaying)
            {
                isPlaying = true;
                mainButton.Text = "STOP";
                GameStart();
            }
        }
        private void GameStart()
        {
            Random r = new Random();

            // Reset
            outputTextBox.Clear();
            pogingen = 0;
            gekozenLetters.Clear();

            gekozenWoord = woorden[r.Next(0, woorden.Length)];
            outputTextBox.Text += gekozenWoord[0] + " ";
            gekozenLetters.Add(gekozenWoord[0]);
            for (int i = 1; i < gekozenWoord.Length; i++)
            {
                gekozenLetters.Add('_');
                outputTextBox.Text += gekozenLetters[i] + " ";
            }
            outputTextBox.Text += '\n';
        }

        private void inputTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if(pogingen == 5)
                {
                    MessageBox.Show("Je hebt verloren! Het woord was " + gekozenWoord, "Verloren", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isPlaying = false;
                    mainButton.Text = "START";
                }
                if (!isPlaying) return;

                pogingen++;
                string ingevoerdWoord = inputTxtBox.Text.ToLower().Trim(' ');

                if (ingevoerdWoord.Length != gekozenWoord.Length)
                {
                    MessageBox.Show("Gelieve hetzelfde een woord door te geven met hetzelfde aantal karakters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (gekozenWoord == ingevoerdWoord)
                {
                    MessageBox.Show("Je hebt het hele woord geraden in " + pogingen + " aantal poging(en)", "Gewonnen!", MessageBoxButtons.OK);
                    isPlaying = false;
                    mainButton.Text = "START";
                }

                for(int i = 0; i < ingevoerdWoord.Length; i++)
                {
                    if (ingevoerdWoord[i] == gekozenWoord[i])
                    {
                        gekozenLetters[i] = ingevoerdWoord[i];
                    }
                }

                for (int i = 0; i < ingevoerdWoord.Length; i++)
                {
                    if (gekozenWoord.Contains(ingevoerdWoord[i]) && !gekozenLetters.Contains(ingevoerdWoord[i]))
                    {
                        outputTextBox.Text += "\nHet woord bezit ergens de letter '" + ingevoerdWoord[i] + "' maar niet op die plek! \n";
                    }
                }


                for(int i = 0; i < gekozenLetters.Count;i++)
                {
                    outputTextBox.Text += gekozenLetters[i] + " ";
                }

                outputTextBox.Text += "\n";

                inputTxtBox.Clear();
            }
        }
    }
}
