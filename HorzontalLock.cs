using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorzontalLock : MonoBehaviour
{
//this class is entirely my own work
    public GameObject Ball;
    public Rigidbody2D rb;
    public bool isPlayer1;
    public bool freezeRotation;
    void Start()
    {
       
    }

    void Update()
    {
        if (isPlayer1){
            if (Ball.transform.position.x - transform.position.x < .9 && Ball.transform.position.x - transform.position.x > 0 && Ball.transform.position.y - transform.position.y < 1.8 && Ball.transform.position.y - transform.position.y > -1.8){
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else{
                rb.constraints = RigidbodyConstraints2D.None;
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        else{
            if (transform.position.x - Ball.transform.position.x < .9 && transform.position.x - Ball.transform.position.x > 0 && transform.position.y - Ball.transform.position.y < 1.8 && transform.position.y - Ball.transform.position.y > -1.8){
                rb.constraints = RigidbodyConstraints2D.FreezePositionX;
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            else{
                rb.constraints = RigidbodyConstraints2D.None;
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
    }
}
