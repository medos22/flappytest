using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gapscrip : MonoBehaviour
{
    public trackscore track;
    // Start is called before the first frame update
    void Start()
    {
        track = GameObject.FindGameObjectWithTag("logic").GetComponent<trackscore>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            track.Score(1);
        }
        
    }
}
