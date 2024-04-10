using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class spawner : MonoBehaviour
{
    public GameObject[] enemy;
    public float health = 2.0f;
    public int teller;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 1.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (teller > 10)
        {
            health ++;
            teller = 0;
        }
    }
    void spawnEnemy()
    {
        Instantiate(enemy[0], new Vector3(transform.position.x, 1, transform.localPosition.z), enemy[0].transform.rotation);
        teller++;
    }
}
