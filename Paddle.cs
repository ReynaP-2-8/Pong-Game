using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //this entire class is tutorial part except for horizontal movement
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float movementY;
    private float movementX;

    void Start(){
        startPosition = transform.position;
    }
    // Update is called once per frame
    void Update(){
        if (isPlayer1){
            movementY = Input.GetAxisRaw("Vertical");
            movementX = Input.GetAxisRaw("Horizontal");
        }
        else{
            movementY = Input.GetAxisRaw("Vertical2");
            movementX = Input.GetAxisRaw("Horizontal2");
        }

        rb.velocity = new Vector2(movementX * speed, movementY * speed);
    }
    public void Reset(){
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
