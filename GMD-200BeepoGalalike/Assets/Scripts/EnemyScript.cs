using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private GameObject circlePrefab;
    [SerializeField] private float respawnY = 10f;
    private float respawnX;
    private Rigidbody2D _rigidbody2d;
    public float vertical = -10f, horizontal;
    private void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
        _rigidbody2d.velocity = new Vector2(horizontal, vertical);
    }
    private void Start()
    {
        respawnX = transform.position.x;
    }

    public void Respawn()
    {
        gameObject.SetActive(true);
        transform.position = new Vector2(respawnX, respawnY);
        _rigidbody2d.velocity = Vector2.zero;

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Laser"))
        {
            Despawn();
        }
    }
    private void Despawn()
    {
        
        gameObject.SetActive(false);
        Instantiate(circlePrefab, transform.position, transform.rotation);
        ScoreManager.instance.Addpoint();
    }
}
