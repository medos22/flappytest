using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerpipe : MonoBehaviour
{
    public GameObject pipe;
    float timer = 0;
    public float rate = 2;
    public float offset = 6;
    // Start is called before the first frame update
    void Start()
    {
        firstspawn();
    }

    // Update is called once per frame
    void Update()
    {


        if (timer < rate)
        {
            timer += Time.deltaTime;//i tried to add any number but didn't work just delta did!
        }
        else
        {
            firstspawn();
            timer = 0;
        }

    }
    void firstspawn()
    {
        float lowest = transform.position.y - offset;
        float highest = transform.position.y + offset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest, highest), 0), transform.rotation);//i dont think i get the idea of rotation.
    }
}
    
    
