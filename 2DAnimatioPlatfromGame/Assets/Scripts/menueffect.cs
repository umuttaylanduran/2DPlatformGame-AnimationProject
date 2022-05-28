using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class menueffect : MonoBehaviour
{
    public RectTransform startbuttonm;

     public void MoveMenu() 
    {

        startbuttonm.DOAnchorPos(new Vector2(751, 0), 0.5f);
    
    }
    public void start()
    {
        startbuttonm.DOAnchorPos(new Vector2(-1150, -600), 2.5f).SetEase(Ease.InBack);
    }
}
