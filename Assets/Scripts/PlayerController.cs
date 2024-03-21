using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject firstOption;
    private GameObject secondOption;
    private GameObject thirdOption;
    private GameObject fourthOption;
    private GameObject fifthOption;
    void Start()
    {
        firstOption = GameObject.Find("QuadOption1");
        secondOption = GameObject.Find("QuadOption2");
        thirdOption = GameObject.Find("QuadOption3");
        fourthOption = GameObject.Find("QuadOption4");
        fifthOption = GameObject.Find("QuadOption5");
    }

    void Update()
    {
        Debug.Log("Update");
        KeyCode key = GetPressedKey();

        switch (key)
        {
            case KeyCode.Alpha1:
                Debug.Log("entre al 1");
                HighlightQuad(firstOption);
                break;
            case KeyCode.Alpha2:
                Debug.Log("entre al 2");
                HighlightQuad(secondOption);
                break;
            case KeyCode.Alpha3:
                Debug.Log("entre al 3");
                HighlightQuad(thirdOption);
                break;
            case KeyCode.Alpha4:
                Debug.Log("entre al 4");
                HighlightQuad(fourthOption);
                break;
            case KeyCode.Alpha5:
                Debug.Log("entre al 5");
                HighlightQuad(fifthOption);
                break;
            default:
                break;
        }
    }
    void HighlightQuad(GameObject quadToHighlight)
    {
        if (quadToHighlight != null)
        {
            Debug.Log("Highlighting quad no es null");
            GameObject outlineQuad = GameObject.CreatePrimitive(PrimitiveType.Quad);
            outlineQuad.transform.position = quadToHighlight.transform.position - new Vector3(0, 0, 0.01f);
            outlineQuad.transform.localScale = quadToHighlight.transform.localScale * 1.1f;
            outlineQuad.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            Debug.LogError("Quad is null");
        }
    }
    KeyCode GetPressedKey()
    {
        foreach (KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(kcode))
            {
                return kcode;
            }
        }
        return KeyCode.None;
    }
}
