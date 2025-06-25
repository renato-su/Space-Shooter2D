using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    static int point;
    Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        pointText = GameObject.Find("Point").GetComponent<Text>(); 
    }
    public void AddPoint(int s)
    {
        point += s;
    }
    public static int GetPoint
    {
        get { return point; }
    }
    // Update is called once per frame
    void Update()
    {
        pointText.text = GameController.GetPoint().ToString(); 

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneManager.LoadScene("Title"); //タイトルシーンに戻る
        }
    }
}
