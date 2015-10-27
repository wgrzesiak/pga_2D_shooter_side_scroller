using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public GameObject target;
    public Player player;
    public float speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 targetPosition = new Vector3(target.transform.position.x, 
                                            target.transform.position.y, 
                                            target.transform.position.z - 1);

        if(!player.lockScreen) {
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
        }
	}
}
