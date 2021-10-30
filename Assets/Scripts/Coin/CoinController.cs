//using System.Collections;
//sing System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

using System.Threading.Tasks;

public class CoinController : MonoBehaviour

{

    public UnityEvent onTriggerEnter;

  
  
    public async void OnTriggerEnter(Collider collision) 

    {
        onTriggerEnter?.Invoke();
  
        await Task.Delay(150);

        Destroy(transform.parent.gameObject);
    }    
}
