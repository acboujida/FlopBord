using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    public LogicScript logicScript;
    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rigidBody2D.linearVelocity = Vector2.up * 20;
        }
        if (transform.position.y <= -10.74)
        {
            isAlive = false;
            logicScript.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        isAlive = false;
    }
}
