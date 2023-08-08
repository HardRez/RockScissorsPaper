using StandardAssets.Promise;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.Models.Panel
{
  public interface IPanelModel
  {
    IPromise CreatePanel(string panelKey);
    IPromise CreatePanel(string panelKey, Transform parent);
  }
}