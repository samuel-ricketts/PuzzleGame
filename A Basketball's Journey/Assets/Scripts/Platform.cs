/**** 
 * Created by: Sammy Ricketts
 * Date Created: Mar 10, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Mar 10, 2022
 * 
 * Description: Secret Platform Code
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public GameObject basketballPrefab;
    public GameObject FakePlatform1;
    public GameObject FakePlatform2;
    public GameObject FakePlatform3;
    public GameObject FakePlatform4;
    
    public GameObject LockedPlatform1;
    public GameObject LockedPlatform2;
    
    bool platform1 = false;
    bool platform2 = false;
    bool platform3 = false;
    
    bool platform1Hit = false;
    bool platform2Hit = false;
    bool platform3Hit = false;
    public static int platformsHit = 0;
    // Start is called before the first frame update
    void Start()
    {
        FakePlatform3.SetActive(false);
        FakePlatform4.SetActive(false);
        LockedPlatform1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Pad"){
            if (platform2 == true) {
                FakePlatform3.SetActive(true);
                platform1 = true;
                Destroy(other.gameObject);
                platformsHit++;

            }
            else if (platform1Hit == true) {
                FakePlatform1.SetActive(true);
                FakePlatform2.SetActive(true);
                platform1Hit = false;
            }
            else {
                FakePlatform1.SetActive(false);
                FakePlatform2.SetActive(false);
                platform1Hit = true;
                Debug.Log("Its Working");
                
                
            }
             
        }
        if(other.gameObject.tag == "Pad2"){
             platform2 = true;
             FakePlatform4.SetActive(true);
             Destroy(other.gameObject);
             platformsHit++;
             //other.gameObject.SetActive(false);











        }
        if(other.gameObject.tag == "Pad3"){
            if (platform3Hit == true) {
                LockedPlatform1.SetActive(false);
                platform3Hit = false;
            }
            else if ( (platform2 == true && platform1== false) || (platform2 == false) ) {
                LockedPlatform1.SetActive(true);
                platform3Hit = true;
            }
            else if (platform2 == true && platform1 == true){
                LockedPlatform2.SetActive(false);
                Destroy(other.gameObject);
                platformsHit++;
            }
            
        }
    }
}
