using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public MainWindow()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();

            SetUpGame();
            
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {"😈","😈",
            "😝","😝",
            "😒","😒",
            "🐉","🐉",
            "🐳","🐳",
            "🙈","🙈",
            "👻","👻",
            "🐙","🐙"
            };

            Random random = new Random();
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next( animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                textBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }

        TextBlock lastTextBlockClikcked;
        bool findingMatch = false;
        private void TextBlock_MouseDown(object sender,MouseButtonEventArgs e)
        {
            TextBlock? textBlock = sender as TextBlock;
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            if (findingMatch == false)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                textBlock.Visibility = Visibility.Hidden;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                lastTextBlockClikcked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClikcked.Text)
            {
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClikcked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }
    }
}
