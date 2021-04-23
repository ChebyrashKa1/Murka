using UnityEngine;

public abstract class BtnBase : MonoBehaviour
{
    [SerializeField] protected tk2dButton       tk2DButton;
    [SerializeField] protected tk2dSprite       tk2DSprite;
    [SerializeField] protected TMPro.TMP_Text   txtBtn;

    public abstract void OnClicks();
}
