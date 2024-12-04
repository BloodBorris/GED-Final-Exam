using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleManager : MonoBehaviour
{
    CommandManager Manager;
    public GameObject reticle;
    bool reverse = false;
    bool KillFeild = false;
    int points = 0;
    int pawnKilled = 0;

    // Start is called before the first frame update
    void Start()
    {
        Manager = new CommandManager();
    }

    // Update is called once per frame
    void Update()
    {
       
         if (Input.GetKeyDown(KeyCode.D))
         {
                ICommand com = new MoveCommand(reticle, reticle.transform.position + Vector3.right, reticle.transform.position + Vector3.left);
                if(reverse == false)
                {
                    Manager.DoExecute(com);
                }
                else
                {
                    Manager.DoInverse(com);
                }
                
         }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ICommand com = new MoveCommand(reticle, reticle.transform.position + Vector3.down, reticle.transform.position + Vector3.up);
            if (reverse == false)
            {
                Manager.DoExecute(com);
            }
            else
            {
                Manager.DoInverse(com);
            }

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ICommand com = new MoveCommand(reticle, reticle.transform.position + Vector3.left, reticle.transform.position + Vector3.right);
            if (reverse == false)
            {
                Manager.DoExecute(com);
            }
            else
            {
                Manager.DoInverse(com);
            }

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ICommand com = new MoveCommand(reticle, reticle.transform.position + Vector3.up, reticle.transform.position + Vector3.down);
            if (reverse == false)
            {
                Manager.DoExecute(com);
            }
            else
            {
                Manager.DoInverse(com);
            }

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            KillFeild = true;
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            KillFeild = false;
        }
        


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Pidg")
        {
            
            if(KillFeild == true)
            {
                ObjectPool.instance.ReturnToPool(other.gameObject);
                points += 10;
                reverse = !reverse;
                pawnKilled += 1;
                Debug.Log(points);
                if(pawnKilled >= 10)
                {
                    Debug.Log("new level");
                    ObjectPool.instance.SetRangeExspanes((ObjectPool.instance.GetRangeExspanse() / 2));
                }
            }
            
            
        }
    }

    public int GetPoints()
    {
        return points;
    }
}
