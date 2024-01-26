using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Rigidbody2D bulletPrefab;
    // Start is called before the first frame update
    public float bulletSpeed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Rigidbody2D bulletRB = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bulletRB.velocity = transform.up * bulletSpeed;
            Destroy(bulletRB.gameObject, 2.0f);
            
        }
    }
}
