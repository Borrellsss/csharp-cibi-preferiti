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

string[] food = { "hot dog", "hamburger", "wagyu", "crudo di pesce", "carbonara", "random food"};

Console.WriteLine("lunghezza array:" + "" + food.Length);

for(var i = 0; i < food.Length; i++) {
    if(i == 0) {
        Console.WriteLine("elementi array:");
    }
    Console.WriteLine(i + "" + food[i]);
}

Console.WriteLine("primo elemento:" + "" + food[0]);
Console.WriteLine("ultimo elemento:" + "" + food[food.Length - 1]);

/*Bonus*/
if(food.Length % 2 == 0) {
    Console.WriteLine("i due elementi mediani se l'array ha lunghezza pari:");
    Console.WriteLine((food.Length / 2) - 1 + "" + food[(food.Length / 2) - 1]);
    Console.WriteLine(food.Length / 2 + "" + food[food.Length / 2]);
} else {
    Console.WriteLine("il singolo elemento mediano se l'array ha lunghezza dispari:");
    Console.WriteLine(food.Length / 2 + "" + food[food.Length / 2]);
} 