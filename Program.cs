﻿/*Create un progetto App Console csharp-cibi-preferiti con VS2022.
Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
La lunghezza della classifica
La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Il vostro cibo top (prima posizione della classifica)
Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Le modalità di consegna sono le solite: repo GitHub, commit e push
BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.*/

string[] food = { "hot dog", "hamburger", "wagyu", "crudo di pesce", "carbonara"};

Console.WriteLine(food.Length);

for(var i = 0; i < food.Length; i++) {
    Console.WriteLine(i + "" + food[i]);
}

Console.WriteLine(food[0]);
Console.WriteLine(food[food.Length - 1]);


