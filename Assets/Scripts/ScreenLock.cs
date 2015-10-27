using UnityEngine;
using System.Collections;

public class ScreenLock : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        Player player = other.GetComponent<Player>() as Player;

        if(player != null) {
            player.lockScreen = true;
        }
    }

}
