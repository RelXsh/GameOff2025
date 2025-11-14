using UnityEngine;

[CreateAssetMenu(menuName = "Dating/Date Data")]

public class DialogueData : ScriptableObject
{
    [Header("Basic Info")]
    public string dialogueName;
    public int dialogueParticipants;
    [Header("Diagole text")]
    public string[] fishText;
    public string[] playerText;
    public string[] thirdPartyText;
    public string[] fourtPartyText;
}
