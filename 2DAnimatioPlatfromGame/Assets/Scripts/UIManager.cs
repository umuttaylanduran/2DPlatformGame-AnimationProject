using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MainMenu, OptionsMenu;

    void Start()
    {
        MainMenu.DOAnchorPos(Vector2.zero, 1f);
    }

   
  public void OptionsButton()
    {
        MainMenu.DOAnchorPos(new Vector2(-1350, 0), 1f);
        OptionsMenu.DOAnchorPos(new Vector2(0, 0), 1f);
    }
    public void BackButoon()
    {
        MainMenu.DOAnchorPos(new Vector2(0, 0), 1f);
        OptionsMenu.DOAnchorPos(new Vector2(1350, 0), 1f);
    }
}
