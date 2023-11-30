using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System .Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;

}

public class Areum_Talk : MonoBehaviour
{
    [SerializeField] private SpriteRenderer Dialogue;
    [SerializeField] Text txt_Dialogue;

    private bool isDialogue = false;

    public int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    // Start is called before the first frame update
    void Start()
    {
        OnOff(true);
        count = 0;
        isDialogue = true;
        NextDialogue();

    }
    private void OnOff(bool _flag)
    {
        Dialogue.gameObject.SetActive(_flag);
        txt_Dialogue.gameObject.SetActive(_flag);
        isDialogue = _flag;
    }
   
    
    
    public void HideDialogue()
    {
        Dialogue.gameObject.SetActive(false);
        txt_Dialogue.gameObject.SetActive(false);
        isDialogue=false;
    }


    private void NextDialogue()
    {
        txt_Dialogue.text = dialogue[count].dialogue;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if(Input.GetKeyDown(KeyCode.Space) ) 
            {
                if(count < dialogue.Length) 
                { 
                    NextDialogue();
                }
                else
                {
                    OnOff(false);
                }
            }
        }
    }
}
