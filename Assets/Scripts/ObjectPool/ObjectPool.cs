using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    int poolSize = 50;
    public GameObject pref;
    Queue<GameObject> pool = new Queue<GameObject>();
    Pidgeon pidge;
    public GameObject spawn;
    public static ObjectPool instance;
    int rangeExspanse = 1000;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        CreatePool();
        pidge = new Pidgeon();
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(1, rangeExspanse) == 1)
        {
            GetFromPool(new Vector3(RandomSpawn(), -5.59f, 22.4f));
        }
    }

    void CreatePool()
    {
        for(int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(pref);
            pool.Enqueue(obj);
            obj.SetActive(false);
        }
    }

    void GetFromPool(Vector3 pos)
    {
        GameObject obj = pool.Dequeue();
        obj.SetActive(true);
        obj.transform.position = pos;
        pidge.FlyPidg(obj);
        
    }

    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Enqueue(obj);
    }

    float RandomSpawn()
    {
       
       return Random.Range(-12, 12); 
    }
        
    public void SetRangeExspanes(int num)
    {
        rangeExspanse = num;
    }

    public int GetRangeExspanse()
    {
        return rangeExspanse;
    }
}
