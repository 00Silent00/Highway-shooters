using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float Bspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Bspeed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        {
            Destroy(gameObject);    
        }   
    }
}
