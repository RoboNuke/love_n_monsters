using UnityEngine;

[CreateAssetMenu(fileName = "NewSpecies", menuName = "MonData/Species")]
public class SpeciesData : ScriptableObject
{
    [Header("Identity")]
    public string speciesName;
    public int speciesID;
    [TextArea]
    public string description;

    [Header("Physical Base Stats")]
    public StatGroup baseStats;
    

    [Header("Physical Attributes")]
    public AttributeData[] attributes;

    [Header("Starting Moves")]
    public MoveData[] startingMoves;

    [Header("Visuals")]
    public Sprite sprite;
}


