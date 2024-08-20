using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveObjets : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 NewPosition;
    public float speed;
    public Vector3 imputVector;
    void Start()
    {
        Debug.Log("El juego a comenzado");


    }

    // Update is called once per frame
    void Update()
    {

        imputVector.x = Input.GetAxis("Horizontal");
        imputVector.y = Input.GetAxis("Vertical");
        transform.Translate(imputVector.x * speed, 0f, imputVector.y * speed);
        Debug.Log("El juego se esta ejecutando");


      

        /*if (Input.GetKeyDown(KeyCode.P))
        
        {
            Debug.Log("Touch P");
            transform.position = NewPosition;
        } 
        if (Input.GetKey (KeyCode.W)) 

        {

            Debug.Log("press w");
            transform.Translate(0f, 0f ,speed );
        }
        if (Input.GetKey(KeyCode.S))

        {

            Debug.Log("press s");
            transform.Translate(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.A))

        {

            Debug.Log("press s");
            transform.Translate(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))

        {

            Debug.Log("press d");
            transform.Translate(speed, 0f, 0f);
        }
        */
    }
}
