using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeGenerator : MonoBehaviour
{
    public GameObject spike;
    public float minspeed;
    public float maxspeed;
    public float currentspeed;
    public float multiplyspeed;
    // Start is called before the first frame update
    void Awake()
    {
        currentspeed = minspeed;
        generator();
    }
    public void generator()
    {
        GameObject Ins = Instantiate(spike,transform.position,transform.rotation);
        Ins.GetComponent<Spikescript>().gen = this;
    }
    void Update()
    {
        if (currentspeed < maxspeed)
        {
            currentspeed += multiplyspeed;
        }
    }
 
}
