using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

	public Rigidbody2D rb;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	public bool onGround;


    public Text distanceLabel; 

    public int distance = 0;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        this.updateDistance();

    }

    void updateDistance(){

        distanceLabel.text = "Distance "  + distance + " m";

    }

    // Update is called once per frame
    void Update()
    {
       

     	rb.velocity = new Vector2(3, rb.velocity.y);   
        onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
     	if (Input.GetKey(KeyCode.Space)  && onGround)
        {
                //rb.velocity = new Vector2(rb.velocity.x, 5);
        }

        distance = distance  + 1;
        this.updateDistance();

    }

    private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "Enemy")
    {
        rb.transform.position = new Vector2(-5, -3);  
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().Hello();
        distance = 0;     
        this.updateDistance();


    }
}
}


