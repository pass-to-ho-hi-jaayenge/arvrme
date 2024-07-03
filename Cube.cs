using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
  
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 newPostion = new Vector3(moveHorizontal, 0.0f,moveVertical ) * speed * Time.deltaTime;
        rb.MovePosition(transform.position + newPostion);
    }
}

