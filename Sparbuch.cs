using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sparbuch_loesung;

public class Sparbuch
{
    decimal _guthaben = 0;
    string _besitzer;
    List<decimal> _betrag = new();

    public Sparbuch(string besitzer)
    {
        _besitzer = besitzer;
    }
    public void Einzahlen(decimal betrag)
    {
        _guthaben = betrag + _guthaben;
        _betrag.Add(betrag);
    }
    public int GetAnzahl()
    {
        return _betrag.Count();
    }
    public decimal GetGuthaben()
    {
        return _guthaben;
    }
    public string GetBesitzer()
    {
        return _besitzer;
    }
}
