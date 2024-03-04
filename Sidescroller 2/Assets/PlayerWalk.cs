using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public Animator animator;
    public float baseMoveSpeed = 1f; // Base movement speed
    public float maxMoveSpeedBoost = 2f; // Maximum allowed speed boost
    private float currentMoveSpeed; // Current movement speed
    private bool isFacingRight = true;
    public VectorValue startingPosition;


    private void Start()
    {
        animator = GetComponent<Animator>();
        currentMoveSpeed = baseMoveSpeed;
        transform.position = startingPosition.initialValue;
    }

    private void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        if (moveInput != 0)
        {
            animator.SetBool("IsWalking", true);

            // Flip the sprite based on movement direction
            if ((moveInput < 0 && isFacingRight) || (moveInput > 0 && !isFacingRight))
            {
                isFacingRight = !isFacingRight;
                Vector3 newScale = transform.localScale;
                newScale.x *= -1;
                transform.localScale = newScale;
            }
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentMoveSpeed = Mathf.Min(currentMoveSpeed + 0.3f, baseMoveSpeed + maxMoveSpeedBoost); // Increase speed but limit to maxMoveSpeedBoost
        }
        else
        {
            currentMoveSpeed = baseMoveSpeed; // Reset speed to base when shift key is not pressed
        }

        // Move the character
        transform.Translate(Vector3.right * moveInput * currentMoveSpeed * Time.deltaTime);
    }
}
