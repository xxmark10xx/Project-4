using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    // initial variabvklwe 
    bool gameOver = false;
    
    public void EndGame() {
        if (gameOver == false) {
            Debug.Log("The Game is Over");
            // setting the gameOver variable to true only lets the game restart once on collision
            gameOver = true;
            // here we are invoke the function after a certain amount of time
            Invoke("Restart", 2f);
        }
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
