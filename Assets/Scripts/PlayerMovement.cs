using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManager gameManager;
    public PlayerSound sound;
    public PlayerAnimator animator;
    public ParticleSystem dieParticle;
    public ParticleSystem runParticle;
    public Rigidbody body;
    public float jumpForce;


    private void Start()
    {
        animator.Run();
        runParticle.Play();
    }


    private void Update()
    {
        Jump();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Obstacle obstacle))
        {
            Die();
        }
    }


    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && !gameManager.isGameOver)
        {
            body.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
            animator.Jump();
            sound.PlayRandomJumpSfx();
        }
    }

    private void Die()
    {
        gameManager.GameOver();
        animator.Die();
        dieParticle.Play();
        runParticle.Stop();
        sound.PlayRandomDieSfx();
    }
}
