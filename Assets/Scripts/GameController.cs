using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    Text timerText; 
    Text pointText;

    public float gameTime = 45.0f;  
    float timer = 0.0f; 
    static int point;  
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddPoint(int s)
    {
        point += s;
    }

    public static int GetPoint()
    {
        return point;
    }

    // Use this for initialization
    void Start()
    {
        timerText = GameObject.Find("Timer").GetComponent<Text>();
        pointText = GameObject.Find("Points").GetComponent<Text>();
        point = 0;
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        timerText.text = (gameTime - timer).ToString("F1"); 
        pointText.text = point.ToString(); 
        if (timer >= gameTime)
        {
            SceneManager.LoadScene("GameOver");
            timer = 0.0f;
        }
    }
}