﻿using System.Diagnostics;

//var blagues = File.ReadAllLines(args[0]);
//var random = new Random();
//var numero = random.Next(0, blagues.Length);
//var blague = blagues[numero];

var blague = @"
Un jour, trois hommes partent en excursion, lorsque soudainement ils
arrivent a une enorme riviere d‚chainee.
Il fallait absolument qu'ils se rendent de l'autre cote, mais
n'avaient aucune idee de la façon de la traverser.
Un des hommes pria Dieu en disant : ""SVP mon Dieu, donne-moi la
    force de traverser la riviere.""
POUF, Dieu lui donna de gros bras et des jambes tres puissantes,
    et il fut capable de traverser la riviere a la nage en 2 heures,
mais
    faillit se noyer a deux reprises.
    Voyant cela, le deuxieme homme pria lui aussi Dieu : ""SVP mon Dieu,
donne-moi la force ... et les outils pour traverser la riviere.""
 
POUF, Dieu lui donna une chaloupe et des avirons, et il put
traverser la rivière en 1 heure, mais faillit chavirer a deux
reprises.
    Le troisieme homme fort de l'experience de ses deux compagnons,
    decide lui aussi de prier Dieu : ""SVP mon Dieu, donne-moi la force,
les
    outils et l'intelligence pour traverser la riviere.""
POUF, Dieu le changea en femme. Elle verifia la carte, marcha
environ 200 metres en amont et traversa le pont.
 
    Envoyez ceci a une femme intelligente qui a besoin de rire et
aux hommes qui sont capables de s'en amuser meme si la realite est
    dure";

var processStartInfo = new ProcessStartInfo("espeak");
processStartInfo.ArgumentList.Add("-vfr");
processStartInfo.ArgumentList.Add(blague);
Console.WriteLine(blague);
Process.Start(processStartInfo)?.WaitForExit();
