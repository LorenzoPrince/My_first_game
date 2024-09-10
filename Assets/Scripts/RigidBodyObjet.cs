using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RigidBodyMut : MonoBehaviour  

{
    public float speed;
    public float Jumpforce;
    public UnityEngine.Vector3 imputVector;
    public Rigidbody rigidBody;
    public bool isGrounded;
    public Collision contraLoQueChoque;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        isGrounded = true;


    }

    // Update is called once per frame
    void Update()
    {
        imputVector.x = Input.GetAxis("Horizontal");
        imputVector.y = Input.GetAxis("Vertical");

        rigidBody.AddForce(imputVector.x * speed, 0f, imputVector.y * speed, ForceMode.Impulse);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            
            rigidBody.AddForce(0f, Jumpforce, 0f, ForceMode.Impulse); //si no esta el forcemode.impulse lo toma automatico
            isGrounded = false;                                                          //como .force  (recomendado para motores, aceleracion gradual, etc) que hara que
                                                                      //cada vez que toque incremente la velocidad de salto en cambio con este (impulse) la velocidad es de una.
        }  
      
    }
    private void OnCollisionEnter(Collision contraLoQueChoque)
    {
        Debug.Log("choque contra " + contraLoQueChoque.gameObject.name);
        if (contraLoQueChoque.gameObject.CompareTag("pizo"))
        {
            isGrounded = true;
        }
        if(contraLoQueChoque.gameObject.CompareTag("KillZone")) 

        {
            Debug.Log("Kill me");

            SceneManager.LoadScene(0);

        }
    }
}
