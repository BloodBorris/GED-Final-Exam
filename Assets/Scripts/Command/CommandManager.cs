using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandManager : MonoBehaviour
{
   


    public void DoExecute(ICommand com)
    {
        com.Execute();
       
    }

    public void DoInverse(ICommand com)
    {
        com.Inverse();
    }
}
