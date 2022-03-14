/**** 
 * Created by: Sammy Ricketts
 * Date Created: Mar 10, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Mar 10, 2022
 * 
 * Description: basketball code
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject basketballPrefab;
    public float jumpforce = 10;
    Rigidbody rb;
    public float ballSpeed = 100f;
    void Start()
    {
        rb = basketballPrefab.GetComponent<Rigidbody>();
    }



    
    void FixedUpdate() {
        FollowCam.POI = basketballPrefab;
    }
    // Update is called once per frame
    void Update()
    {
       float xDirection = Input.GetAxis("Horizontal");
       float zDirection = Input.GetAxis("Vertical");
       Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
       rb.MovePosition(basketballPrefab.transform.position + moveDirection * ballSpeed);
       
       
        float speed = basketballPrefab.GetComponent<Rigidbody>().velocity.magnitude;
        if (Input.GetMouseButtonDown(0) && speed < 0.1f)
            {

                rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
                
                
                
            }
        
    }


}
