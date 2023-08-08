using Runtime.Context.Game.Scripts.Enum;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.Models.Layer
{
  public interface ILayerModel
  {
    void AddLayer(GameLayers type, Transform container);
    
    Transform GetLayer(GameLayers type);
  }
}