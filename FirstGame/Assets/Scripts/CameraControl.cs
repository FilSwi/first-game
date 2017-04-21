using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    // Use this for initialization
    public Transform target;
    public float distance = -10f;
    public float lift = 1.5f;

	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<Transform>().position = target.position + new Vector3(0, lift, distance);
        transform.LookAt(target);
    }
}
