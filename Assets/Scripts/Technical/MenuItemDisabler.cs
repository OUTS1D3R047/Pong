using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuItemDisabler : MonoBehaviour
{

    public void Awake()
    {
        this.gameObject.SetActive(false);
    }
}
