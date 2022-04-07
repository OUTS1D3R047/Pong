using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is responsible for
/// the switching back to the main menu
/// </summary>
public class ReturnBack : MonoBehaviour
{
    GameObject[] otherMenu;
    GameObject mmui;
    bool isActive = true;

    public void ReturnToMenu()
    {
        mmui = GameObject.Find("DisabledMMUI");
        otherMenu = GameObject.FindGameObjectsWithTag("OtherMenu");
        
        ShowHide(mmui, isActive);
        
        foreach (var OMObject in otherMenu)
        {
            ShowHide(OMObject, !isActive);
        }
    }

    void ShowHide(GameObject obj, bool isActive) // Show/hide child objects
    {
        Transform[] objChild = obj.GetComponentsInChildren<Transform>(true);
        foreach (var child in objChild)
        {
            child.gameObject.SetActive(isActive);
        }
    }
}
