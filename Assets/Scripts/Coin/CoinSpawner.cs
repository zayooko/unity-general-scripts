//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    float timer1;
    float timer2;

    public GameObject coinPrefab1;
    public GameObject coinPrefab2;


    // void Start() 
    // {
    //     coinPrefab1 = GameObject.Find("CoinContainer");
    //     coinPrefab2 = GameObject.Find("CoinRedContainer");    
    // }


    void Update()
    {
        
 
        
        
        timer1 += Time.deltaTime;

        if(timer1 >= 2f)
        {
            timer1 = 0;
            float x = Random.Range(-10f, 10f);
            Vector3 position = new Vector3(x, 0, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab1, position, rotation);
            //coinPrefab1 = GameObject.Find("CoinContainer(Cloner)");
  

        }


        timer2 += Time.deltaTime;

        if(timer2 >= 3f)
        {
            timer2 = 0;
            float x = Random.Range(-10f, 10f);
            Vector3 position = new Vector3(x, 0, 0);
            Quaternion rotation = new Quaternion();
            Instantiate(coinPrefab2, position, rotation);
            //coinPrefab2 = GameObject.Find("CoinRedContainer(Cloner)");
        }  




    }
}