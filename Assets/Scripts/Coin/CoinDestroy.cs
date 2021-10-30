//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

//using System.Threading.Tasks;

public class CoinDestroy : MonoBehaviour

{
    // public GameObject coinPrefab1;
    // public GameObject coinPrefab2;
    // // public GameObject coin;
    // // public GameObject coinRed;
    // // public GameObject CoinContaniner;
    // // public GameObject CoinRedContainer;
    
    // void Start() 
    // {
    //     // coinPrefab1 = GameObject.Find("coin");
    //     // coinPrefab2 = GameObject.Find("coinRed");    
    // }

   
    
    //private async void Update()

    void Update()
    {
        //if(GameObject.Find("coin").transform.position.z >= 4)
        if(gameObject.transform.position.z >= 4 && gameObject != null)
        {
            Debug.Log("Ok1");

            
             //await Task.Delay(10000);

            // //Destroy(GameObject.Find("coin")); 
            Destroy(transform.parent.gameObject);
            
            //gameObject.SetActive(false);
        }
        else
        {
            DontDestroyOnLoad(transform.parent.gameObject);
        }    
    //     // if(GameObject.Find("coinRed").transform.position.z >= 4)
    //     // {
    //     //     Debug.Log("Ok2");
    //     //     Destroy(GameObject.Find("coinRed"));     
    //     // }    
    }
}
