using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    Vector3 move;
    Vector3 Inversemove;
    GameObject ret;

    public MoveCommand(GameObject obj, Vector3 pos, Vector3 inversepos)
    {
        ret = obj;
        move = pos;
        Inversemove = inversepos;
    }

    public void Execute()
    {
        ret.transform.position = move;
    }

    public void Inverse()
    {
       
        ret.transform.position = Inversemove;
    }
}
