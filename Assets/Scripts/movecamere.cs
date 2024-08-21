using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamere : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Jugador;
    public Vector3 offset;
    void Start()
    {
        offset = transform.position - Jugador.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Jugador.transform.position + offset;
    }
}
