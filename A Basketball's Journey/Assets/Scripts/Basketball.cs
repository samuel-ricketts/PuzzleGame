using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject basketballPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float mousePositionX = mousePosition.x;
        basketballPrefab.transform.position = new Vector3(mousePositionX, basketballPrefab.transform.position.y, basketballPrefab.transform.position.z);
    }
}
