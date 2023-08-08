using strange.extensions.mediation.impl;

namespace Runtime.Context.Game.Scripts.View.Game
{
  public class GamePanelMediator : EventMediator
  {
    [Inject]
    public GamePanelView view { get; set; }

    public override void OnRegister()
    {
    }

    public override void OnRemove()
    {
    }
  }
}