using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_pipes : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * speed)* Time.deltaTime;


        if (transform.position.x < -31)//i kinda dont get why this code is here and not in spawn
        {
            Debug.Log("that's it");
            Destroy(gameObject);
        }
    }
}

