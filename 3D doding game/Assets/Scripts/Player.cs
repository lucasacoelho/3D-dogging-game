using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    public float vel;
    public Rigidbody player;
    public GameObject dieText;
    public GameObject restart;
    public bool Ispaused = false;
    public FixedJoystick Joystick;
    public AudioSource bruh;
    public AudioSource background;
    
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        float H = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3((H)* Time.deltaTime, 0, 0));
        float J = Joystick.Horizontal * vel;
        transform.Translate(new Vector3(J * Time.deltaTime,0, 0));
    }
    public void OnCollisionEnter(Collision death)
    {
        if (death.gameObject.tag == "Stone")
        {
            background.Pause();
            bruh.Play();
            Ispaused = true;
            dieText.SetActive(true);
            restart.SetActive(true);
            print("hit");
        }
        
    }
    
        
}
