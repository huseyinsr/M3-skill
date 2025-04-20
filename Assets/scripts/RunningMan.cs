using UnityEngine;

public class RunningMan : MonoBehaviour
{
    Animator animator;

    Vector3 acceleration = Vector3.zero;
    Vector3 velocity = Vector3.zero;
    float h0;
    bool isJumping = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        h0 = transform.position.y;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            print("jump");
            animator.Play("Jump");
            acceleration = new Vector3(0, -36, 0);
            velocity = new Vector3(0, 10, 0);
            isJumping = true;
        }

        // Beweging bijhouden
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;

        // Terug op de grond?
        if (transform.position.y < h0)
        {
            acceleration = Vector3.zero;
            velocity = Vector3.zero;
            transform.position = new Vector3(transform.position.x, h0, 0);
            animator.Play("Running");
            isJumping = false;
        }
    }
}
