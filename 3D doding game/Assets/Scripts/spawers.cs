using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawers : MonoBehaviour
{
    public GameObject Sphereprefab;
    public float elapsedTime = 0;
    public GameObject spawner1;
    public float timer1;
    public GameObject spawner2;
    public float timer2;
    public GameObject spawner3;

    public  Player player;

    // Update is called once per frame
    void Update()
    {
        if (player.Ispaused == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Space pressed");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                player.Ispaused = false;
            }
        }
        else
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime > 3)
            {
                elapsedTime = 0;
                Instantiate(Sphereprefab, spawner1.transform.position, Quaternion.identity);
            }
            timer1 += Time.deltaTime;

            if (timer1 > 4)
            {
                timer1 = 0;
                Instantiate(Sphereprefab, spawner2.transform.position, Quaternion.identity);
            }
            timer2 += Time.deltaTime;

            if (timer2 > 2)
            {
                timer2 = 0;
                Instantiate(Sphereprefab, spawner3.transform.position, Quaternion.identity);
            }
        }
        

    }

    
}
