using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float speed = (float)5.0;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private float prevX;
    private float currX;
    private float prevY;
    private float currY;
    private bool checking;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        currX = transform.position.x;
        currY = transform.position.y;
        Launch();
    }


    void Update(){
        if (!checking){
            StartCoroutine(Check());
        }
    }
    //tutorial part starts here 
    private void Launch(){
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed*x, speed*y);
    }

    public void Reset(){
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch();
    }
    //tutorial part ends here

    private IEnumerator Check(){
        checking = true;
        prevX = currX;
        prevY = currY;
        yield return new WaitForSeconds((float).5);
        currX = transform.position.x;
        currY = transform.position.y;
        if (currX-prevX < .1 && currX-prevX > -.1){
            rb.velocity = new Vector2((currX-prevX)*2+5, (currY-prevY)*2);
        }
        if (currY-prevY < .1 && currY-prevY > -.1){
            rb.velocity = new Vector2((currX-prevX)*2, (currY-prevY)*2+5);
        }
        checking = false;
    }

    public float getSpeed(){
        return speed;
    }

    public void setSpeed(float speed){
        this.speed=speed;
    }
}