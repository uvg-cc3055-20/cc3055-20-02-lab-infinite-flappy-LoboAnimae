using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnSpawner : MonoBehaviour
{
    public GameObject column;
    public static ColumnSpawner instance;
    public float spawnTime = 4f;
    public float elapsedTime = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameOver == false)
        {
            //This IF-ELSE statement allows the game to create the columns every 2 seconds
            //on a given range
            if (elapsedTime < spawnTime)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                float random = Random.Range(-2f, 2f);
                Instantiate(column, new Vector3(9, random, 0),
                    Quaternion.identity);
                elapsedTime = 0;
            }
        }
    }
}
