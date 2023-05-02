using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trackscore : MonoBehaviour
{
    public GameObject gameoverscreen;
    public GameObject start;
    public GameObject bird;
    public GameObject textstarter;
    public int playerscore=0;
    public Text track;
    public Text score;
    [ContextMenu("check")]
    public void Update()
    {
        Updatehighscore();
    }
    public void Score(int no)
    {


        playerscore += no;
        track.text = playerscore.ToString();
       
        Highscore();
    }
    public void Highscore()
    {
        if (PlayerPrefs.GetInt("highscore", 0) < playerscore)
        {
            PlayerPrefs.SetInt("highscore", playerscore);
        }
        
    }
    public void Updatehighscore()
    {
        score.text = $"highscore:{PlayerPrefs.GetInt("highscore", 0)}";//??????
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//?????
    }
    public void Gameover()
    {
        gameoverscreen.SetActive(true);
        
        
    }
    public void fall()
    {
            if (bird.transform.position.y<-10|| bird.transform.position.y > 10)
        {
            Gameover();
            
        }

    }
    public void Gamestart()
    {
       
        
        start.SetActive(true);
        textstarter.SetActive(false);
        

    }
}
