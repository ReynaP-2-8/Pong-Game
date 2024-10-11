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
    public SpriteRenderer P1FastballSpriteRenderer;
    public SpriteRenderer P1SlowballSpriteRenderer;
    public SpriteRenderer P1AddWallsSpriteRenderer;
    public BoxCollider2D P1FastballCollider;
    public BoxCollider2D P1SlowballCollider;
    public BoxCollider2D P1AddWallsCollider;

    [Header("Player2")]
    public GameObject Player2Fastball;
    public GameObject Player2Slowball;
    public GameObject Player2AddWalls;
    public SpriteRenderer P2FastballSpriteRenderer;
    public SpriteRenderer P2SlowballSpriteRenderer;
    public SpriteRenderer P2AddWallsSpriteRenderer;
    public BoxCollider2D P2FastballCollider;
    public BoxCollider2D P2SlowballCollider;
    public BoxCollider2D P2AddWallsCollider;

    private int player1Count;
    private int player2Count;

    private int player1Rand;
    private int player2Rand;

    void Start(){
        this.P1FastballSpriteRenderer = Player1Fastball.GetComponent<SpriteRenderer>();
        this.P1SlowballSpriteRenderer = Player1Slowball.GetComponent<SpriteRenderer>();
        this.P1AddWallsSpriteRenderer = Player1AddWalls.GetComponent<SpriteRenderer>();
        this.P2FastballSpriteRenderer = Player2Fastball.GetComponent<SpriteRenderer>();
        this.P2SlowballSpriteRenderer = Player2Slowball.GetComponent<SpriteRenderer>();
        this.P2AddWallsSpriteRenderer = Player2AddWalls.GetComponent<SpriteRenderer>();

        this.P1FastballCollider = Player1Fastball.GetComponent<BoxCollider2D>();
        this.P1SlowballCollider = Player1Slowball.GetComponent<BoxCollider2D>();
        this.P1AddWallsCollider = Player1AddWalls.GetComponent<BoxCollider2D>();
        this.P2FastballCollider = Player2Fastball.GetComponent<BoxCollider2D>();
        this.P2SlowballCollider = Player2Slowball.GetComponent<BoxCollider2D>();
        this.P2AddWallsCollider = Player2AddWalls.GetComponent<BoxCollider2D>();
    }

    public void Player1Reveal(){
        for (int i=0; i < 3; i++){
            player1Count = Player1Fastball.GetComponent<Fastball>().getAbilityMod()+Player1Slowball.GetComponent<Slowball>().getAbilityMod()+Player1AddWalls.GetComponent<AddWalls>().getAbilityMod();
            player1Rand = Random.Range(1,player1Count+1);
            if (player1Rand <= Player1Fastball.GetComponent<Fastball>().getAbilityMod()){
                Player1Fastball.transform.position = new Vector2 (-6,(float)(2.5-(2.5*i)));
                Player1Fastball.GetComponent<Fastball>().setTempAbilityMod(Player1Fastball.GetComponent<Fastball>().getAbilityMod());
                Player1Fastball.GetComponent<Fastball>().setAbilityMod(0);
                this.P1FastballSpriteRenderer.enabled = true;
                this.P1FastballCollider.enabled = true;
            }
            else if(player1Rand >= player1Count - Player1AddWalls.GetComponent<AddWalls>().getAbilityMod()){
                Player1Fastball.transform.position = new Vector2 (-6,(float)(2.5-(2.5*i)));
                Player1AddWalls.GetComponent<AddWalls>().setTempAbilityMod(Player1AddWalls.GetComponent<AddWalls>().getAbilityMod());
                Player1AddWalls.GetComponent<AddWalls>().setAbilityMod(0);
                this.P1AddWallsSpriteRenderer.enabled = true;
                this.P1AddWallsCollider.enabled = true;
            }
            else{
                Player1Fastball.transform.position = new Vector2 (-6,(float)(2.5-(2.5*i)));
                Player1Slowball.GetComponent<Slowball>().setTempAbilityMod(Player1Slowball.GetComponent<Slowball>().getAbilityMod());
                Player1Slowball.GetComponent<Slowball>().setAbilityMod(0);
                this.P1SlowballSpriteRenderer.enabled = true;
                this.P1SlowballCollider.enabled = true;
            }
        }
    }
        public void Player2Reveal(){
        for (int i=0; i < 3; i++){
            player2Count = Player2Fastball.GetComponent<Fastball>().getAbilityMod()+Player2Slowball.GetComponent<Slowball>().getAbilityMod()+Player2AddWalls.GetComponent<AddWalls>().getAbilityMod();
            player1Rand = Random.Range(1,player2Count+1);
            if (player2Rand <= Player2Fastball.GetComponent<Fastball>().getAbilityMod()){
                Player2Fastball.transform.position = new Vector2 (6,(float)(2.5-(2.5*i)));
                Player2Fastball.GetComponent<Fastball>().setTempAbilityMod(Player2Fastball.GetComponent<Fastball>().getAbilityMod());
                Player2Fastball.GetComponent<Fastball>().setAbilityMod(0);
                this.P2FastballSpriteRenderer.enabled = true;
                this.P2FastballCollider.enabled = true;
            }
            else if(player2Rand >= player2Count - Player2AddWalls.GetComponent<AddWalls>().getAbilityMod()){
                Player2Fastball.transform.position = new Vector2 (6,(float)(2.5-(2.5*i)));
                Player2AddWalls.GetComponent<AddWalls>().setTempAbilityMod(Player2AddWalls.GetComponent<AddWalls>().getAbilityMod());
                Player2AddWalls.GetComponent<AddWalls>().setAbilityMod(0);
                this.P2AddWallsSpriteRenderer.enabled = true;
                this.P2AddWallsCollider.enabled = true;
            }
            else{
                Player2Fastball.transform.position = new Vector2 (6,(float)(2.5-(2.5*i)));
                Player2Slowball.GetComponent<Slowball>().setTempAbilityMod(Player2Slowball.GetComponent<Slowball>().getAbilityMod());
                Player2Slowball.GetComponent<Slowball>().setAbilityMod(0);
                this.P2SlowballSpriteRenderer.enabled = true;
                this.P2SlowballCollider.enabled = true;
            }
        }
    }
    
}
