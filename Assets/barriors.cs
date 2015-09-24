using UnityEngine;
using System.Collections;

public class barriors : MonoBehaviour {
    Transform robotboy;
    // Use this for initialization
    void Start () {
        robotboy = gameObject.transform.Find("/CharacterRobotBoy");
    }
	// Update is called once per frame
	void LateUpdate () {
        Vector3 tmpPos = transform.position; // Store all Vector3
        if (robotboy.transform.position.x < -5)
        {
            tmpPos.x = -5.0f; // example assign individual fox Y axe        
        }
        else if (robotboy.transform.position.x > 5)
        {           
            tmpPos.x = 5.0f; // example assign individual fox Y axe            
        }
        else
        {           
            tmpPos.x = robotboy.transform.position.x; // example assign individual fox Y axe            
        }
        transform.position = tmpPos; // Assign back all Vector3
    }
}
