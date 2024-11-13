using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float vel;
    public Rigidbody player;
    public Collider ground;
    public Collider ground1;
    public Boolean Injump = false;
    

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(H * Time.deltaTime, 0, 0));

        float V = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, V * Time.deltaTime));
        if (Input.GetKeyDown("space")& Injump == false)
        {
            Injump = true;
            StartCoroutine(Skilldelay());
            player.AddForce(new Vector3(0, 10f, 0), ForceMode.Impulse);
                    
                    
        }

    }

    public IEnumerator Skilldelay()
    {
        yield return new WaitForSeconds(1);
        Injump = false;
    }
        
}
