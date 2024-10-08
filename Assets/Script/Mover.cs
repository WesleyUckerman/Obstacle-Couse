using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField]    float MoveSpeed = 0.00f ;
    [SerializeField]    float yValue = 0.00f    ;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game")    ;
        Debug.Log("Dogde of obstacles")    ;
        Debug.Log("Move using WASD for movement your hero")    ;
    }

    void MovePlayer()
    {
        float zValue = Input.GetAxis("Vertical")*   Time.deltaTime  *   MoveSpeed       ;
        float xValue = Input.GetAxis("Horizontal")  *   Time.deltaTime  *   MoveSpeed   ;
        transform.Translate(xValue,yValue,zValue) ;
    }
}
