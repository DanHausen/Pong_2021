using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody rb;
    int x, y = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //TODO Aleatorizar valores para lançar a bola no inicio. Evitar que ela fique presa no centro.
        rb.AddForce(x,y,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
