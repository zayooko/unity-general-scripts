using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.position.z >= 4)
        {
            //Debug.Log("Ok");
            //Destroy(transform.parent.gameObject); 
        }    
    }
}
