using System.Collections.Generic;
using Runtime.Context.Game.Scripts.Enum;
using UnityEngine;

namespace Runtime.Context.Game.Scripts.Models.Layer
{
  public class LayerModel : ILayerModel
  {
    private Dictionary<GameLayers, Transform> _layerMap;
    
    [PostConstruct]
    public void OnPostConstruct()
    {
      _layerMap = new Dictionary<GameLayers, Transform>();
    }
    
    public void AddLayer(GameLayers type, Transform container)
    {
      if (_layerMap.ContainsKey(type))
      {
        _layerMap[type] = container;
      }
      else
      {
        _layerMap.Add(type, container);
      }
    }

    public Transform GetLayer(GameLayers type)
    {
      if (!_layerMap.ContainsKey(type))
      {
        Debug.LogError("Layer type not found in this map. Layer: " + type);
        return null;
      }

      return _layerMap[type];
    }
  }
}