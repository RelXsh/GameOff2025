using UnityEngine;

[CreateAssetMenu(menuName = "Fishing/Fish Data")]
public class FishData : ScriptableObject
{
    [Header("Basic Info")]
    public string fishName;
    [TextArea] public string description;
    public Sprite sprite;

    [Header("Stats")]
    [Range(0f, 1f)] public float rarity = 0.5f; // 0 = common, 1 = rare
    public float speed = 2f; // base swim speed

    [Header("Dating Data")]
    public DialogueData[] dialogues; // references to dialogue ScriptableObjects
    public int datingProgress; // current dating progress (dialogue counter tbh)
    public int currentDialogueProgress;
    public AudioClip voiceClip; // optional cute fish sound

    [Header("Visuals")]
    public Color accentColor = Color.cyan; // UI tint or affection color
}
