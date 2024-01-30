using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleprocess : MonoBehaviour
{
    public void OnDestroy()
    {
        Destroy(gameObject);
    }
}
