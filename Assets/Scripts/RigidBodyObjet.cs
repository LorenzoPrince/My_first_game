using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMut : MonoBehaviour  

public float speed;
public vector3 imputvector;
public rigibody rigibody;
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        imputVector.x = Input.GetAxis("Horizontal");
        imputVector.y = Input.GetAxis("Vertical");

    }
}
