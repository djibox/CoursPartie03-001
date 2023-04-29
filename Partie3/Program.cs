int PrixProduit = 1250;
int QuantiteProduit = 100;
const int tva = 18;

int MontantHorsTaxe = PrixProduit * QuantiteProduit;
int MontantTva = MontantHorsTaxe * tva /100;
int MontantTtc = MontantHorsTaxe + MontantTva;

Console.WriteLine($"Présentation du produit");
Console.WriteLine($"Prix d'achat : {PrixProduit}, quantité achetée : {QuantiteProduit}, Tva : {tva}");
Console.WriteLine($"Le montant hors taxe est : {MontantHorsTaxe}");
Console.WriteLine($"Le montant de la TVA est : {MontantTva}");
Console.WriteLine($"Le montant de la toute taxe comprise est : {MontantTtc}");