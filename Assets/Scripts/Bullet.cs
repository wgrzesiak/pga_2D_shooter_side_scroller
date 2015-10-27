using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed = 10;
    public Player player;

	void Start () {
        rb.velocity = new Vector2(speed, 0);
	}
	
	void Update () {
	
	}
	
    void OnCollisionEnter2D(Collision2D coll) {
        Destroy(gameObject);
    }
}
