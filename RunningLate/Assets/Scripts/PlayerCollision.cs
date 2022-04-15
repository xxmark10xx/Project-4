using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo) {
        // Debug.Log(collisionInfo.collider.tag)
       if (collisionInfo.collider.tag == "Obstacle") {
            movement.enabled = false; // stops movement of player
            // we use this since if we were to use a variable then there would be an instance of a player in unity fo the manage game script to reference.
            // so we call it when its needed -- like this... 
            FindObjectOfType<GameManager>().EndGame();
       }

    }
}
