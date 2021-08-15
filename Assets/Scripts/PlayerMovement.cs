using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;
    Rigidbody rb;
    
    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate(){
        Vector3 m_input = new Vector3(0,Input.GetAxisRaw("Vertical"),0);
        rb.MovePosition(transform.position + m_input * Time.deltaTime * speed);
    }
}
