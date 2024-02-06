using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] private Image[] shipImages;
    private void OnEnable()
    {
        Lifescript.LifeLost += OnLifeLost;
        OnLifeLost(Lifescript.getLife());
    }
    private void OnLifeLost(int obj)
    {
        Lifescript.LifeLost -= OnLifeLost;
        
    }
  
}
