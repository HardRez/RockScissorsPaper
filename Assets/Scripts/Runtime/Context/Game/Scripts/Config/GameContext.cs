using Runtime.Context.Game.Scripts.Models.Layer;
using Runtime.Context.Game.Scripts.Models.Panel;
using Runtime.Context.Game.Scripts.Models.Player;
using Runtime.Context.Game.Scripts.View.Game;
using Runtime.Context.Game.Scripts.View.Greeting;
using Runtime.Context.Game.Scripts.View.Layer;
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
      injectionBinder.Bind<ILayerModel>().To<LayerModel>().ToSingleton();
      
      mediationBinder.Bind<GreetingPanelView>().To<GreetingPanelMediator>();
      mediationBinder.Bind<GamePanelView>().To<GamePanelMediator>();
      mediationBinder.Bind<LayerView>().To<LayerMediator>();
    }
  }
}