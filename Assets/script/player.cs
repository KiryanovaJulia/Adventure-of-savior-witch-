using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 3f;
    public int lives = 3;
    public float jumpforce = 5f;

    private bool isgr = false;


    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void FixedUpdate() {
        CheckerJump();
    } 
        
    private void Update() {
        if (Input.GetButton("Horizontal")){
            Run();
        }
        if (isgr && Input.GetButtonDown("Jump")){
            Jump();
        }
    } 
        
    
    private void Run () {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        
        transform.position = Vector3.MoveTowards(transform.position,transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump () 
    {
        rb.AddForce(transform.up * jumpforce, ForceMode2D.Impulse);
    }

    private void CheckerJump () {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position,0.3f);
        isgr = collider.Length > 1;
    }

}
