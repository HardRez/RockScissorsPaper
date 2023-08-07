using Runtime.Context.Game.Scripts.Models.Panel;
using Runtime.Context.Game.Scripts.Models.Player;
using Runtime.Context.Game.Scripts.View.Greeting;
using strange.extensions.context.impl;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.Config
{
  public class GameContext : MVCSContext
  {
    public GameContext(MonoBehaviour view) : base(view)
    {
    }
    
    protected override void mapBindings()
    {
      base.mapBindings();

      injectionBinder.Bind<IPlayerModel>().To<PlayerModel>().ToSingleton();
      injectionBinder.Bind<IPanelModel>().To<PanelModel>().ToSingleton();
      
      mediationBinder.Bind<GreetingPanelView>().To<GreetingPanelMediator>();
    }
  }
}