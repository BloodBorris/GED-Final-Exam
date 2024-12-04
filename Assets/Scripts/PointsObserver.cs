using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsObserver : MonoBehaviour
{
    ReticleManager manager;
    public Text curPoints;
    public List<int> pointsStorage = new List<int>();
    public List<Text> HighScore = new List<Text>();
    int oldpoints = 0;

   
    // Start is called before the first frame update
    void Start()
    {
        curPoints.text = ("points ");
        manager = FindObjectOfType<ReticleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        DetectPointChange();
    }

    void DetectPointChange()
    {
        if(manager.GetPoints() != oldpoints)
        {
            oldpoints = manager.GetPoints();
            AlertPointsList();
        }
    }

    void AlertPointsList()
    {
        curPoints.text = ("points " + manager.GetPoints().ToString());

        for(int i = 0; i < HighScore.Count; i++)
        {
            if(pointsStorage[i] < manager.GetPoints())
            {
                HighScore[i].text = manager.GetPoints().ToString();
            }
            
        }
    }

}
