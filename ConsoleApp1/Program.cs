// See https://aka.ms/new-console-template for more information

#region "Exercice1"
/** Ecrivez un code pour vérifiez si un age on est majeur */

//int age = 15;

static void EstMajeur(int age)
{
    if (age > 0)
    {
        string isAdult = "Vous êtes majeur";
        string isntAdult = "Vous n'êtes pas majeur";
        Console.WriteLine(age >= 18 ? isAdult : isntAdult);
    }
    else
    {
        Console.WriteLine("Veuillez écrire un age valide");
    }
}

//EstMajeur(age);


#endregion

#region "Exercice2"
/** Créez un menu pour connnaître si on est majeur */

/** test 1 
static void App()
{
    Console.WriteLine("Quel est votre age ?");
    int age = Convert.ToInt32(Console.ReadLine());
    EstMajeur(age);
}
*/
#endregion

#region "Exercice 3"
/**Ecrivez un programme qui nous affiche un texte pour nous demander l'age
 * et pouvoir saisir l'age dans le terminal
 * et de relancer le programme non infini mais qu'il nous donne une option de sortie de programme
 */
static void DisplayMenu()
{
    Console.WriteLine("\nChoisir une option:\n");
    Console.WriteLine("[1] : Quel est votre age?");
    Console.WriteLine("[2] : Sortie");
    Console.WriteLine("\nEntrez votre choix: ");
}

static void App3()
{
    bool isEnd = false;
    while (!isEnd)
    {
        DisplayMenu();
        bool isValidChoice = int.TryParse(Console.ReadLine(), out int choice);
        if (isValidChoice && choice == 1)
        {
            Console.WriteLine("Quel age avez-vous?");
            var age = Console.ReadLine();
            bool IsConvert = int.TryParse(age, out int result);
            if (IsConvert && result>=0)
            {
                EstMajeur(result);
            }
            else
            {
                Console.WriteLine("Veuillez écrire un age valide");
            }
        }
        else if (isValidChoice && choice == 2)
        {
            Console.WriteLine("Êtes vous sûre de quitter l'application? (Y/N)"); //ça doit marcher Y majuscule et minuscule
            var confirmation = Console.ReadLine()?.ToUpper()[0];
            if (confirmation == 'Y')
            {
                Console.WriteLine("Sortie de l'application...\n");
                isEnd = true;
            }
            //Console.Clear();
            continue;
        }
        else
        {
            Console.WriteLine("Choix invalide. Réssayer votre choix");
        }
    }
}

//App3();
#endregion

#region "Exercice 4"
/** Excercie 3 avec des switch
 */
static void DisplayMenuS()
{
    Console.WriteLine("\nChoisir une option:\n");
    Console.WriteLine("[1] : Quel est votre age?");
    Console.WriteLine("[2] : Sortie");
    Console.WriteLine("\nEntrez votre choix: ");
}

static void App4()
{
    bool isEnd = false;
    while (!isEnd)
    {
        DisplayMenuS();
        bool isValidChoice = int.TryParse(Console.ReadLine(), out int choice);
        switch (choice)
        {
            case 1:
                Console.WriteLine("Quel age avez-vous?");
                var age = Console.ReadLine();
                bool IsConvert = int.TryParse(age, out int ageNumber);
                if (IsConvert)
                {
                    EstMajeur(ageNumber);
                }
                else
                {
                    Console.WriteLine("Age invalide.");
                }
                break;
            case 2:
                Console.WriteLine("Êtes vous sûre de quitter l'application? (Y/N)");
                var confirmation = Console.ReadLine()?.ToUpper()[0];
                if (confirmation == 'Y')
                {
                    Console.WriteLine("Sortie de l'application...\n");
                    isEnd = true;
                }
                Console.Clear();
                continue;
            default:
                Console.WriteLine("Choix invalide. Réssayer votre choix");
                break;
        }
    }
}

App4();
#endregion