using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    private Rigidbody2D playerBody;
    private Animator playerAnimator;
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        playerBody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical")
        ) * playerSpeed * Time.deltaTime;

        playerAnimator.SetFloat("inputHorizontal", playerBody.velocity.x);
        playerAnimator.SetFloat("inputVertical", playerBody.velocity.y);

    }
}
