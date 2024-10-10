using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    //This class is entirly my own creation
    [Header("Player1")]
    public GameObject Player1Fastball;
    public GameObject Player1Slowball;
    public GameObject Player1AddWalls;

    [Header("Player2")]
    public GameObject Player2Fastball;
    public GameObject Player2Slowball;
    public GameObject Player2AddWalls;

    private int player1Count;

    private int player2Count;

    private int player1Rand;
    private int player2Rand;

    void Start(){
    }

    public void Player1Reveal(){
        for (int i=0; i < 3; i++){
            player1Count = Player1Fastball.GetComponent<Fastball>().getAbilityMod()+Player1Slowball.GetComponent<Slowball>().getAbilityMod()+Player1AddWalls.GetComponent<AddWalls>().getAbilityMod();
            player1Rand = Random.Range(1,player1Count+1);
            if (player1Rand <= Player1Fastball.GetComponent<Fastball>().getAbilityMod()){
                Player1Fastball.Position.y(3.227524-(2.5*i));
                Player1Fastball.GetComponent<Fastball>().setTempAbilityMod(Player1Fastball.GetComponent<Fastball>().getAbilityMod());
                Player1Fastball.GetComponent<Fastball>().setAbilityMod(0);
                Player1Fastball.GetComponent<SpriteRenderer>.enabled(true);
                Player1Fastball.GetComponent<BoxCollider2D>.enabled(true);
            }
            else if(player1Rand >= Player1AddWalls.GetComponent<AddWalls>().getAbilityMod()){
                Player1AddWalls.Position.y(3.227524-(2.5*i));
                Player1AddWalls.GetComponent<AddWalls>().setTempAbilityMod(Player1AddWalls.GetComponent<AddWalls>().getAbilityMod());
                Player1AddWalls.GetComponent<AddWalls>().setAbilityMod(0);
                Player1AddWalls.GetComponent<SpriteRenderer>.enabled(true);
                Player1AddWalls.GetComponent<BoxCollider2D>.enabled(true);
            }
            else{
                Player1Slowball.Position.y=3.227524-(2.5*i);
                Player1Slowball.GetComponent<Slowball>().setTempAbilityMod(Player1Slowball.GetComponent<Slowball>().getAbilityMod());
                Player1Slowball.GetComponent<Slowball>().setAbilityMod(0);
                Player1Slowball.GetComponent<SpriteRenderer>.enabled(true);
                Player1Slowball.GetComponent<BoxCollider2D>.enabled(true);
            }
        }
    }
        public void Player2Reveal(){
        for (int i=0; i < 3; i++){
            player2Count = Player2Fastball.GetComponent<Fastball>().getAbilityMod()+Player2Slowball.GetComponent<Slowball>().getAbilityMod()+Player2AddWalls.GetComponent<AddWalls>().getAbilityMod();
            player1Rand = Random.Range(1,player2Count+1);
            if (player2Rand <= Player2Fastball.GetComponent<Fastball>().getAbilityMod()){
                Player2Fastball.Position.y=3.227524-(2.5*i);
                Player2Fastball.GetComponent<Fastball>().setTempAbilityMod(Player2Fastball.GetComponent<Fastball>().getAbilityMod());
                Player2Fastball.GetComponent<Fastball>().setAbilityMod(0);
                Player2Fastball.GetComponent<SpriteRenderer>.enabled(true);
                Player2Fastball.GetComponent<BoxCollider2D>.enabled(true);
            }
            else if(player2Rand >= Player2AddWalls.GetComponent<AddWalls>().getAbilityMod()){
                Player2AddWalls.Position.y=3.227524-(2.5*i);
                Player2AddWalls.GetComponent<AddWalls>().setTempAbilityMod(Player2AddWalls.GetComponent<AddWalls>().getAbilityMod());
                Player2AddWalls.GetComponent<AddWalls>().setAbilityMod(0);
                Player2AddWalls.GetComponent<SpriteRenderer>.enabled(true);
                Player2AddWalls.GetComponent<BoxCollider2D>.enabled(true);
            }
            else{
                Player2Slowball.Position.y=3.227524-(2.5*i);
                Player2Slowball.GetComponent<Slowball>().setTempAbilityMod(Player2Slowball.GetComponent<Slowball>().getAbilityMod());
                Player2Slowball.GetComponent<Slowball>().setAbilityMod(0);
                Player2Slowball.GetComponent<SpriteRenderer>.enabled(true);
                Player2Slowball.GetComponent<BoxCollider2D>.enabled(true);
            }
        }
    }
    
}
