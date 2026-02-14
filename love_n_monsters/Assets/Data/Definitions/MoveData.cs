using UnityEngine;


[System.Serializable]
public enum MoveCategory
{
    ATTACK,  // Default value is 0
    SPECIAL,   // Value is 1
    STATUS,    // Value is 2
}


[CreateAssetMenu(fileName = "NewMove", menuName = "MonData/Move")]
public class MoveData : ScriptableObject
{
    [Header("Identity")]
    public string moveName;
    public int moveID;
    [TextArea]
    public string description;
    public TypeData type1;
    public TypeData type2;

    public MoveCategory category;


    [Header("Requirements")]
    public AttributeData[] requiredAttributes;
    public StatGroup requiredStats;
    public ProficiencyRequirement[] proficiencyRequirements;

    [Header("Effect on Stats")]
    public StatGroup deltaStats;


    [Header("Battle Parameters")]
    public int power;
    public int accuracy;
    public int critMod;

    //[Header("Visuals")]
    // Placeholder for now

}


[System.Serializable]
public struct ProficiencyRequirement
{
    public int uses;
    public MoveData move;
}


[System.Serializable]
public struct StatGroup
{
    public float strength;
    public float bodyComp;
    public float special;
}

