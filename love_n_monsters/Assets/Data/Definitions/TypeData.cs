using UnityEngine;

[CreateAssetMenu(fileName = "NewType", menuName = "MonData/Type")]
public class TypeData : ScriptableObject
{
    public string typeName;
    [TextArea]
    public string description;
}


