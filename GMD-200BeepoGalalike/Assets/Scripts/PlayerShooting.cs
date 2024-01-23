using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    public float bulletSpeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            Rigidbody2D bulletRB = GetComponent<Rigidbody2D>();
            if(bulletRB != null )
            {
                bulletRB.velocity = transform.up * bulletSpeed;
            }
        }
    }
}
