using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    Orbs orbInstance = new Orbs();
    Platform platformInstance = new Platform();
    GameManager gm = GameManager.GM;
    int level = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Basket"){
            if ( (Orbs.orbsTaken == 3) ){
                level++;
                gm.nextLevel = true;
                Orbs.orbsTaken = 0;
                if (level == 2) {
                    gm.playerWon = true;
                    gm.GameOver();
                }
                Debug.Log("You Won");
            }
        }
        
    }
}
