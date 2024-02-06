using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollingParallax : MonoBehaviour
{
    [SerializeField] private float scrollingSpeed = -5f;
    private Vector2 _startPos;
    [SerializeField] private RawImage _image;
    // Start is called before the first frame update
    void Start()
    {
        _startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        _image.uvRect = new Rect(_image.uvRect.x, Time.time * scrollingSpeed, _image.uvRect.width, _image.uvRect.height);
        
    }
}
