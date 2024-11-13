using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class spawers : MonoBehaviour
{
    public GameObject Sphereprefab;
    public float elapsedTime = 0;
    
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime > 3)
        {
            elapsedTime = 0;
            Instantiate(Sphereprefab, transform.position, Quaternion.identity);
        }

    }

    
}
