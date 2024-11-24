using UnityEngine;

public class RocketLauncherScript : MonoBehaviour
{
    public GameObject rocket;
    public float spawnRate = 4;
    private float timer = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            launchRocket();
            timer = 0;
        }
    }

    void launchRocket()
    {
        Instantiate(rocket, new Vector3(transform.position.x, Random.Range(-4, 4), 0), transform.rotation);
    }
}
