using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipscript : MonoBehaviour
{
    [ContextMenu(itemName:"Damage")]
    public void TakeDamage()
    {
        Lifescript.setLife(Lifescript.getLife() - 1);
    }
}
