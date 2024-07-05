// See https://aka.ms/new-console-template for more information

#region "Exercice1"


//int age = 15;

using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

/** Ecrivez un code pour vérifiez si un age on est majeur */
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

//App4();
#endregion

#region "Exo 1"
/** Contraintes:
 * - Stocker la saisi utilisateur dans une variable de type string.
 * - Utiliseé une structure if...else afin de retourner la réponse de l'utilisateur
 */
static void App5()
{
    //Renvoye True si la chaîne de caratère possède 1 caratère
    static bool isLetter(string str)
    {
        return str.Length == 1;
    }

    bool isEnd = false;
    while (!isEnd)
    {
        string lettre = Console.ReadLine().ToUpper();
        string voyelle = "AEIOUY";
        string consonne = "BCDFGHJKLMNPQRSTVWXZ";

        Console.WriteLine("--- La lettre est-elle une voyelle ? ---");
        Console.Write("\nEntrez une lettre : ");

        if (isLetter(lettre) && voyelle.Contains(lettre))
        {
            Console.WriteLine("Cette lettre est une voyelle !\n");
            isEnd = true;
        }
        else if (isLetter(lettre) && consonne.Contains(lettre))
        {
            Console.WriteLine("Cette lettre est une consonne !\n");
            isEnd = true;
        }
        else
        {
            Console.WriteLine("Votre saisi n'est pas une lettre !\n");
        }
    }
}
//App5();
#endregion

#region "Exo 2"
//Déclaration des variables c = capital, tdi = taux d'interet, dde = durée d'epargne, mdi = montant des intérêts et cf = capital final du type double
//Affichage des messages pour entrer les valeurs de capital (en euros), taux d'interet et durée epargne
//et reception des données : c/tdi/dde rentrée par l'utilisateur
//Calcul du montant des interets : mi = c * tdi * dde grace à la fonction 
//Affichage message résultats du montant des interet mdi + affichage de dde
//Affichage de message du capital final avec utilisation de la variable cf
//14 instructions
/**
bool fin = false;
double c, tdi, dde, mdi, cf;
while (!fin)
{
    ///if (c is null && tdi is null && dde is null && mdi is null && cf is null)
    Console.WriteLine("--- Calcul des intérets ---");
    Console.Write("\nEntrer le capital (en Euros) : ");
    string str_c = Console.ReadLine();
    bool existCapital = double.TryParse(str_c, out c);
    Console.Write("\nEntrer le taux interêt (en %) : ");
    string str_tdi = Console.ReadLine();
    bool existTaux_interet = double.TryParse(str_tdi, out tdi);
    Console.Write("\nEntrer la durée epargne (en Année(s)) : ");
    string str_dde = Console.ReadLine();
    bool existEpargne = double.TryParse(str_dde, out dde);

    double mi = c * (tdi / 100) * dde;
    Console.WriteLine("\nLe montant des intérêts est de " + mi + " euros sur " + dde + " ans.");
    cf = mi + c;
    Console.WriteLine("\nVotre somme de capital après " + dde + " ans est de " + cf + " euros.");
}*/
#endregion

#region "Exo4"
/**
int initNbTable = 1;
int initNbRows = 1;
int nbTable = 10;
int nbRows = 10;
string titre = "Les tables de multiplication";
string subTitle = "Table de ";
static string outputTable(int nb1, int nb2)
{
    return nb1 + " X " + nb2 + " = " +(nb1*nb2);
}

Console.WriteLine($"--- {titre} ---\n");

for(int i = initNbTable; i <= nbTable; i++)
{
    Console.WriteLine(subTitle + i + " :");
    for(int j = initNbRows; j <= nbRows; j++)
    {
        Console.WriteLine("        - " + outputTable(i,j));
    }
    Console.WriteLine("");
}*/
#endregion

#region "Exo5"
/** Objectif : Comprendre les fonctionnalités des structures conditionnelles For avec des variables int et double.
 * 
 * Faire un programme permettant de connaître, pour une saisie de 5 notes :
 * - la mailleure note
 * - la moins bonne note
 * - la moyenne des notes
 */
string titre = "Gestion des notes";
int nbInitNotes = 1;
int nbNotes = 5;
int nbEvaluation = 20;
List<int> notes = [];

Console.WriteLine($"--- {titre} ---\n");
Console.WriteLine($"Veuillez saisir {nbNotes} notes :\n");

for (int note = nbInitNotes; note <= nbNotes; note++)
{
    Console.Write($"   - Merci de saisir la note {note} (sur /{nbEvaluation}) : ");
    bool existNote = int.TryParse(Console.ReadLine(), out int nbNote);
    if (existNote && nbNote >= 0 && nbNote<=20)
    {
        notes.Add(nbNote);
    }
    else
    {
        Console.WriteLine("      Votre note n'est pas valide, on l'a prendra pas en considération.");
    }
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleur note est {notes.Max()}/{nbEvaluation}");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est {notes.Min()}/{nbEvaluation}");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne des notes est {notes.Average()}/{nbEvaluation}");

#endregion