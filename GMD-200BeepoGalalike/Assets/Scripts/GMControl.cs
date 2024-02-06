using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GMControl : MonoBehaviour
{
    public Transform enemyObj;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
        for (int xPos = -6; xPos<8;xPos +=2)
        {
            for(int yPos=3; yPos<12; yPos+=3)
            {
                Instantiate(enemyObj, new Vector2(xPos, yPos), enemyObj.rotation);
            }
            

            
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] gameObjects;
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
        if (gameObjects.Length==0)
        {
            SceneManager.LoadScene("End Screen");
        }
    }
}
