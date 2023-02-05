using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private State currentState;

    public void SwitchState(State newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }

     public void Update()
    {
        // THE ? MEANS IT:
        //if(currentState != null)
        //{
        //currentState.Tick(Time.deltaTime);
        //}
        
        currentState?.Tick(Time.deltaTime);        
    }


}
