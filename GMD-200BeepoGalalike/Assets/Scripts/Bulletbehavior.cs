using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletbehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        
            Despawn();
        
    }
    private void Despawn()
    {

        gameObject.SetActive(false);
    }
}
