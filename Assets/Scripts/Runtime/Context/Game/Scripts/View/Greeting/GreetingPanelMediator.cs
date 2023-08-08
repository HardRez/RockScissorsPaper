using Runtime.Context.Game.Scripts.Enum;
using Runtime.Context.Game.Scripts.Models.Layer;
using Runtime.Context.Game.Scripts.Models.Panel;
using Runtime.Context.Game.Scripts.Models.Player;
using strange.extensions.mediation.impl;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.View.Greeting
{
  public enum GreetingPanelEvent
  {
    CheckAndContinue
  }
  public class GreetingPanelMediator : EventMediator
  {
    [Inject]
    public GreetingPanelView view { get; set; }
    
    [Inject]
    public IPlayerModel playerModel { get; set; }
    
    [Inject]
    public IPanelModel panelModel { get; set; }
    
    [Inject]
    public ILayerModel layerModel { get; set; }
    
    public override void OnRegister()
    {
      view.dispatcher.AddListener(GreetingPanelEvent.CheckAndContinue, OnCheckAndContinue);
    }

    private void OnCheckAndContinue()
    {
      // Debug.Log("GreetingPanelMediator> OnCheckAndContinue");

      string p1Name = view.p1NameInput.text;
      string p2Name = view.p2NameInput.text;
      
      if (playerModel.CheckNameConditions(p1Name, p2Name))
      {
        playerModel.FillNames(p1Name, p2Name);

        Transform parent = layerModel.GetLayer(GameLayers.InGameLayer);
        panelModel.CreatePanel("GamePanel", parent);
      }
    }

    public override void OnRemove()
    {
      view.dispatcher.RemoveListener(GreetingPanelEvent.CheckAndContinue, OnCheckAndContinue);
    }
  }
}