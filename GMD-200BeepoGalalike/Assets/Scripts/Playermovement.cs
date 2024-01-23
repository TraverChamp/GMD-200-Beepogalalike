using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Playermovement : MonoBehaviour
{
    public Vector2 input;
    [SerializeField] private Vector2 moveSpeed;
    [SerializeField] private float boundsLeft = -5;
    [SerializeField] private float boundsRight = 5;
    [SerializeField] private float boundsUp = -2f;
    [SerializeField] private float boundsDown = -15f;
    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        input = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical") );
    }
    private void FixedUpdate()
    {
        _rb.velocity = input * moveSpeed;
        Vector2 position = transform.position;
        position.x = Mathf.Clamp(position.x, boundsLeft, boundsRight);
        position.y = Mathf.Clamp(position.y, boundsDown, boundsUp);
        transform.position = position;
    }
}
