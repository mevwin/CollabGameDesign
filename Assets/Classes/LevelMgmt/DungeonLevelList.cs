using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DungeonLevelList", menuName = "Scriptable Objects/DungeonLevelList")]
public class DungeonLevelList : ScriptableObject
{
    [SerializeField] private List<string> list = new();
    

    public string GetLevelName(int index)
    {
        return list[index];
    }

    public int GetSize()
    {
        return list.Count;
    }
    
}
