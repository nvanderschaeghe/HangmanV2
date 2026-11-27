namespace HangmanV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int AMOUNT_OF_LIVES = 25;
            int currentLives = AMOUNT_OF_LIVES;
            const int NO_LIVES = 0;
            const int LOSE_A_LIFE = 1;
            List<string> guessedLetters = new List<string>();
            List<string> words = new List<string>();
            const int FIRST_INDEX_LIST = 0;
            const int LAST_INDEX_LIST = 4;
            words.Add("integer");
            words.Add("string");
            words.Add("networking");
            words.Add("cisco");
            words.Add("programming");
            Random rng = new Random();
            int randomNumber = rng.Next(FIRST_INDEX_LIST, LAST_INDEX_LIST);
            string randomWord = words[randomNumber];
            Console.WriteLine(randomWord);
            while (currentLives > NO_LIVES)
            {

                Console.WriteLine("Please type in a letter");
                string chosenLetter = Console.ReadLine();
                if (guessedLetters.Contains(chosenLetter))
                {
                    Console.WriteLine($"You already tried this letter, you do not lose a life. You have {currentLives} left ");
                    continue;
                }
                if (randomWord.Contains(chosenLetter))
                {
                    currentLives = currentLives - LOSE_A_LIFE;
                    guessedLetters.Add(chosenLetter);
                }
                else
                {
                    currentLives = currentLives - LOSE_A_LIFE;
                    Console.Write($"The word does not contain {chosenLetter}, you have {currentLives} lives left.");

                }

                Console.Clear();
                string guessedCharacterToScreen = "";
                foreach (char characterInWord in randomWord)
                {
                    if (guessedLetters.Contains(characterInWord.ToString()))
                    {
                        guessedCharacterToScreen += characterInWord;
                    }
                    else
                    {
                        guessedCharacterToScreen += "_";


                    }

                }

                Console.WriteLine(guessedCharacterToScreen);
                if (guessedCharacterToScreen == randomWord)
                {
                    Console.WriteLine("Congratulations! You guessed the right word.");
                    break;
                }
                if (!randomWord.Contains(chosenLetter))
                {
                    Console.Write($"The word does not contain {chosenLetter}, you have {currentLives} lives left.");
                }




            }


        }
    }
}
