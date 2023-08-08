using System;
using StandardAssets.Promise;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Runtime.Context.Game.Scripts.Models.Panel
{
  public class PanelModel : IPanelModel
  {
    public IPromise CreatePanel(string panelKey)
    {
      Promise promise = new();

      AsyncOperationHandle<GameObject> handle = Addressables.InstantiateAsync(panelKey);

      handle.Completed += PanelReady;
      
      return promise;
    }

    public IPromise CreatePanel(string panelKey, Transform parent)
    {
      Promise promise = new();

      AsyncOperationHandle<GameObject> handle = Addressables.InstantiateAsync(panelKey, parent);

      handle.Completed += (obj) =>
      {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
          Debug.Log("Panel created");
          // obj.Result
          promise.Resolve();
        }
        else
        {
          promise.Reject(new Exception("Panel couldn't created"));
        }
      };

      return promise;
    }

    private void PanelReady(AsyncOperationHandle<GameObject> obj)
    {
      if (obj.Status == AsyncOperationStatus.Succeeded)
      {
        Debug.Log("Panel created");
        // obj.Result
      }
      else
      {
        Debug.LogError("Panel couldn't created");
      }
    }
  }
}