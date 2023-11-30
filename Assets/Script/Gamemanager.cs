using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEditor;

public class Gamemanager : MonoBehaviour
{
    public float stamina = 100f;
    private float maxStamina=100f;
    public Text staminaText;
    bool isRun;
    
    // Start is called before the first frame update
    void Start()
    {

        maxStamina = stamina;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)&&stamina >0)
        {
            stamina = stamina - 2;
            UpdateST();
        }
        else if(stamina <maxStamina)
        {
            isRun = false;
            stamina += .5f;
            UpdateST();
        }
    }
    private void UpdateST()
    {
        staminaText.text = ((int)(stamina / maxStamina * 100f)).ToString() + "%";
    }
    void canRun()
    {
        if (isRun == false)
        {
            PlayerMove speed = GetComponent<PlayerMove>();
            //speed = 5;
            if (stamina == maxStamina)
            {
                isRun = true;
            }
        }
    }
}
