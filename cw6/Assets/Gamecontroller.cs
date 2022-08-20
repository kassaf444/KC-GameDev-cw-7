using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    public Transform spawn;
    public Transform spawnleft;
    public Transform spawnright;

    public float delay;

    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnEnemy()
    {
        int randNum = Random.Range(1, 4); //1 or 2 or 3
        if (randNum == 1)
        {
            Instantiate(Enemy, spawnleft);
        }
        else if (randNum == 2)
        {
            Instantiate(Enemy, spawn);
        }
        else
        {
            Instantiate(Enemy, spawn);

        }
    }
}
        



