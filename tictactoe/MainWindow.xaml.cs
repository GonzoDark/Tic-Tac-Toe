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

namespace tictactoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int CROSSES = 1, NOUGHTS = 2;
        int user = CROSSES; //the first user = CROSSES, the second user = NOUGHTS
        bool gameOn = true;
        bool firstRoundUsed = false, secondRoundUsed = false;
        bool solution1used, solution2used, solution3used, solution4used, 
            solution5used, solution6used, solution7used, solution8used;
        bool aiOn = true; //enable to play against the computer (not optimized yet, it is quite stupid)
        
        int[,] intarray = new int[3, 3]; //all values are 0, if they are zero, then it should say click here
        public bool checkIfAllUsed()
        {
            if (intarray[0, 0] != 0 && intarray[0, 1] != 0 && intarray[0, 2] != 0 &&
                intarray[1, 0] != 0 && intarray[1, 0] != 0 && intarray[1, 2] != 0 &&
                intarray[2, 0] != 0 && intarray[2, 1] != 0 && intarray[2, 2] != 0)
            {
                return true;
            }
            else return false;
        }

        public bool twoOnARow()
        {
            if (solution1used != true) 
            {
                // if (A==B, while A and B are not empty and C empty)
                if (intarray[0, 0] == intarray[1, 0] && intarray[0, 0] != 0 && intarray[1, 0] != 0 && intarray[2, 0] == 0)
                {
                    changefield(label_2_0, btn_2_0, user); //Change C to hold the user value, if the above condition is true
                    intarray[2, 0] = 2;
                    solution1used = true;
                    return true;
                }
                // if (A==C, while A and C are not empty and B empty)
                else if (intarray[0, 0] == intarray[2, 0] && intarray[0, 0] != 0 && intarray[2, 0] != 0 && intarray[1, 0] == 0)
                {
                    changefield(label_1_0, btn_1_0, user);
                    intarray[1, 0] = 2;
                    solution1used = true;
                    return true;
                }
                // if (B==C, while B and C are not empty and A empty)
                else if (intarray[1, 0] == intarray[2, 0] && intarray[1, 0] != 0 && intarray[2, 0] != 0 && intarray[0, 0] == 0)
                {
                    changefield(label_0_0, btn_0_0, user);
                    intarray[0, 0] = 2;
                    solution1used = true;
                    return true;
                }
            }
            if (solution2used != true)
            {
                // if (D==E, while D and E are not empty and F empty)
                if (intarray[0, 1] == intarray[1, 1] && intarray[0, 1] != 0 && intarray[1, 1] != 0 && intarray[2, 1] == 0)
                {
                    changefield(label_2_1, btn_2_1, user); //Change C to hold the user value, if the above condition is true
                    intarray[2, 1] = 2;
                    solution2used = true;
                    return true;
                }
                // if (D==F, while D and F are not empty and E empty)
                else if (intarray[0, 1] == intarray[2, 1] && intarray[0, 1] != 0 && intarray[2, 1] != 0 && intarray[1, 1] == 0)
                {
                    changefield(label_1_1, btn_1_1, user);
                    intarray[1, 1] = 2;
                    solution2used = true;
                    return true;
                }
                // if (E==F, while E and F are not empty and D empty)
                else if (intarray[1, 1] == intarray[2, 1] && intarray[1, 1] != 0 && intarray[2, 1] != 0 && intarray[0, 1] == 0)
                {
                    changefield(label_0_1, btn_0_1, user);
                    intarray[0, 1] = 2;
                    solution2used = true;
                    return true;
                }

            }
            if (solution3used != true)
            {
                // if (G==H, while G and H are not empty and I empty)
                if (intarray[0, 2] == intarray[1, 2] && intarray[0, 2] != 0 && intarray[1, 2] != 0 && intarray[2, 2] == 0)
                {
                    changefield(label_2_2, btn_2_2, user); //Change C to hold the user value, if the above condition is true
                    intarray[2, 2] = 2;
                    solution3used = true;
                    return true;
                }
                // if (G==I, while G and I are not empty and H empty)
                else if (intarray[0, 2] == intarray[2, 2] && intarray[0, 2] != 0 && intarray[2, 2] != 0 && intarray[1, 2] == 0)
                {
                    changefield(label_1_2, btn_1_2, user);
                    intarray[1, 2] = 2;
                    solution3used = true;
                    return true;
                }
                // if (H==I, while H and I are not empty and G empty)
                else if (intarray[1, 2] == intarray[2, 2] && intarray[1, 2] != 0 && intarray[2, 2] != 0 && intarray[0, 2] == 0)
                {
                    changefield(label_0_2, btn_0_2, user);
                    intarray[0, 2] = 2;
                    solution3used = true;
                    return true;
                }

            }
            if (solution4used != true)
            {
                // if (A==D, while A and D are not empty and G empty)
                if (intarray[0, 0] == intarray[0, 1] && intarray[0, 0] != 0 && intarray[0, 1] != 0 && intarray[0, 2] == 0)
                {
                    changefield(label_0_2, btn_0_2, user); //Change C to hold the user value, if the above condition is true
                    intarray[0, 2] = 2;
                    solution4used = true;
                    return true;
                }
                // if (A==G, while A and G are not empty and D empty)
                else if (intarray[0, 0] == intarray[0, 2] && intarray[0, 0] != 0 && intarray[0, 2] != 0 && intarray[0, 1] == 0)
                {
                    changefield(label_0_1, btn_0_1, user);
                    intarray[0, 1] = 2;
                    solution4used = true;
                    return true;
                }
                // if (D==G, while D and G are not empty and A empty)
                else if (intarray[0, 1] == intarray[0, 2] && intarray[0, 1] != 0 && intarray[0, 2] != 0 && intarray[0, 0] == 0)
                {
                    changefield(label_0_0, btn_0_0, user);
                    intarray[0, 0] = 2;
                    solution4used = true;
                    return true;
                }
            }
            if (solution5used != true)
            {
                // if (B==E, while B and E are not empty and H empty)
                if (intarray[1, 0] == intarray[1, 1] && intarray[1, 0] != 0 && intarray[1, 1] != 0 && intarray[1, 2] == 0)
                {
                    changefield(label_1_2, btn_1_2, user); //Change C to hold the user value, if the above condition is true
                    intarray[1, 2] = 2;
                    solution5used = true;
                    return true;
                }
                // if (B==H, while B and H are not empty and E empty)
                else if (intarray[1, 0] == intarray[1, 2] && intarray[1, 0] != 0 && intarray[1, 2] != 0 && intarray[1, 1] == 0)
                {
                    changefield(label_1_1, btn_1_1, user);
                    intarray[1, 1] = 2;
                    solution5used = true;
                    return true;
                }
                // if (E==H, while E and H are not empty and B empty)
                else if (intarray[1, 1] == intarray[1, 2] && intarray[1, 1] != 0 && intarray[1, 2] != 0 && intarray[1, 0] == 0)
                {
                    changefield(label_1_0, btn_1_0, user);
                    intarray[1, 0] = 2;
                    solution5used = true;
                    return true;
                }
            }
            if (solution6used != true)
            {
                // if (C==F, while C and F are not empty and I empty)
                if (intarray[2, 0] == intarray[2, 1] && intarray[2, 0] != 0 && intarray[2, 1] != 0 && intarray[2, 2] == 0)
                {
                    changefield(label_2_2, btn_2_2, user); //Change C to hold the user value, if the above condition is true
                    intarray[2, 2] = 2;
                    solution6used = true;
                    return true;
                }
                // if (C==I, while C and I are not empty and F empty)
                else if (intarray[2, 0] == intarray[2, 2] && intarray[2, 0] != 0 && intarray[2, 2] != 0 && intarray[2, 1] == 0)
                {
                    changefield(label_2_1, btn_2_1, user);
                    intarray[2, 1] = 2;
                    solution6used = true;
                    return true;
                }
                // if (F==I, while F and I are not empty and C empty)
                else if (intarray[2, 1] == intarray[2, 2] && intarray[2, 1] != 0 && intarray[2, 2] != 0 && intarray[2, 0] == 0)
                {
                    changefield(label_2_0, btn_2_0, user);
                    intarray[2, 0] = 2;
                    solution6used = true;
                    return true;
                }
            }
            if (solution7used != true)
            {
                // if (A==E, while A and E are not empty and I empty)
                if (intarray[0, 0] == intarray[1, 1] && intarray[0, 0] != 0 && intarray[1, 1] != 0 && intarray[2, 2] == 0)
                {
                    changefield(label_2_2, btn_2_2, user); //Change C to hold the user value, if the above condition is true
                    intarray[2, 2] = 2;
                    solution7used = true;
                    return true;
                }
                // if (A==I, while A and I are not empty and E empty)
                else if (intarray[0, 0] == intarray[2, 2] && intarray[0, 0] != 0 && intarray[2, 2] != 0 && intarray[1, 1] == 0)
                {
                    changefield(label_1_1, btn_1_1, user);
                    intarray[1, 1] = 2;
                    solution7used = true;
                    return true;
                }
                // if (E==I, while E and I are not empty and A empty)
                else if (intarray[1, 1] == intarray[2, 2] && intarray[1, 1] != 0 && intarray[2, 2] != 0 && intarray[0, 0] == 0)
                {
                    changefield(label_0_0, btn_0_0, user);
                    intarray[0, 0] = 2;
                    solution7used = true;
                    return true;
                }
            }
            if (solution8used != true)
            {
                // if (C==E, while C and E are not empty and G empty)
                if (intarray[2, 0] == intarray[1, 1] && intarray[2, 0] != 0 && intarray[1, 1] != 0 && intarray[0, 2] == 0)
                {
                    changefield(label_0_2, btn_0_2, user); //Change C to hold the user value, if the above condition is true
                    intarray[0, 2] = 2;
                    solution8used= true;
                    return true;
                }
                // if (C==G, while C and G are not empty and E empty)
                else if (intarray[2, 0] == intarray[0, 2] && intarray[2, 0] != 0 && intarray[0, 2] != 0 && intarray[1, 1] == 0)
                {
                    changefield(label_1_1, btn_1_1, user);
                    intarray[1, 1] = 2;
                    solution8used = true;
                    return true;
                }
                // if (E==G, while E and G are not empty and C empty)
                else if (intarray[1, 1] == intarray[0, 2] && intarray[1, 1] != 0 && intarray[0, 2] != 0 && intarray[2, 0] == 0)
                {
                    changefield(label_2_0, btn_2_0, user);
                    intarray[2, 0] = 2;
                    solution8used = true;
                    return true;
                }
                else return false;
            }

            else return false;
        }
        public bool firstMoveCorners()
        {
            firstRoundUsed = true;
            if (intarray[0, 0] == CROSSES || intarray[2, 0] == CROSSES || 
                intarray[0, 2] == CROSSES || intarray[2, 2] == CROSSES)
            {
                intarray[1, 1] = 2;
                changefield(label_1_1, btn_1_1, user); //Check if the user uses A C G or I as the first move
                return true;
            }           
            
            else return false;

            
        }
        public bool checkInnerBlocks()
        {
            secondRoundUsed = true;
            if (intarray[1, 0] == 0)
            {
                intarray[1, 0] = 2;
                changefield(label_1_0, btn_1_0, user); //Check if the user uses A C G or I as the first move
                return true;
            }
            if (intarray[0, 1] == 0)
            {
                intarray[0, 1] = 2;
                changefield(label_0_1, btn_0_1, user); //Check if the user uses A C G or I as the first move
                return true;
            }
            if (intarray[2, 1] == 0)
            {
                intarray[2, 1] = 2;
                changefield(label_2_1, btn_2_1, user); //Check if the user uses A C G or I as the first move
                return true;
            }
            if (intarray[1, 2] == 0)
            {
                intarray[1, 2] = 2;
                changefield(label_1_2, btn_1_2, user); //Check if the user uses A C G or I as the first move
                return true;
            }

            else return false;
        }

        public void aiSelect()
        {
            user = changeuser(user); //change user focus to the ai
            bool foundTwoInARow = twoOnARow();
            bool foundFirstMoveCorners = false;
            bool foundSecondRound = false;

            if (foundTwoInARow == false && firstRoundUsed == true && secondRoundUsed == false)
            {
                foundSecondRound = checkInnerBlocks();
            }
            
            
            if (firstRoundUsed == false)
            { 
            foundFirstMoveCorners = firstMoveCorners();
            }
            //firstmove: check roundnumber, check for optimal placement, place
            if (foundTwoInARow != true && foundFirstMoveCorners == false && foundSecondRound == false) // 
            {
                if (intarray[1, 1] == 0)
                {
                    intarray[1, 1] = 2;
                    changefield(label_1_1, btn_1_1, user);
                }
                else if (intarray[0, 0] == 0)
                {
                    intarray[0, 0] = 2;
                    changefield(label_0_0, btn_0_0, user);
                }
                else if (intarray[2, 0] == 0)
                {
                    intarray[2, 0] = 2;
                    changefield(label_2_0, btn_2_0, user);
                }
                else if (intarray[0, 2] == 0)
                {
                    intarray[0, 2] = 2;
                    changefield(label_0_2, btn_0_2, user);

                }
                else if (intarray[2, 2] == 0)
                {
                    intarray[2, 2] = 2;
                    changefield(label_2_2, btn_2_2, user);
                }
                else if (intarray[1, 0] == 0)
                {
                    intarray[1, 0] = 2;
                    changefield(label_1_0, btn_1_0, user);
                }
                else if (intarray[0, 1] == 0)
                {
                    intarray[0, 1] = 2;
                    changefield(label_0_1, btn_0_1, user);
                }
                else if (intarray[1, 2] == 0)
                {
                    intarray[1, 2] = 2;
                    changefield(label_1_2, btn_1_2, user);
                }
                else if (intarray[2, 1] == 0)
                {
                    intarray[2, 1] = 2;
                    changefield(label_2_1, btn_2_1, user);
                }
                else
                {

                }   
            }
        }
        public bool checkWin()
        {
            if (intarray[0, 0] == user && intarray[0, 1] == user && intarray[0, 2] == user ||
             intarray[1, 0] == user && intarray[1, 1] == user && intarray[1, 2] == user ||
             intarray[2, 0] == user && intarray[2, 1] == user && intarray[2, 2] == user || 
             intarray[0, 0] == user && intarray[1, 0] == user && intarray[2, 0] == user ||
             intarray[0, 1] == user && intarray[1, 1] == user && intarray[2, 1] == user ||
             intarray[0, 2] == user && intarray[1, 2] == user && intarray[2, 2] == user ||
             intarray[0, 0] == user && intarray[1, 1] == user && intarray[2, 2] == user || 
             intarray[0, 2] == user && intarray[1, 1] == user && intarray[2, 0] == user)
            {
                return true;
            }
            else return false;
        }

        public void endGame()
        {

            if (checkWin() == true)
            {
                btn_restart.Visibility = Visibility.Visible;
                label_currentuser.Content = "Congrats! User " + user + " has won the game!";
                gameOn = false;
            }
            else if (checkIfAllUsed() == true)
            {
                btn_restart.Visibility = Visibility.Visible;
                label_currentuser.Content = "Noone won this round.";
                gameOn = false;

            }

            else
            {
                
                if (aiOn == true)
                {

                    aiSelect();
                    if (checkWin() == true)
                    {
                        btn_restart.Visibility = Visibility.Visible;
                        label_currentuser.Content = "Congrats! User " + user + " has won the game!";
                        gameOn = false;
                    }

                }
                if (checkWin() != true)
                {
                    user = changeuser(user);
                } 
                
            }

        }

        public int changeuser(int user)
        {
            if (user == CROSSES)
            {
                label_currentuser.Content = "It is user 2's turn";
                return NOUGHTS;
            }
            else
            {
                label_currentuser.Content = "It is user 1's turn";
                return CROSSES;
            }

        }

        public bool changefield(Label l ,Button b, int user)
        {
            // b.Visibility = Visibility.Hidden; // make the buttons disappear
            label_notice.Visibility = Visibility.Hidden;

            if (l.Visibility == Visibility.Visible && gameOn) //check if the field is used and if the game is still on
            {
                label_notice.Visibility = Visibility.Visible;
                label_notice.Content = "Hey, that field is already taken!";
                return false;
            }

            else if (user == CROSSES && gameOn) //change the current user from crosses to nought
            {
                l.Visibility = Visibility.Visible;
                l.Content = "X";
                return true;
            }
            else if (user == NOUGHTS && gameOn) //change the current user from nought to crosses
            {
                l.Visibility = Visibility.Visible;
                l.Content = "O";
                return true;
            }
            else return false; //I can't make the above statement a "else", as it will not check for 'gameOn'.

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_0_0_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_0_0, btn_0_0, user) == true)
            {
                intarray[0, 0] = user; //store the user (Nought or Crosses) value into the array
                endGame(); //check if someone has won, check if all fields are used, change user if both are false
            }
                
        }

        private void btn_1_0_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_1_0, btn_1_0, user) == true)
            {
                intarray[1, 0] = user;
                endGame(); 
            }
            
        }

        private void btn_2_0_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_2_0, btn_2_0, user) == true)
            {
                intarray[2, 0] = user;
                endGame();
            }
        }

        private void btn_0_1_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_0_1, btn_0_1, user) == true)
            {
                intarray[0, 1] = user;
                endGame();
            }
        }

        private void btn_1_1_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_1_1, btn_1_1, user) == true)
            {
                intarray[1, 1] = user;
                endGame();
            }
        }

        private void btn_2_1_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_2_1, btn_2_1, user) == true)
            {
                intarray[2, 1] = user;
                endGame();
            }
        }

        private void btn_0_2_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_0_2, btn_0_2, user) == true)
            {
                intarray[0, 2] = user;
                endGame();
            }
        }

        private void btn_1_2_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_1_2, btn_1_2, user) == true)
            {
                intarray[1, 2] = user;
                endGame();
            }
        }

        private void btn_2_2_Click(object sender, RoutedEventArgs e)
        {
            if (changefield(label_2_2, btn_2_2, user) == true)
            {
                intarray[2, 2] = user;
                endGame();
            }
        }

        private void btn_restart_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            aiOn = false;
            // difficulty();
            /* pop-up that promts the user to select difficulty (easy, medium, hard, impossible)
             * depending on their pick, the solutionXused variable will be set to true or false:
             * 
             * Easy: solution4 to solution8 will be set to true (so it will not check those)
             * Medium: solution6 to solution8 will be set to true (so it will not check those)
             * Hard: solution8 will be set to true (so it will not check that one)
             * Impossible: All solutions will be set to false, so the user will have no chance to win
            */

        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            aiOn = true;
            // difficulty();
        }

    }
}
