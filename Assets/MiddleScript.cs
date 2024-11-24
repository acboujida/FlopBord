using Unity.VisualScripting;
using UnityEngine;

public class MiddleScript : MonoBehaviour
{
    public LogicScript logicScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            logicScript.addScore();
        }
    }
}
