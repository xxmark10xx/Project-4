using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // make public variables so that we could use them on the engine.
    public Rigidbody player;

    public float forwardForce = 2000f;

    public float sidewaysForce = 60f;

    // Update is called once per frame
    void FixedUpdate() {
        // Applying forward force to the player
        // using "Time.deltaTime" to make the speed of the player equal for player that have a lower frame-rate
        player.AddForce(0, 0, forwardForce * Time.deltaTime); 
        // allow the user to moce the player left and right with a, d, left arrow, and right arrow
        if (Input.GetKey("right") || Input.GetKey("d")) {
            player.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("left") || Input.GetKey("a")) {
            player.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // here we are calling an object called the gameManager so that we could end the game and restart.
        if (player.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
