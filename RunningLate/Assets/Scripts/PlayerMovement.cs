using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody player;

    public float forwardForce = 2000f;

    public float sidewaysForce = 60f;

    // Update is called once per frame
    void FixedUpdate() {
        player.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("right") || Input.GetKey("d")) {
            player.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left") || Input.GetKey("a")) {
            player.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
