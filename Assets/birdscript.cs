using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public trackscore track;
    public Rigidbody2D myrigidbody;
    public float flaoting;
    public bool bird = true;
    // Start is called before the first frame update
    void Start()
    {
        track = GameObject.FindGameObjectWithTag("logic").GetComponent<trackscore>();
     
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&&bird)
        {
            myrigidbody.velocity = Vector2.up * flaoting;
            track.Gamestart();
            
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;//??????
        }
         outacam();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        track.Gameover();
        bird = false;
        gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

    }
    private void outacam()
    {
        track.fall();
        if (gameObject.transform.position.y < -10 || gameObject.transform.position.y > 10) 
        { 
            gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            bird = false;
        }
    }
}
