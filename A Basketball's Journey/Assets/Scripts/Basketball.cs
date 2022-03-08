using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject basketballPrefab;
    public float jumpforce = 10;
    Rigidbody rb;
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
        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float mousePositionX = mousePosition.x;
        basketballPrefab.transform.position = new Vector3(mousePositionX, basketballPrefab.transform.position.y, basketballPrefab.transform.position.z);
        float speed = basketballPrefab.GetComponent<Rigidbody>().velocity.magnitude;
        if (Input.GetButtonDown("Jump") && speed < 0.1f)
            {

                rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
                
                
                
            }
        
    }


}
