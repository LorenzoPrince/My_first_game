using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour

{
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.AddForce(0f, 0f, -88f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
