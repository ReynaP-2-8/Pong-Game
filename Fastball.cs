using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fastball : MonoBehaviour
{
    //this class is entirely my own work
    private int abilityMod = 100;

    public void setAbilityMod (int abilityMod){
        this.abilityMod = abilityMod;
    }

    public int getAbilityMod(){
        return abilityMod;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player"){
            GameObject.Find("GameManager").GetComponent<GameManager>().SpeedMod(1);
        }
    }
}