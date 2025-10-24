using System;
using System.Diagnostics;

namespace Tlapohualli;

/// <summary>
/// This program converts integer number names (base 10) to their Nahuatl translation (base 20).
/// </summary>
class Program
{
    public static int Main()
    {
        Log.Info("-----------------");
        Log.Info("-- TLAPOHUALLI --");
        Log.Info("-----------------");

        Resources r = Resources.ChooseLanguage();
        Log.Info(r.SelectedLanguage);

        Log.Info(r.TypeANumberToGetItsName);
        Log.Info(r.TypeQuitToExitProgram);
        Log.Info(r.MustBeANumberBetween);

        string selection = string.Empty;
        while (!selection.Equals(r.Quit, StringComparison.InvariantCultureIgnoreCase))
        {
            Console.Write($"{r.Number}: ");
            selection = Console.ReadLine();
            if (selection.Equals(r.Quit, StringComparison.InvariantCultureIgnoreCase))
            {
                break;
            }
            if (!int.TryParse(selection, out int number))
            {
                Log.Error(r.MustBeANumberBetween);
            }
            else if (number >= Translator.MinNumber && number <= Translator.MaxNumber)
            {
                string translation = Translator.Translate(number);
                Log.Success($"{r.NumberInNahuatl}: {translation}");
            }
            else
            {
                Log.Error(r.MustBeANumberBetween);
            }
        }

        Log.Info(r.Goodbye);
        return 0;
    }
}
