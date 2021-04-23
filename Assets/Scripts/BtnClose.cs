using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnClose : BtnBase
{
    public override void OnClicks()
    {
        Window.Instance.gameObject.SetActive(false);
    }
}