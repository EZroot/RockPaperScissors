using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ScriptableObjectEditor : Editor
{
    [MenuItem("Assets/Custom Tech-Test/Configs/Mock Profile Config")]
	public static void UserDefinition()
	{
		ScriptableObject asset = ScriptableObject.CreateInstance("ProfileDataConfig");
		string path = AssetDatabase.GetAssetPath(Selection.activeInstanceID);
		if(path.Contains(".")) { path = path.Remove(path.LastIndexOf('/')); }
		string name = UnityEditor.AssetDatabase.GenerateUniqueAssetPath(path + "/ProfileDataConfig.asset");
		AssetDatabase.CreateAsset(asset, name);
		AssetDatabase.SaveAssets();
		Selection.activeObject = asset;
	}

    [MenuItem("Assets/Custom Tech-Test/Configs/Mock Game Config")]
	public static void UseableItemDefinition()
	{
		ScriptableObject asset = ScriptableObject.CreateInstance("GameUpdateDataConfig");
		string path = AssetDatabase.GetAssetPath(Selection.activeInstanceID);
		if(path.Contains(".")) { path = path.Remove(path.LastIndexOf('/')); }
		string name = UnityEditor.AssetDatabase.GenerateUniqueAssetPath(path + "/GameUpdateDataConfig.asset");
		AssetDatabase.CreateAsset(asset, name);
		AssetDatabase.SaveAssets();
		Selection.activeObject = asset;
	}
}
