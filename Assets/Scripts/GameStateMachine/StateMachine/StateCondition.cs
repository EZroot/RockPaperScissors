using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateCondition<T> : MonoBehaviour, IStateCondition<T> where T : StateMachine<T>
{
    public abstract bool OnCondition(State<T> curr,State<T> next);
}