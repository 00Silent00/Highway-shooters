using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerM : MonoBehaviour
{
    public float speed;
    private float HorizontalInput;
    public GameObject bullet;
    public int dmg;
    public GameObject spawner;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 1, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * HorizontalInput * Time.deltaTime);
        if (transform.position.x < -5)
        {
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 5)
        {
            transform.position = new Vector3(5, transform.position.y, transform.position.z);
        }

    }
    void shoot ()
    {
        Vector3 spawn = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        spawner = Instantiate(bullet, spawn, bullet.transform.rotation);
        spawner.GetComponent<bullet>().dmg = dmg;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Powerup")
        {
            spawner.GetComponent<spawner>().dmg = dmg;
            
        }
    }
}
