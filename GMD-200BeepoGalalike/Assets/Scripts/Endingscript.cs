using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
public class Endingscript : MonoBehaviour
{
    public Text scoreText;
    int scorePlaceholder;
    void Start()
    {
        scorePlaceholder = ScoreManager.instance.getScore();
        

    }
}
