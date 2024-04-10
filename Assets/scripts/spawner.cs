using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class spawner : MonoBehaviour
{
    public GameObject[] enemyS;
    public float health = 2.0f;
    public int teller;
    public int dmg;
    public GameObject enemyClone;
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
        
        enemyClone = Instantiate(enemyS[0], new Vector3(Random.Range(-5, 5), 1, transform.localPosition.z), enemyS[0].transform.rotation);
        enemyClone.GetComponent<enemy>().hp = health;
        enemyClone.GetComponent<enemy>().skade = dmg;
        teller++;
    }
}
