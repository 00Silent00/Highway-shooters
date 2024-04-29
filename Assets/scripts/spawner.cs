using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
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
    float temphealth;
    int Earray;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy", 1.5f, 4.0f);
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
        int Renemy = Random.Range(0, 100);
        
        switch(Renemy)
        {
        case 76-99:
            Earray = 3;
            break;
        case 66-75:
            temphealth = health * 2;
            Earray = 2;
            break;
        case 40-65:
            temphealth = health * 1.5f;
            Earray = 1;
            break;
        case 0-39:
            Earray = 0;
            break;
        }
        if (Earray == 3)
        {
            
            if (Random.Range(1, 3) == 1)
            {
                enemyClone = Instantiate(enemyS[Earray], new Vector3(2.5f, 1, transform.localPosition.z), enemyS[3].transform.rotation);
            }else
            {
                enemyClone = Instantiate(enemyS[Earray], new Vector3(-2.5f, 1, transform.localPosition.z), enemyS[3].transform.rotation);
            }

        }else
        {
        enemyClone = Instantiate(enemyS[Earray], new Vector3(Random.Range(-5, 5), 1, transform.localPosition.z), transform.rotation);
        enemyClone.GetComponent<enemy>().hp = temphealth;
        }
        if (Earray == 1)
        {
            enemyClone.transform.localScale = new Vector3(transform.localScale.x * 1.5f, transform.localScale.y * 1.5f, transform.localScale.z * 1.5f);
        }
        teller++;
    }
}
