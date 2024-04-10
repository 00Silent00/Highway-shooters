using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    public float hp;
    public float skade;
    public float teller;
    // Start is called before the first frame update
    void Start()
    {

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
            hp -= other.gameObject.GetComponent<bullet>().dmg;
        }
        if (hp < 1)
        {
            Destroy(gameObject);
        }
    }
}
