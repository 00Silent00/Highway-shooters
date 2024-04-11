using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Bspeed;
    public int dmg;
    // Start is called before the first frame update
    void Start()
    {
        PlayerM Pdmg = GameObject.Find("Player").GetComponent<PlayerM>();
        dmg = Pdmg.dmg;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Bspeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        {
            if (other.gameObject.tag != "Player")
            {
                Destroy(gameObject);    
            }
                
        }   
    }
}
