using strange.extensions.mediation.impl;
using TMPro;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.View.Greeting
{
  public class GreetingPanelView : EventView
  {
    public TMP_InputField p1NameInput;
    
    public TMP_InputField p2NameInput;
    
    public void OnCheckAndContinueClick()
    {
      // Debug.Log("GreetingPanelView> OnCheckAndContinueClick");
      dispatcher.Dispatch(GreetingPanelEvent.CheckAndContinue);
    }
  }
}