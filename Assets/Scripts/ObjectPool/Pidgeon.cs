using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pidgeon : MonoBehaviour
{
   
    private void Awake()
    {
       
        
    }

    private void Start()
    {
        
    }

    public void FlyPidg(GameObject obj)
    {
        obj.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Return")
        {
            ObjectPool.instance.ReturnToPool(gameObject);
            Debug.Log("spawn hit");
        }
    }

}
