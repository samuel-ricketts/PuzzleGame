/**** 
 * Created by: Sammy Ricketts
 * Date Created: Mar 10, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Mar 10, 2022
 * 
 * Description: Orbs Code
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbs : MonoBehaviour
{
    public GameObject orbPrefab;
    public static int orbsTaken = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Orb"){
            orbsTaken++;
            Destroy(other.gameObject);
        }
        
    }
}
