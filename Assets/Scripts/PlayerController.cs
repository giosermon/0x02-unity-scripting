using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 900f;
    public Rigidbody player;
    private int score = 0;

    // Update is called once per frame
    void FixedUpdate()
    {

        // Press up
        if (Input.GetKey("w"))
        {
            player.AddForce(0, 0, speed * Time.deltaTime);
        }
        // Press down
        if (Input.GetKey("s"))
        {
            player.AddForce(0, 0, -speed * Time.deltaTime);
        }
        // Press left
        if (Input.GetKey("a"))
        {
            player.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        // Press right
        if (Input.GetKey("d"))
        {
            player.AddForce(speed * Time.deltaTime, 0, 0);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pickup")
        {
            score++;
            Destroy(other);
            Debug.Log("score: " + score);
        }
    }
}
