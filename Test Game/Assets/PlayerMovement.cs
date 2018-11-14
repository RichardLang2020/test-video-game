using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        // Use "Debug.Log()" to print
        // Debug.Log("Hello, World!");
        // rb.useGravity = false;
        // rb.AddForce(0, 200, 500);
	}
	
	// Update is called once per frame
    // Use FixedUpdate for physics in Unity
    // Use Time.deltaTime in order to make speeds uniform across all omputers
	void FixedUpdate () {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
	}
}
