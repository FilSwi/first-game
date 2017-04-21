using UnityEngine;
using System.Collections;

public class BallHealth : MonoBehaviour {

    // Use this for initialization
    public float maxFallDistance = -7f;
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(transform.position.y<=maxFallDistance)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        }
	}
}
