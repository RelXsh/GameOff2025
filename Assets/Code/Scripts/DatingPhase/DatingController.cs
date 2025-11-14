using UnityEngine;
using TMPro;

public class DatingController : MonoBehaviour
{
    public TextMeshProUGUI dialogueTextField;
    private TypeEffect dialogueTyper;
    public TextMeshProUGUI fishNameTextField;
    public TextMeshProUGUI playerNameTextField;
    public GameObject fishImageField;
    public FishData currentfishData;

    private DialogueData[] allDialogues;
    private DialogueData currentDialogue;

    private int dialogueProgress = 0;
    private int speakerPointer = 0; //0 == fish, 1 == player, 2 == third party?


    void LoadFish(FishData newfish)
    {
        currentfishData = newfish;
        
        allDialogues = currentfishData.dialogues;
        currentDialogue = allDialogues[currentfishData.datingProgress];
    }
    void Start()
    {
        dialogueTyper = dialogueTextField.GetComponent<TypeEffect>();
        if(dialogueTyper == null)
        {
            Debug.Log("not found");
        }
        if(currentfishData != null)
        {
            LoadFish(currentfishData);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //progress dialoge
        {
            while (dialogueProgress < currentDialogue.playerText.Length) //wile there is available dialoge
            {
                if (speakerPointer == 0)
                {
                    if (dialogueProgress >= currentDialogue.fishText.Length || string.IsNullOrEmpty(currentDialogue.fishText[dialogueProgress])) //if nothing to say go to next speaker
                    {
                        speakerPointer++;
                    }
                    else
                    {
                        dialogueTyper.Print(currentDialogue.fishText[dialogueProgress]);
                        speakerPointer++;
                        break;
                    }
                }
                if (speakerPointer == 1)
                {
                    if (dialogueProgress  >=  currentDialogue.playerText.Length || string.IsNullOrEmpty(currentDialogue.playerText[dialogueProgress])) //if nothing to say go to next speaker
                    {
                        speakerPointer++;
                    }
                    else
                    {
                        dialogueTyper.Print(currentDialogue.playerText[dialogueProgress]);
                        speakerPointer++;
                        break;
                    }
                }
                if (speakerPointer == 2)
                {
                    if (dialogueProgress >= currentDialogue.thirdPartyText.Length || string.IsNullOrEmpty(currentDialogue.thirdPartyText[dialogueProgress])) //if nothing to say go to next speaker
                    {
                        speakerPointer++;
                    }
                    else
                    {
                        dialogueTyper.Print(currentDialogue.thirdPartyText[dialogueProgress]);
                        speakerPointer++;
                        break;
                    }
                }
                if (speakerPointer == 3)
                {
                    if (dialogueProgress >= currentDialogue.fourtPartyText.Length || string.IsNullOrEmpty(currentDialogue.fourtPartyText[dialogueProgress])) //if nothing to say go to next speaker
                    {
                        speakerPointer++;
                    }
                    else
                    {
                        dialogueTyper.Print(currentDialogue.fourtPartyText[dialogueProgress]);
                        speakerPointer++;
                        break;
                    }
                }
                if(speakerPointer >= currentDialogue.dialogueParticipants)
                {
                    speakerPointer = 0;
                    dialogueProgress++;
                    Debug.Log(dialogueProgress);
                }
            }
        }
    }
}
