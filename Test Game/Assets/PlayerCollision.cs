using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collisionInfo) {
        // Debug.Log(collisionInfo.collider.name);

        if(collisionInfo.collider.tag == "Obstacle") {
            // Debug.Log("We hit an obstacle!");
            movement.enabled = false;
        }
    }
}
