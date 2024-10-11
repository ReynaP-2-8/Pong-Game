using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //this entire class is tutorial part
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;
    public GameObject player2Goal;

    [Header("Score UI")]
    public TMPro.TextMeshProUGUI Player1Text;
    public TMPro.TextMeshProUGUI Player2Text;

    private int Player1Score = 0;
    private int Player2Score = 0;

    private string Player1String;
    private string Player2String;

    public void Player1Scored(){
        Player1Score++;
        Player1String = Player1Score.ToString();
        Player1Text.text = Player1String;
        ResetPosition();
    }

    public void Player2Scored(){
        Player2Score++;
        Player2String = Player2Score.ToString();
        Player2Text.text = Player2String;
        ResetPosition();
    }

    public void ResetPosition(){
        ball.GetComponent<Ball>().Reset();
        player1Paddle.GetComponent<Paddle>().Reset();
        player2Paddle.GetComponent<Paddle>().Reset();
    } 

    public void Player1Hit(){
        Player1HitCount++;
        if (Player1HitCount % 10 == 0){
            PowerUpManager.GetComponent<PowerUpManager>().Player1Reveal();
        }
        Debug.Log("Player 1: " + Player1HitCount);
    }

    public void Player2Hit(){
        Player2HitCount++;
        if (Player2HitCount % 10 == 0){
            PowerUpManager.GetComponent<PowerUpManager>().Player2Reveal();
        }
        Debug.Log("Player 2: " + Player2HitCount);
    }
}
