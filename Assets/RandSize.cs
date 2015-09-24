using UnityEngine;
using System.Collections;

public class RandSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.localScale = Vector3.one * Random.Range(1, 5);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
