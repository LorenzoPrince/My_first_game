using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjets : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 NewPosition;
    void Start()
    {
        Debug.Log("El juego a comenzado");


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("El juego se esta ejecutando");

        if (Input.GetKey(KeyCode.W))
        
        {
            Debug.Log("Touch w");
            transform.position = NewPosition;
        } 


    }
}
