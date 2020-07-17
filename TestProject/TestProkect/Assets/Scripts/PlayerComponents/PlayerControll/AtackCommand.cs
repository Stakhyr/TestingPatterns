using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackCommand : MonoBehaviour, ICommand
{
    public void Execute()
    {
        AtackComnd();
    }

    private void AtackComnd() 
    {
        Debug.Log("Atack");

    }

}
