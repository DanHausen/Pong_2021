using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1;
    void Update(){
        float y = Input.GetAxisRaw("Vertical");
        gameObject.transform.localPosition = new Vector2(transform.position.x, transform.position.y + ((y * speed) / 10));
    }
}
