using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        Vector2 randomVelocity = new Vector2(Random.Range(0f, 1f), Random.Range(0f, 1f));
        randomVelocity.Normalize();
        rigidbody.velocity = randomVelocity * 10;
    }
	
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Reset")
            transform.position = Vector3.zero;
    }

}
