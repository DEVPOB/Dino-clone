using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spikescript : MonoBehaviour
{
    
    public SpikeGenerator gen;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * gen.currentspeed * Time.deltaTime);
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("nextline"))
        {
            gen.generator();
        }
        if (other.gameObject.CompareTag("Finished"))
        {
            Destroy(this.gameObject);
        }
    }
    
    
}
