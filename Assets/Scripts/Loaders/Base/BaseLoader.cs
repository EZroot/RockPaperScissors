using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class BaseLoader<T>
{
    public abstract void Load();
    public abstract void LoadFake(T data);

}
