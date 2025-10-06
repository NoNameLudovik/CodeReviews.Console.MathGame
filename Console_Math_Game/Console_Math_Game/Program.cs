// This is my first C# program named Math_Game
// Gameplay: Player choose mode and solve 5 math expression
// Structure: 
/* 1. When game is launched it shows a menu
   2. It has 4 play modes (addition, subtraction, multiplication, division) 
   3. In every mode player get scores for every solved experession
   4. When game is finished program shows result and back player to menu */
/* Chalanges: 
   1. Showing game history
   2. Different difficulties */

using ConsoleMathGame;

Menu menu = new Menu();

menu.ShowMenu();