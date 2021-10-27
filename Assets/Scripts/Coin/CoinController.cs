//using System.Collections;
//sing System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;


public class CoinController : MonoBehaviour
{
    float timer;
    public UnityEvent onTriggerEnter;
    
    public async void OnTriggerEnter(Collider collision) 
    {
        onTriggerEnter?.Invoke();
  
        await Task.Delay(100);
        Destroy(transform.parent.gameObject);
    }    
}
