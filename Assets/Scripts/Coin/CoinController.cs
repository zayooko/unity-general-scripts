using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoinController : MonoBehaviour
{
    
    public UnityEvent onTriggerEnter;
    
    public void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Ok");
        onTriggerEnter?.Invoke(); 
        //Destroy(transform.parent.gameObject);
          
    }
}
