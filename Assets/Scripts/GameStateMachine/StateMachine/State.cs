using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State<T> : MonoBehaviour, IState where T : StateMachine<T>
{
    BaseFeature _baseFeature;
    public BaseFeature BaseFeature {get=>_baseFeature;set=>_baseFeature=value;}
    
    public virtual void OnEnter()
    {
        
    }

    public virtual void OnUpdate()
    {
    }

    public virtual void OnExit()
    {

    }
}