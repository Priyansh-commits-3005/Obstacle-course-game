using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    void PrintInstructions(){
        Debug.Log("WELCOME TO THE GAME");
        Debug.Log("MOVE PLAYER WITH WASD");
        Debug.Log("AVOID THE WALLS");
    }
    void MovePlayer(){
        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
        transform.Translate(xValue,0,zValue); 
    }
}
