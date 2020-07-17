using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommnad : MonoBehaviour, ICommand
{
    public void Execute()
    {
        JumpComnd();
    }

    private void JumpComnd() 
    {
        Debug.Log("Jump");
    }

}