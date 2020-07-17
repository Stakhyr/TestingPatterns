using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    ICommand buttonA_;
    ICommand buttonD_;
    ICommand buttonBackSpace_;
    ICommand buttonMouse0_;
    ICommand buttonMouse1_;

    //bool BUTTON_A = Input.GetKey(KeyCode.A);
    //bool BUTTON_D = Input.GetKey(KeyCode.D);
    //bool BUTTON_BackSpace = Input.GetKey(KeyCode.Backspace);
    //bool BUTTON_Mouse0 = Input.GetKey(KeyCode.Mouse0);
    //bool BUTTON_Mouse1 = Input.GetKey(KeyCode.Mouse1);


    void Start()
    {

        

        buttonA_ = new MoveCommand();
        buttonD_ = new MoveCommand();
        buttonBackSpace_ = new JumpCommnad();
        buttonMouse0_ = new AtackCommand();
        buttonMouse1_ = new AtackCommand();


    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) buttonA_.Execute();
        if (Input.GetKey(KeyCode.D)) buttonD_.Execute();
        if (Input.GetKey(KeyCode.Backspace)) buttonBackSpace_.Execute();
        if (Input.GetKey(KeyCode.Mouse0)) buttonMouse0_.Execute();
        if (Input.GetKey(KeyCode.Mouse1)) buttonMouse1_.Execute();


    }





}
