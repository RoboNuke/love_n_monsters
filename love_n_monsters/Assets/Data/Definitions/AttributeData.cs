using UnityEngine;

[CreateAssetMenu(fileName = "NewAttribute", menuName = "MonData/Attribute")]
public class AttributeData : ScriptableObject
{
    public string attributeName;
    [TextArea]
    public string description;
}


