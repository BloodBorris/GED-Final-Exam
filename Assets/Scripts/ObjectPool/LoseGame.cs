using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    int lossCon = 0;
    public GameObject reticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pidg")
        {
            lossCon += 1;
            if (lossCon > 3)
            {
                Debug.Log("you lose");
                Destroy(reticle);
            }
        }
    }
}
