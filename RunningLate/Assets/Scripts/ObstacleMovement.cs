using UnityEngine;

public class ObstacleMovement : MonoBehaviour {
    public Rigidbody obstacle;
    
    public float forwardForce = 1000f;
    // Update is called once per frame
    void FixedUpdate() {
        obstacle.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
