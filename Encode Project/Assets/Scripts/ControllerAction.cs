using UnityEngine;

public class ControllerAction : MonoBehaviour
{
    private Rigidbody2D rb2;
    private Animator anim;
    private SpriteRenderer sr;
    private BoxCollider2D coll;
    private float dirX;
    internal int platID;
    private GameObject platform;

    public GameObject Platform { get { return platform; } }

    [SerializeField] private float speed = 1f;
    [SerializeField] private float jump = 2f;
    [SerializeField] private LayerMask jumpableGround;

    public float DirX
    {
        get {
            return dirX; 
        }
        set {
            dirX = value; 
        }
    }

    public bool flip {
        get { return sr.flipX; }
        set { sr.flipX = value; }
    }

    private enum MovementState
    {
        idle,
        run,
        fall,
        jump
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        rb2.velocity = new Vector2(dirX * speed, rb2.velocity.y);

        if (Input.GetKeyDown("w") && isGrounded())
        {
            rb2.velocity = new Vector2(rb2.velocity.x, jump);
        }

        UpdateAnimationState();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            platform = collision.gameObject;
        }   
    }

    private void UpdateAnimationState()
    {
        MovementState state;

        if (dirX > 0f)
        {
            state = MovementState.run;
            sr.flipX = false;
        }
        else if (dirX < 0f)
        {
            state = MovementState.run;
            sr.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if(rb2.velocity.y > 0.1f)
        {
            state = MovementState.jump;
        }

        if(rb2.velocity.y < -0.1f)
        {
            state = MovementState.fall;
        }
        anim.SetInteger("AnimationState", (int)state);
    }

    private bool isGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.05f, jumpableGround);
    }
}
