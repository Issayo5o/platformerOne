using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameOver gameOver;
    public TextMeshProUGUI gameOverText;
    public Button restart;

    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jumpSpeed;
    private Animator anim;
    private bool grounded;


    public Image Red_Heart;
    public Image Red_Heart2;
    public Image Red_Heart3;

    public Image Grey_Heart;    
    public Image Grey_Heart2;
    public Image Grey_Heart3;

    public int number = 0;
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
            transform.localScale = new Vector3(0.1f,0.1f,1);

        }
        else if (horizontalInput == 0){
            transform.localScale = new Vector3(0.1f,0.1f,1);
            
        }
        else if (horizontalInput > -.01f){
            transform.localScale = new Vector3(-0.1f,0.1f,1);
            
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

        if (collision.gameObject.CompareTag("Obstacle") && number == 0)
        {
            Red_Heart.gameObject.SetActive(false);
            Grey_Heart.gameObject.SetActive(true);
            number = 1;
        }
        else if (collision.gameObject.CompareTag("Obstacle") && number == 1)
        {
            Red_Heart2.gameObject.SetActive(false);
            Grey_Heart2.gameObject.SetActive(true);
            number = 2;
        }
        else if (collision.gameObject.CompareTag("Obstacle") && number == 2)
        {
            Red_Heart3.gameObject.SetActive(false);
            Grey_Heart3.gameObject.SetActive(true);
            number = 3;
            gameOverText.gameObject.SetActive(true);
            gameOver.EndGame();
            //with this number you could probably add a gameover method
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }

    

}
