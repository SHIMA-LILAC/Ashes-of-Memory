using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Скорость движения персонажа
    
    public Rigidbody2D rb;
    Vector2 movement;
    private Animator animator;
    public float speed = 5f;
    AnimatorClipInfo[] animatorinfo;
    

    void Start()
    {
       
        animator = GetComponent<Animator>();

       // PersistentPlayer.Instance.AddPersistentComponent(this);
    }

    void Update()
    {
        // Движение по оси X
       
        

        movement.x = Input.GetAxisRaw("Horizontal");
       

        animator.SetFloat("Horizontal", movement.x);
       
        animator.SetFloat("Speed", movement.sqrMagnitude);


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
    }
}