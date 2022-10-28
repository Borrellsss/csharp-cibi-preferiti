/*Create un progetto App Console csharp-cibi-preferiti con VS2022.
Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
La lunghezza della classifica
La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Il vostro cibo top (prima posizione della classifica)
Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Le modalità di consegna sono le solite: repo GitHub, commit e push
BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.*/

/*string[] food = { "hot dog", "hamburger", "wagyu", "crudo di pesce", "carbonara", "random food" };

Console.WriteLine("lunghezza array:" + "" + food.Length);

for (var i = 0; i < food.Length; i++)
{
    if (i == 0)
    {
        Console.WriteLine("elementi array:");
    }
    Console.WriteLine(i + "" + food[i]);
}

Console.WriteLine("primo elemento:" + "" + food[0]);
Console.WriteLine("ultimo elemento:" + "" + food[food.Length - 1]);*/

/*Bonus*/
/*if (food.Length % 2 == 0)
{
    Console.WriteLine("i due elementi mediani se l'array ha lunghezza pari:");
    Console.WriteLine((food.Length / 2) - 1 + "" + food[(food.Length / 2) - 1]);
    Console.WriteLine(food.Length / 2 + "" + food[food.Length / 2]);
}
else
{
    Console.WriteLine("il singolo elemento mediano se l'array ha lunghezza dispari:");
    Console.WriteLine(food.Length / 2 + "" + food[food.Length / 2]);
}*/

/*Istruzioni condizionali*/

/*Snack1:
    L’utente inserisce due numeri in successione.
    Il software stampa il maggiore.*/

/*Console.WriteLine("inserisci due numeri:");

int firstUserNumber = Convert.ToInt32(Console.ReadLine());

int secondUserNumber = Convert.ToInt32(Console.ReadLine());

if (firstUserNumber > secondUserNumber)
{
    Console.WriteLine(firstUserNumber);
}
else
{
    Console.WriteLine(secondUserNumber);
}*/


/*Snack2:
    L’utente inserisce due parole in successione.
    Il software stampa prima la parola più corta, poi la parola più lunga.*/

/*Console.WriteLine("inserisci due parole:");

string firstUserWord = Console.ReadLine();

string secondUserWord = Console.ReadLine();

if (firstUserWord.Length > secondUserWord.Length)
{
    Console.WriteLine(secondUserWord);
    Console.WriteLine(firstUserWord);
}
else
{
    Console.WriteLine(firstUserWord);
    Console.WriteLine(secondUserWord);
}*/

/*Ciclo for*/

/*Snack3:
    Il software deve chiedere per 10 volte all’utente di inserire un numero.
    Il programma stampa la somma di tutti i numeri inseriti.*/

/*Console.WriteLine("inserisci 10 numeri");

int sum = 0;

for (int i = 0; i < 10; i++)
{
    int userNumber = Convert.ToInt32(Console.ReadLine());
    sum += userNumber;
}

Console.WriteLine(sum);*/

/*Snack4:
    Calcola la somma e la media dei numeri da 2 a 10.*/

/*int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);
Console.WriteLine(numbers.Length);

int averageNumber = sum / numbers.Length;

Console.WriteLine(averageNumber);*/

/*Operatore modulo*/

/*Snack5:
    Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,
    stampa il numero, se è dispari, stampa il numero successivo.*/

/*Console.WriteLine("inserisci un numero");

int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber % 2 == 0)
{
    Console.WriteLine(userNumber);
}
else
{
    Console.WriteLine(userNumber + 1);
}*/

/*Array*/

/*Snack6:
    In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
    Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.*/

/*string[] partyPeopleList = { "marco", "mattia", "federico", "francesca", "stella" };

Console.WriteLine("dimmi il tuo nome");

string userName = Console.ReadLine();

bool isUserInList = false;

for (int i = 0; i < partyPeopleList.Length; i++)
{

    if (userName == partyPeopleList[i])
    {
        isUserInList = true;
        break;
    }
}

if (isUserInList)
{
    Console.WriteLine("benvenuto/a alla grande festa!");
}
else
{
    Console.WriteLine("mi spiace ma il tuo nome non è presente nella lista dei partecipanti");
}*/

/*Snack7:
    Crea un array vuoto.
    Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.*/

int[] newArray = new int[6];

int currentPosition = 0;

Console.WriteLine("inserisci 6 numeri");

for (int i = 0; i < newArray.Length; i++)
{
    int userNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"elemento dell'array prima della modifica: {i} - {newArray[i]}");

    if (userNumber % 2 != 0)
    {
        newArray[currentPosition] = userNumber;
        Console.WriteLine($"elemento dell'array dopo la modifica: {currentPosition} - {newArray[currentPosition]}");
        currentPosition++;
    }
}

Console.Write("[");

for (int i = 0; i < newArray.Length; i++)
{

    if (i < newArray.Length - 1)
    {
        Console.Write($"{newArray[i]},");
    }
    else
    {
        Console.Write($"{newArray[i]}");
    }
}

Console.Write("]");

/*Snack8:
    Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.*/

/*int[] newArray = {1,2,3,4,5,6,7,8,9,10};
int sum = 0;

for(int i = 0; i < newArray.Length; i++) {
    if(i % 2 != 0) {
        sum += newArray[i];
    }
}

Console.WriteLine(sum);*/

/*Ciclo while*/

/*Snack9:
    Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
    Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
    somma degli elementi è minore di 50.*/

/*int[] newArray = new int[50];
int sum = 0;
int counter = 0;

Console.WriteLine("inserisci tanti numeri finchè la loro somma è minore di 50");

while(sum < 50) {
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber > 0) {
        newArray[counter] = userNumber;
        sum += userNumber;
        counter++;
    } else {
        Console.WriteLine("devi inserire solo numeri maggiori di 0!");
    }
}*/

/*Random*/

/*Snack10:
    Fai inserire un numero, che chiameremo N, all’utente.
    Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
    Ogni volta che ne crei uno, stampalo a schermo.*/

/*using System;

Console.WriteLine("inserisci un numero");

int userNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < userNumber; i++) {
    int[] randomArray = new int[10];
    Console.WriteLine($"array numero: {i + 1}");

    for (int j = 0; j < randomArray.Length; j++) {
        Random randomNumber = new Random();
        int newRandomNumber = randomNumber.Next(1, 100);
        randomArray[j] = newRandomNumber;
        Console.WriteLine($"{j} - {randomArray[j]}");
    }
}*/