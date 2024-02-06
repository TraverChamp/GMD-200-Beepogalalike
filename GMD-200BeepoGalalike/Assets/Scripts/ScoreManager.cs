using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    int score;
    private void Awake()
    {
        instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString()+" Points";

    }

    // Update is called once per frame
    public void Addpoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Points";
    }
    public int getScore()
    {
        return score;
    }
}
