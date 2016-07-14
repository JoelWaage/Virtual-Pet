using System;
using System.Collections.Generic;

namespace VirtualPet.Objects
{
  public class Tam
  {
// Set strings
    private string _name;
    private int _hunger;
    private string _happy;
    private string _energy;
    private string _clean;

// Constructor
    public Tam (string newname, int hunger, string happy, string energy, string clean)
    {
      _name = newname;
      _hunger = hunger;
      _happy = happy;
      _energy = energy;
      _clean = clean;
    }
// Getters and Setters
    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetHunger(int newHunger)
    {
      _hunger = newHunger;
    }
    public string GetHunger()
    {
      _hunger = (_hunger - 2);
      return _hunger.ToString();
    }

    public void SetHappy(string newHappy)
    {
      _happy = newHappy;
    }
    public string GetHappy()
    {
      return _happy;
    }

    public void SetEnergy(string newEnergy)
    {
      _energy = newEnergy;
    }
    public string GetEnergy()
    {
      return _energy;
    }

    public void SetClean(string newClean)
    {
      _clean = newClean;
    }
    public string GetClean()
    {
      return _clean;
    }
  }
}
