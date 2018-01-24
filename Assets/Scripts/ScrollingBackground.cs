using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {

    public float scrollingSpeed;
    public static ScrollingBackground instance;

	// Use this for initialization
	void Start () {

        //This variable allows the background to move.
        scrollingSpeed = 5f; 
		
	}

    // Update is called once per frame
    void Update() {
        if (GameController.instance.gameOver == false) {

            //This allows the background to translate through the level
            transform.Translate(Vector2.left * scrollingSpeed * Time.deltaTime);

            //This IF statement allows the background to repeat itself whenever it ends
            if (transform.position.x < -20.4)
            {
                transform.position = new Vector3(20.0f,
                    transform.position.y, transform.position.z);
            }

        }
    }

}
