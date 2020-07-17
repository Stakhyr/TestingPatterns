using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveCommand : MonoBehaviour, ICommand
{
    Rigidbody2D player;
    public void Execute()
    {
        MoveComnd();
    }

    private void MoveComnd() 
    {
        transform.position = new Vector2(transform.position.x * 20, transform.position.y) ;

    }
    void Start() 
    {
        player = gameObject.GetComponent<Rigidbody2D>();
    }

}