using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float vel;
    public Rigidbody player;
    public GameObject dieText;
    public GameObject restart;
    public bool Ispaused = false;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Ispaused == true)
        {
            Debug.Log("Space pressed");
            Time.timeScale = 1;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Ispaused = false;
                
        }
        
        float H = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3((H)* Time.deltaTime, 0, 0));
    }
    private void OnCollisionEnter(Collision death)
    {
        if (death.gameObject.tag == "Stone")
        {
            Time.timeScale = 0;
            Ispaused = true;
            dieText.SetActive(true);
            restart.SetActive(true);
            print("hit");
        }
        
    }
    
        
}
