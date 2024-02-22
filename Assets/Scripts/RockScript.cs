using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockScript : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField, Range(0, 10)] public float flapStength;
    public GameManager gameManager;
    public bool rockIsAlive = true;
    AudioManager audioManager;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && rockIsAlive)
        {
            rb.velocity = Vector2.up * flapStength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.gameOver();
        rockIsAlive = false;
        audioManager.PlaySFX(audioManager.death);
    }
}
