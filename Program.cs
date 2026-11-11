using Doga.Dolgozat;

const string FilePath = "..\\..\\..\\data\\videogames.csv";

List<Jatekok> ljatekok = [];

using StreamReader stream = new(FilePath);
_ = stream.ReadLine();
while (!stream.EndOfStream) ljatekok.Add(new(stream.ReadLine()));

//1
var hanynegyegeszotfolott = ljatekok.Count(j => j.Ertekeles > 4.5);
Console.WriteLine($"{hanynegyegeszotfolott} db játék több mint 4,5 csillagos értékelésű");

//2
var legtobbjatekos = ljatekok.Max(j => j.AktivJatekosok);
Console.WriteLine($"A legtöbben a: {legtobbjatekos}-al játszanak");

//3
//var vane2020elotti = ljatekok.Any(j => j.KiadasDatum < "2020-01-01");

//4
var atlagertekeles = ljatekok.Average(j => j.Ertekeles);
Console.WriteLine($"A játékok átlagos éertékelése: {atlagertekeles}");

//5 
var cybercity = ljatekok.Single(j => j.Cim == "Cyber City 2077");
Console.WriteLine($"Az egyetlen cybercity játék: {cybercity}");

//6

//7

//8
var atlagjatekosszam = ljatekok.Average(j => j.AktivJatekosok);

//9
//10