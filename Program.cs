using sparbuch_loesung;

Sparbuch s1 = new("Hans Maier");

s1.Einzahlen(20);
s1.Einzahlen(30);
s1.Einzahlen(40);

Console.WriteLine("Es wurden {0} Beträge eingezahlt", s1.GetAnzahl());

Console.WriteLine("Guthaben: {0}", s1.GetGuthaben());
