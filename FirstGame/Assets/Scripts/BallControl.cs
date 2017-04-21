using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour
{


    // Use this for initialization
    public int rotationSpeed = 200;
    public Rigidbody rb;
    public float jumpHeight = 8;
    private bool isFalling = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //BALL ROTATION
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        rotation *= Time.deltaTime;
        rb.AddRelativeTorque(Vector3.back * rotation);
        //BALL JUMPING
        if (Input.GetKeyDown(KeyCode.W) && isFalling == false)
        {
            Vector3 v = rb.velocity;
            v.y = jumpHeight;
            rb.velocity = v;
        }
        //isFalling = true;
    }
    void OnCollisionStay()
    {
        isFalling = false;
    }

    void OnCollisionExit()
    {
        isFalling = true;
    }
}