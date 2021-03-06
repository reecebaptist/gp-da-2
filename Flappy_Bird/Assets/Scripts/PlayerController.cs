using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Controls
        float amntToMove = Input.GetAxisRaw("Vertical") * velocity * Time.deltaTime;
        //Move player
        transform.Translate(Vector3.up * amntToMove);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pipe")
        {
            gameManager.GameOver();
        }
    }
}
