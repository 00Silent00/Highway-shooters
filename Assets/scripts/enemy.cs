using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public float hp;
    public PlayerM spiller;  
    public spawner maker;
    public float skade;
    public float teller;
    // Start is called before the first frame update
    void Start()
    {
        skade = spiller.dmg;
        hp = maker.health;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    private void OnTriggerEnter (Collider other)
    {
        
        if (other.gameObject.tag == "bullet")
        {
            hp = hp -skade;
        }
        if (hp < 1)
        {
            Destroy(gameObject);
        }
    }
}
