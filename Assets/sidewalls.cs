using UnityEngine;
using System.Collections;

public class sidewalls : MonoBehaviour {
    Transform robotboy;
    // Use this for initialization
    void Start () {
        robotboy = gameObject.transform.Find("/CharacterRobotBoy");
    }
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 tmpPos = this.transform.position; // Store all Vector3
        if (robotboy.transform.position.x < -15)
        {
            tmpPos.x = -15.0f; // example assign individual fox Y axe
        }
        else if (robotboy.transform.position.x > 15)
        {
            tmpPos.x = 15.0f; // example assign individual fox Y axe  
        }
        robotboy.transform.position = tmpPos; // Assign back all Vector3
    }
}
