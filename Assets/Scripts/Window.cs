using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : Singleton<Window>
{
    [SerializeField] private Transform      portraitsHolder;
    [SerializeField] private tk2dSprite[]   circles;
    [SerializeField] private tk2dUIItem[]   arrowButtons;

    private const int           idEmptyCirlceSprite     = 5;
    private const int           idFillCircleSprite      = 6;
    private const int           additiveXposition       = 15;

    private WindowState         state                   = WindowState.third;
    private List<WindowState>   windowStatesValues      = new List<WindowState>();

    private void Start()
    {
        windowStatesValues = EnumUtils.GetValues<WindowState>();
        FillCircle();
    }

    private void FillCircle()
    {
        for (int i = 0; i < circles.Length; i++)
        {
            if (windowStatesValues[i] == state)
            {
                circles[i].SetSprite(idFillCircleSprite);
                break;
            }
        }
    }

    public void MoveWindowRight()
    {
        if (state != windowStatesValues[windowStatesValues.Count - 1])
        {
            circles[(int)state].SetSprite(idEmptyCirlceSprite);
            state++;
            circles[(int)state].SetSprite(idFillCircleSprite);
            StartCoroutine(LerpMoved(-additiveXposition));
        }
    }
    public void MoveWindowLeft()
    {
        if (state != windowStatesValues[0])
        {
            circles[(int)state].SetSprite(idEmptyCirlceSprite);
            state--;
            circles[(int)state].SetSprite(idFillCircleSprite);
            StartCoroutine(LerpMoved(additiveXposition));
        }
    }


    private IEnumerator LerpMoved(int newPosition)
    {
        ArrowBtnEnable(false);
        int startPosition = (int)portraitsHolder.position.x;
        int finishPosititon = startPosition + newPosition;

        float timeStart = 0.0f;
        float timeFinish = 1f;

        while (timeStart < timeFinish)
        {
            timeStart += Time.deltaTime;
            portraitsHolder.position = new Vector3(Mathf.Lerp(startPosition, finishPosititon, timeStart), portraitsHolder.position.y, portraitsHolder.position.z);
            yield return null;
        }
        yield return null;
        ArrowBtnEnable(true);
    }

    private void ArrowBtnEnable(bool active)
    {
        for (int i = 0; i < arrowButtons.Length; i++)
            arrowButtons[i].enabled = active;
    }
}


public enum WindowState
{
    first       = 0,
    second      = 1,
    third       = 2,
    fourth      = 3
}