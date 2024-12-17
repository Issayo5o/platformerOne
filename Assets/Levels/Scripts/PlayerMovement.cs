using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    private Animator anim;
    private bool grounded;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
    // flip player when moving left and right
        if (horizontalInput > .01f){
            transform.localScale = new Vector3(0.2f,0.1f,1);

        }
        else if (horizontalInput > -.01f){
            transform.localScale = new Vector3(0.1f,0.1f,1);
            
        }
        
        if(Input.GetKey(KeyCode.Space) && grounded)
        {
            Jump(); 
        }

        //Sets animator Paramters

        anim.SetBool("run", horizontalInput != 0);
        anim.SetBool("grounded", grounded);  
    }
    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpSpeed);
        anim.SetTrigger("jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
