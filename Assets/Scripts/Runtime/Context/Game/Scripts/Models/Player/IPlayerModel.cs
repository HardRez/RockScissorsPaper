namespace Runtime.Context.Game.Scripts.Models.Player
{
  public interface IPlayerModel
  {
    bool CheckNameConditions(string p1Name, string p2Name);

    void FillNames(string p1Name, string p2Name);
  }
}