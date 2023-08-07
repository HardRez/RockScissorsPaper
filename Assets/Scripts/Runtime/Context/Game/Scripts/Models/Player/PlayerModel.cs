using UnityEngine;

namespace Runtime.Context.Game.Scripts.Models.Player
{
  public class PlayerModel : IPlayerModel
  {
    private string _p1Name;
    
    private string _p2Name;

    private const int MaxNameLenght = 28;

    public bool CheckNameConditions(string p1Name, string p2Name)
    {
      // Debug.LogWarning("PlayerModel> CheckNameConditions");
      
      if (p1Name == string.Empty)
      {
        Debug.LogWarning("P1 name is empty");
        return false;
      }
      
      if (p2Name == string.Empty)
      {
        Debug.LogWarning("P2 name is empty");
        return false;
      }
      
      if (p1Name.Length > MaxNameLenght)
      {
        Debug.LogWarning("P1 name is too long (Max length is 28 char)");
        return false;
      }
      
      if (p2Name.Length > MaxNameLenght)
      {
        Debug.LogWarning("P2 name is too long (Max length is 28 char)");
        return false;
      }

      if (p1Name == p2Name)
      {
        Debug.LogWarning("P1 name same with P2 name");
        return false;
      }

      return true;
    }

    public void FillNames(string p1Name, string p2Name)
    {
      _p1Name = p1Name;
      _p2Name = p2Name;
      
      Debug.Log("P1 Name: " + _p1Name);
      Debug.Log("P2 Name: " + _p2Name);
    }
  }
}