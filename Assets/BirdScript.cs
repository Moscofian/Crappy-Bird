using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class BirdScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D birdRigidbody;
    public float flapStrength;
    public GameOverScript gameOver;
    public bool isBirdAlive = true;

    void Start()
    {
        gameOver = GameObject.FindGameObjectWithTag("Logic").GetComponent<GameOverScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame == true && isBirdAlive == true)
        {
            birdRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.GameOver();
        isBirdAlive = false;
    }
}
