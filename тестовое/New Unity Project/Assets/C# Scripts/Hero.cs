using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hero : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 1f;
    private bool Face = true;
    public float jumpForce = 6f;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius = 0.01f;
    private int extajumps;
    public int extrajumpValue;
    public LayerMask whatisground;
    public float zad;
    public float time=0.3f;
    public float timerforjump=0.3f;
    public float timeforjump;
    public GameObject restartDialog;

    private void Awake()
    {

        zad = time;
       timeforjump= timerforjump;
    }
    
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadMen" || collision.collider.name == "DeadMen(Clone)")
        {
            restartDialog.SetActive(true);
        }
    }
    void Start()
    {
        extajumps = extrajumpValue; 
        rb = GetComponent<Rigidbody2D>();
        
    }
    private void Flip()
    {
        Face = !Face;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
    // Update is called once per frame
    void Update()
    {
        timeforjump -= Time.deltaTime;
        if (extajumps==0)
        {
            zad -= Time.deltaTime;
        }
        if (isGrounded==true && zad<0.0f)
        {
            extajumps = extrajumpValue;
            zad = time;
        }
        if (Input.GetKeyDown(KeyCode.Space) && extajumps >0 && timeforjump<0.0f)
        {
            rb.velocity = Vector2.up * jumpForce;
            extajumps--;
            timeforjump = timerforjump;
        }
         

    }
    public bool left=false;
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position,checkRadius, whatisground);
        if (rb.position.x<2 && left==false)
        {
            if (Face)
            {
                Flip();
            }
            Vector2 targetVelocity = new Vector2(1 * 3f, rb.velocity.y);
            rb.velocity = targetVelocity;
            
        }
        else
        {
            left = true;
            
        }
        if (rb.position.x>-2 && left==true)
        {
            if (!Face)
            {
                Flip();
            }
            Vector2 targetVelocity = new Vector2(-1 * 3f, rb.velocity.y);
            rb.velocity = targetVelocity;
            
        }
        else
        {
            left = false;
            
        }
        


    }
}
