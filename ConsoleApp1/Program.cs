// See https://aka.ms/new-console-template for more information

#region "Exercice1"
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
/**
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

//App3();*/
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
    bool isEnd = false;
    while (!isEnd)
    {
        string voyelle = "AEIOUY";
        string consonne = "BCDFGHJKLMNPQRSTVWXZ";

        Console.WriteLine("--- La lettre est-elle une voyelle ? ---");
        Console.Write("\nEntrez une lettre : ");
        string lettre = Console.ReadLine().ToUpper();

        if (lettre.Length == 1 && voyelle.Contains(lettre))
        {
            Console.WriteLine("Cette lettre est une voyelle !\n");
            isEnd = true;
        }
        else if (lettre.Length == 1 && consonne.Contains(lettre))
        {
            Console.WriteLine("Cette lettre est une consonne !\n");
            isEnd = true;
        }
        else
        {
            Console.WriteLine("\tVotre saisi n'est pas une lettre !\n");
        }
    }
}
//App5();
#endregion

#region "Exo 2"
/**
double capitalDepart, tauxInteret, dureeEpargne, interetAjouteeFinal = 0, capitalFinal = 0;
Console.WriteLine("--- Calcul des intérets ---\n");

Console.Write("Entrer le capital (en Euros) : ");
string str_c = Console.ReadLine();
bool existCapital = double.TryParse(str_c, out capitalDepart);

Console.Write("Entrer le taux interêt (en %) : ");
string str_tdi = Console.ReadLine();
bool existTaux_interet = double.TryParse(str_tdi, out tauxInteret);

Console.Write("Entrer la durée epargne (en Année(s)) : ");
string str_dde = Console.ReadLine();
bool existEpargne = double.TryParse(str_dde, out dureeEpargne);

capitalFinal += capitalDepart;
for (int i = 0; i < dureeEpargne; i++)
{
    double interetAjoutee = capitalFinal * (tauxInteret/100);
    capitalFinal += interetAjoutee;
    interetAjouteeFinal += interetAjoutee;
}

Console.WriteLine($"\nLe montant des intérêts est de {Math.Round(interetAjouteeFinal,2)} euros sur {dureeEpargne} ans.");
Console.WriteLine($"Le capital final sera de {Math.Round(capitalFinal,2)} euros.");
*/
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

/**
Console.WriteLine($"--- Les tables de multiplication ---\n");
for (int i = 1; i < 10 + 1; i++)
{
    Console.WriteLine($"Table de  {i} :");
    for (int j = 1; j < 10 + 1; j++)
    {
        Console.WriteLine($"\t- {i} x {j} = {i * j}");
    }
    Console.WriteLine("");
}
*/
#endregion

#region "Exo4 bis"
/**
double tauxAccroissement = 0.89 / 100;
int nbAnnee = 0;
double habitants = 96809;

Console.WriteLine($"--- Accroissement de population ---\n");
do
{
    habitants += habitants * tauxAccroissement;
    nbAnnee++;
} while (habitants < 120000);
Console.WriteLine($"Il faudra 25 ans, nous serons en {2015 + nbAnnee}");
Console.WriteLine($"Il y aura {Math.Floor(habitants)} habitants en {2015 + nbAnnee}");*/
#endregion

#region "Exo4 ter"
/**
Console.WriteLine("--- Menus et sous-menus ---\n");
Console.WriteLine("table des matières :\n");
for (int i = 1; i < 3 + 1; i++)
{
    Console.WriteLine($"\tChapitre {i}");
    for (int j = 1; j < 3 + 1; j++)
    {
        Console.WriteLine($"\t\t- Partie {i}.{j}");
    }
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
/**
string titre = "Gestion des notes";
int nbDebutNotes = 1;
int nbFinalNotes = 5;
int nbEvaluation = 20;
List<int> notes = [];

Console.WriteLine($"--- {titre} ---\n");
Console.WriteLine($"Veuillez saisir {nbFinalNotes} notes :\n");

for (int i = nbDebutNotes; i <= nbFinalNotes; i++)
{
    Console.Write($"   - Merci de saisir la note {i} (sur /{nbEvaluation}) : ");
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
*/

