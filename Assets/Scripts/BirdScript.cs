using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;
    public int score;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Game has been started!");
        score = 0;
	}
	
	void Update () {
        if (GameController.instance.gameOver == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(Vector2.up * jumpForce);

            }
        }

        
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.gameOver = true;
        GameController.instance.textScore.text = string.Concat("Game Over! Score: " + score);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameController.instance.score++;
        score = GameController.instance.score;
        printScore(score);
        GameController.instance.textScore.text = string.Concat(" Score: " + score);
    }

    public void printScore(int score)
    {
        Debug.Log(score + " is your current Score");
    }
}
