using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateCondition<T> where T : StateMachine<T>
{
abstract bool OnCondition(State<T> curr,State<T> next);
}

