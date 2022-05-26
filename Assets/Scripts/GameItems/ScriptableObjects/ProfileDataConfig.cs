using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ProfileDataConfig : ScriptableObject
{
    [SerializeField]
    ProfileData _userData = null;
    public ProfileData ProfileData
    {
        get { return _userData; }
        set { _userData = value; }
    }
}
