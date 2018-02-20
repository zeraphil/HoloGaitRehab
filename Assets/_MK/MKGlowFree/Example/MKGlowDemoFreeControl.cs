using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MK.Glow;

public class MKGlowDemoFreeControl : MonoBehaviour
{
    private bool showMenu = false;
    [SerializeField]
    private MKGlowFree mkGlow;
    [SerializeField]
    private UnityStandardAssets.Characters.FirstPerson.FirstPersonController controller;
    [SerializeField]
    private GameObject ui;

    [SerializeField]
    private GameObject uiStartText;

    public float GlowIntensity
    {
        set
        {
            mkGlow.GlowIntensity = value;
        }
    }
    public float BlurSpread
    {
        set
        {
            mkGlow.BlurSpread = value;
        }
    }
    public float BlurIterations
    {
        set
        {
            mkGlow.BlurIterations = (int)value;
        }
    }

    private void Start ()
    {
        ui.SetActive(false);
    }
	
	private void Update ()
    {
		if(Input.GetKeyDown(KeyCode.M))
        {
            showMenu = !showMenu;

            if(showMenu)
            {
                controller.enabled = false;
                ui.SetActive(true);
                if (uiStartText)
                    Destroy(uiStartText);
            }
            else
            {
                controller.enabled = true;
                ui.SetActive(false);
            }
        }
	}
}
