using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Transform player;
    public Text score;
    // Update is called once per frame
    void Update() {
        score.text = (player.position.z - 3.4).ToString("0");
    }
}
