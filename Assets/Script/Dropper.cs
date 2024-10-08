using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float TimeElapse = 0;

    void Start() 
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    void Update() 
    {   
        if (Time.time > TimeElapse )
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;

        }
          
    }
    
}
