using System;
using System.Diagnostics;

namespace Tlapohualli;

public class Resources
{
    private readonly Language _language;

    private Resources(Language language)
    {
        if (language is <= Language.Unknown or > Language.English)
        {
            throw LanguageOutOfRange();
        }
        _language = language;
    }

    public static Resources ChooseLanguage()
    {
        Language language = Language.Unknown;
        while (true)
        {
            Log.Info("Elija un idioma / Choose a language:");
            Log.Info("- 1 Español");
            Log.Info("- 2 English");
            Log.Info("- 0 Salir / Quit");

            Console.Write("Selección / Selection [0,1,2]: ");
            string lang = Console.ReadLine();
            if (int.TryParse(lang, out int langNum))
            {
                if (langNum == 0)
                {
                    Log.Info("Adiós / Goodbye!");
                    Environment.Exit(0);
                }
                else if (langNum < 0 || langNum > 2)
                {
                    Log.Error("Selección inválida. Intente de nuevo. / Invalid selection. Try again.");
                }
                else
                {
                    language = (Language)langNum;
                    break;
                }
            }
            else
            {
                Log.Error("Lo que escribió no es un número. Intente de nuevo. / What you typed is not a number. Try again.");
            }
        }
        Debug.Assert(language != Language.Unknown);

        return new Resources(language); ;
    }

    public string Quit => _language switch
    {
        Language.Spanish => "salir",
        Language.English => "quit",
        _ => throw LanguageOutOfRange(),
    };
    public string SelectedLanguage => _language switch
    {
        Language.Spanish => "Idioma seleccionado: Español",
        Language.English => "Selected language: English",
        _ => throw LanguageOutOfRange(),
    };

    public string TypeANumberToGetItsName => _language switch
    {
        Language.Spanish => "Escriba un número para obtener su nombre en náhuatl:",
        Language.English => "Type a number to get its name in Nahuatl:",
        _ => throw LanguageOutOfRange(),
    };

    public string MustBeANumberBetween => _language switch
    {
        Language.Spanish => $"Debe ser un número entre {Translator.MinNumber} y {Translator.MaxNumber}.",
        Language.English => $"Must be a number between {Translator.MinNumber} and {Translator.MaxNumber}.",
        _ => throw LanguageOutOfRange(),
    };

    public string Goodbye => _language switch
    {
        Language.Spanish => "¡Adiós!",
        Language.English => "Goodbye!",
        _ => throw LanguageOutOfRange(),
    };

    public string Number => _language switch
    {
        Language.Spanish => "Número",
        Language.English => "Number",
        _ => throw LanguageOutOfRange(),
    };

    public string TypeQuitToExitProgram => _language switch
    {
        Language.Spanish => $"Escriba '{Quit}' para salir del programa.",
        Language.English => $"Type '{Quit}' to exit the program.",
        _ => throw LanguageOutOfRange(),
    };

    public string NumberInNahuatl => _language switch
    {
        Language.Spanish => "Número en náhuatl",
        Language.English => "Number in Nahuatl",
        _ => throw LanguageOutOfRange(),
    };

    private ArgumentOutOfRangeException LanguageOutOfRange() => new(
            nameof(_language),
            _language,
            "Invalid language selection.");
}
