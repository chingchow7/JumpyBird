using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScriptComplete : MonoBehaviour
{

    private GameManager gameManager_;
    private ScoreManager scoreManager_;

    public Rigidbody2D rigidbody_;
    public PlayerBottomCollider groundCollider;
    public float playerspeed = 5f;

    private bool playerBlocked = false;
    private Vector2 up = new Vector2(0f, 100f);

    // Called at the start of the scene/game
    void Start()
    {
        gameManager_ = GameObject.Find("GameManager").GetComponent<GameManager>();
        scoreManager_ = GameObject.Find("GameManager").GetComponent<ScoreManager>();
    }

    // Called once per frame
    void Update()
    {
        // TODO [ADVANCED] Do not move when the playerBlocked is true
        if (gameManager_.gameStarted && !gameManager_.playerDead && !playerBlocked)
        {
            // Player moves right
            this.gameObject.transform.Translate(Vector3.right * Time.deltaTime * playerspeed);
        }

        // Listen for space key and jump
        // TODO [BASIC] Listen for space key to jump
        if (Input.GetKeyDown(KeyCode.Space) && groundCollider.isGrounded)
        {
            Jump();
            Debug.Log("Space");
        }

    }

    // Called when player (bird) collides with another game object collider
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ScoreCollider")
        {
            // Update score when player collides with invisible "ScoreCollider"
            scoreManager_.score++;
            other.gameObject.SetActive(false);
        }

        // TODO [INTERMEDIATE] Kill game when player collides with "CactiCollider"
        if (other.gameObject.tag == "KillCollider" || other.gameObject.tag == "CactiCollider")
        {
            gameManager_.playerDead = true;
        }

        // TODO [ADVANCED] Update playerBlocked to true when player collides with "BoxCollider"
        if (other.gameObject.tag == "BoxCollider")
        {
            playerBlocked = true;
        }
    }

    // Called when player (bird) no longer collides with game object collider
    private void OnTriggerExit2D(Collider2D other)
    {
        // TODO [ADVANCED] Update playerBlocked to false when player (bird) no longer collides with "BoxCollider"
        playerBlocked = false;
    }

    public void Jump()
    {
        // TODO [BASIC] Add an upward force to implement jump
        // TODO [BASIC] Update groundCollider value to false
        rigidbody_.AddForce(up);
        groundCollider.isGrounded = false;
    }
}
