using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int Hit = 0 ;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit")
        
        {
            Hit++;
            Debug.Log("You bump many times: " + Hit);
        }
      
    }
}