/**
 * List<int> notes = [];

Console.WriteLine("--- Gestion des notes ---\n");
Console.WriteLine($"Veuillez saisir 5 notes :\n");

for (int i = 1; i < 5+1; i++)
{
    Console.Write($"\t- Merci de saisir la note {i} (sur /20) : ");
    bool existNote = int.TryParse(Console.ReadLine(), out int nbNote);
    if (existNote && nbNote >= 0 && nbNote <= 20)
    {
        notes.Add(nbNote);
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tVotre note n'est pas valide!");
        Console.ForegroundColor = ConsoleColor.White;
        i--;
    }
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"La meilleur note est {notes.Max()}/20");

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La moins bonne note est {notes.Min()}/20");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"La moyenne des notes est {notes.Average()}/20");
*/
#endregion

#region "Exo6"
/** Objectif : Comprendre les foncitonnalités des structures conditionnelles While avec des variables int et bool.
 * 
 * Créer un programme permettant de trouver un nombre généré aleatoirement entre 1 et 50.
 * - Indiquez à l'utilisateur que le nombre mystère est soit plus grand ou plus petit que la saisie tant que la bonne réponse n'est pas trouvée.
 * - Pour déclarer un nombre aléatoire : Random aleatoire = new Random();
 * - Pour générer un nombre aléatoire après déclaration : int nbMystere = aleatoire.Next(1,51);
 * - Comptez le nombre de coups et l'afficher une fois la partie terminée.
 */
/**
int countHit = 0;
int a = 1;
int b = 50;
Random aleatoire = new Random();
int nbMystere = aleatoire.Next(a,b+1);
bool isEnd = false;

Console.WriteLine("--- Trouver le nombre mystère ---\n");
while(!isEnd)
{
    Console.Write("\tVeuillez sasir un nombre : ");
    bool existNbChoice = int.TryParse(Console.ReadLine(), out int nbChoice);
    if(existNbChoice && nbChoice < nbMystere)
    {
        countHit++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tLe nombre mystère est plus grand");
        Console.ForegroundColor= ConsoleColor.White;
    }
    else if (existNbChoice && nbChoice > nbMystere)
    {
        countHit++;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tLe nombre mystère est plus petit");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (existNbChoice && nbChoice == nbMystere)
    {
        countHit++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nBravo !!! Vous avez trouvé le nombre mystère !\n");
        Console.WriteLine($"Vous avez trouvé en {countHit} coups.\n");
        Console.ForegroundColor = ConsoleColor.White;
        isEnd = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Votre saisi de nombre est invalide, on vous comptera pas ce coups !");
        Console.ForegroundColor = ConsoleColor.White;
    }
}*/
#endregion

#region "Exo8"
//Moins de 20 lignes
/**
Console.WriteLine("--- Quelle taille dois-je prendre ? ---\n");

Console.Write("Entrez votre taille (en cm) : ");
bool isValidTaille = int.TryParse(Console.ReadLine(), out int taille);

Console.Write("Entrez votre poids (en kg) : ");
bool isValidPoids = int.TryParse(Console.ReadLine(), out int poids);

if (!isValidPoids || !isValidTaille || (taille < 145 && poids < 183) || (taille < 43 && poids < 77) || (taille >= 172 && poids < 48) || (taille >= 183 && poids < 54) || (taille < 160 && poids > 65) || (taille < 163 && poids > 71))
{
    Console.WriteLine("\nAucune taille ne vous correspond.");
} else if ((taille < 163 && poids < 66) || (taille < 166 && poids < 60) || (taille < 169 && poids < 54) || (taille < 172 && poids < 48))
{
    Console.WriteLine("\nPrenez la taille 1.");
} else if ((taille < 172 && poids < 72) || (taille < 175 && poids < 66) || (taille < 178 && poids < 60) || (taille < 183 && poids < 54))
{
    Console.WriteLine("\nPrenez la taille 2.");
} else 
{
    Console.WriteLine("\nPrenez la taille 3.");
}*/
#endregion

