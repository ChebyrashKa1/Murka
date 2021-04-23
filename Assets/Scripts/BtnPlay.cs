using UnityEngine;

public class BtnPlay : BtnBase
{
    public override void OnClicks()
    {
        tk2DButton.enabled = false;
        tk2DSprite.SetSprite(4);
        tk2DSprite.SetAlpha(0.75f);
        txtBtn.SetAlpha(0.75f);
    }
}