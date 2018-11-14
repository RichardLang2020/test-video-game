using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    // Vector3 stores 3 floats into a vector format
    public Vector3 offset;
	
	// Update is called once per frame
	void Update () {
        // Debug.Log(player.position);
        transform.position = player.position + offset;
	}
}
