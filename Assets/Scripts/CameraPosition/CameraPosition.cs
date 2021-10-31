using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
     public Vector3 positionObject1;
     public Vector3 positionObject2;
     public Vector3 positionObject3;
     //public Vector3 positionObject1;
 
    //  void Start()
    //  {
    //      // ALTERNATIVE :  GameObject.FindGameObjectWithTag("Your_Tag_Here").transform.position;
    //      // ALTERNATIVE :  GameObject.Find("Your_Name_Here").transform.position;
         
    //      positionObject2 = GameObject.Find("Your_Name_Here").transform.position;
    //      positionObject3 = GameObject.Find("Your_Name_Here").transform.position;
    //  }



    void Update() 
    
    {
        positionObject1 = GameObject.Find("OvrPlayerSimulator").transform.position;
        GameObject.Find("Main Camera").transform.position = positionObject1;    
     
    }





}
