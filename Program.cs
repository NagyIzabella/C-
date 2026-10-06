// Príma nyereményjáték

Console.Write("Add meg a csoki gyartasi sorszamat: ");
int szam = int.Parse(Console.ReadLine());
bool prim_e = false;

for (int i = 2; i < szam; i++) {
    if (szam % i == 0) {
        prim_e = true;
        break;
    };
};

if (prim_e == false) {
    Console.WriteLine("Gratulalok, nyertel!");
}
else {
    Console.WriteLine("Sajnos nem nyert!");
}

// Páros számok összege

Console.Write("Az intervallum also vegpontja: ");
int also = int.Parse(Console.ReadLine());

Console.Write("Az intervallum felso vegpontja: ");
int felso = int.Parse(Console.ReadLine());

int osszeg = 0;

for (int i = also; i <= felso; i++){
    if (i % 2 == 0) {
        osszeg = osszeg + i;
    };
};

Console.WriteLine($"A(z) [{also}; {felso}] intervallumba eso paros szamok osszege: {osszeg}");

// Szorzótábla

for (int i = 1; i <= 10; i++) {
    for (int j = 1; j <= 10; j++) {
        Console.Write($"{j * i} ");
    };

    Console.WriteLine();
};