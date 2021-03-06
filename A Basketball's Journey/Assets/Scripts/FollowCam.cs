/**** 
 * Created by: Sammy Ricketts
 * Date Created: Mar 10, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Mar 10, 2022
 * 
 * Description: followcam code
****/
using UnityEngine;
using System.Collections;
public class FollowCam : MonoBehaviour {
static public GameObject POI; 
[Header("Set in Inspector")]
public float easing = 10f;
public Vector2 minXY = Vector2.zero;

[Header("Set Dynamically")]
public float camZ; 
void Awake() {
camZ = this.transform.position.z;
}
void FixedUpdate () {

if (POI == null) return;

Vector3 destination = POI.transform.position;

destination.x = Mathf.Max( minXY.x, destination.x );
destination.y = Mathf.Max( minXY.y, destination.y );


destination = Vector3.Lerp(transform.position, destination,
easing);

destination.z = camZ;

transform.position = destination;
Camera.main.orthographicSize = destination.y + 10;

}
}