#region "Exo9"

static void inputNotes(List<int> notes)
{
    bool isEnd = false;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("--- Saisir les notes ---");
    Console.WriteLine("(999 pour stoper la saisie)\n");
    Console.ForegroundColor = ConsoleColor.White;
    do
    {
        Console.Write($"Merci de saisir la note {notes.Count+1} (sur /20) : ");
        bool isValidNote = int.TryParse(Console.ReadLine(), out int note);
        if (isValidNote && note >= 0 && note <=20)
        {
            notes.Add(note);
        }
        else if(isValidNote && note == 999)
        {
            Console.Clear();
            isEnd=true;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tErreur de saisie, la note est sur 20 !");
            Console.ForegroundColor = ConsoleColor.White;
        }
    } while (!isEnd);
}

static void maxNote(List<int> notes)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("------ La plus grande note ------\n");
    if (notes.Count > 0)
    {
        Console.WriteLine($"La note la plus grande est : {notes.Max()}/20\n");
    }
    else
    {
        Console.WriteLine($"Il n'y a pas de notes.");
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadKey();
    Console.Clear();
}

static void minNote(List<int> notes)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("------ La plus petite note ------\n");
    Console.WriteLine($"La note la plus petite est : {notes.Min()}/20\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadKey();
    Console.Clear();
}

static void averageNote(List<int> notes)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("------ La moyenne des notes ------\n");
    Console.WriteLine($"La moyenne est de : {notes.Average()} /20\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.ReadKey();
    Console.Clear();
}

static void displayMenu()
{
    List<int> notes = new List<int>();
    bool isEnd = false;
    do
    {
        Console.WriteLine("--- Gestion des notes avec menu ---\n");
        Console.WriteLine("1----Saisir les notes");
        Console.WriteLine("2----La plus grande note");
        Console.WriteLine("3----La plus petite note");
        Console.WriteLine("4----La moyenne des notes");
        Console.WriteLine("0----Quitter\n");
        Console.Write("Faites votre choix : ");
        bool isValidChoice = int.TryParse(Console.ReadLine(), out int choice);
        if (isValidChoice)
        {
            switch (choice)
            {
                case 0:
                    if (isValidChoice)
                    {
                        return;
                    }
                    else
                    {
                        break;
                    }
                case 1:
                    Console.Clear();
                    inputNotes(notes);
                    break;
                case 2:
                    Console.Clear();
                    maxNote(notes);
                    break;
                case 3:
                    Console.Clear();
                    minNote(notes);
                    break;
                case 4:
                    Console.Clear();
                    averageNote(notes);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tErreur de saisie, faites votre choix !\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        } else {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tErreur de saisie, faites votre choix !\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

    } while (!isEnd);
}
//displayMenu();
#endregion


string Welcome(string name, int yearsOld, int nbTravel, string[] foods, int yearToNextTravel)
{
    string pitch = $"Je suis {name}, j'ai {yearsOld} ans.\n";
    pitch += $"J'ai voyagé {nbTravel} fois.\n";
    pitch += "\nMes nourritures favorites sont :\n";
    foreach (var food in foods)
    {
        pitch += "\t- " + food+"\n";
    }
    pitch+=$"\nMon prochain voyage sera dans {yearToNextTravel} soit en {Convert.ToInt32(DateTime.Now.Year.ToString())+yearToNextTravel}!\n";
    return pitch;
}

Console.Write(Welcome("Angel", 24, 5, ["curry","ceviche","chilcano","aji de gallina","ramen"],1));