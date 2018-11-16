using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    // Good practice to put "f" after floating point numbers in Unity
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    private bool moveRight;
    private bool moveLeft;

	// Use this for initialization
	void Start() {
        // Use "Debug.Log()" to print
        // Debug.Log("Hello, World!");
        // rb.useGravity = false;
        // rb.AddForce(0, 200, 500);
	}

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKey("d")) {
            moveRight = true;
        } else {
            moveRight = false;
        }

        if(Input.GetKey("a")) {
            moveLeft = true;
        } else {
            moveLeft = false;
        }
    }
    // Use FixedUpdate for physics in Unity
    // Use Time.deltaTime in order to make speeds uniform across all omputers
    void FixedUpdate() {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(moveRight) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(moveLeft) {
            rb.AddForce(-1 * sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
	}
}
