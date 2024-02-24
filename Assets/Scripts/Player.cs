using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public float speed;
    public float jumpForce;
    public Rigidbody2D rb;
    private float _startXPosition;
    public BirdAnimation birdAnimation;

    private void Awake()
    {
        _startXPosition = transform.position.x;
    }

    private void Update()
    {
        transform.position = new Vector3(_startXPosition, transform.position.y);
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2();
            rb.AddForce(transform.up*jumpForce,ForceMode2D.Impulse);
            birdAnimation.StartRotation(); 
            GameManager.instance.AudioManager.PlayJump(true);
        }
        birdAnimation.ApplyRotation(rb.velocity.y); 
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (!other.gameObject.CompareTag("PipePart") && !other.gameObject.CompareTag("Floor")) return;
        
        GameManager.instance.AudioManager.PlayHit(true);
        GameManager.instance.Lose();
    }
    
}
