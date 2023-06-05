using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SettingsMenu : MonoBehaviour
{
    [Header("space between menu items")]
    [SerializeField] Vector2 spacing;

    [Space]
    [Header("Main button rotation")]
    [SerializeField] float rotationDuration;
    [SerializeField] Ease rotationEase;

    [Space]
    [Header("Animation")]
    [SerializeField] float expandDuration;
    [SerializeField] float collapseDuration;
    [SerializeField] Ease expandEase;
    [SerializeField] Ease collapseEase;

    [Space]
    [Header("Fade")]
    [SerializeField] float expandFadeDuration;
    [SerializeField] float collapseFadeDuration;

    Button Main_Button;
    SettingsMenuItem[] menuItems;
    bool isExpanded = false;

    Vector2 Main_ButtonPosition;
    int itemsCount;
    public float rotation = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Main_Button);
        Debug.Log(menuItems);
        Debug.Log(Main_ButtonPosition);
        itemsCount = transform.childCount - 1;
        menuItems = new SettingsMenuItem[itemsCount];
        for (int i = 0; i < itemsCount; i++)
        {
            menuItems[i] = transform.GetChild(i + 1).GetComponent<SettingsMenuItem>();
        }
        Main_Button = transform.GetChild(0).GetComponent<Button>();
        Main_Button.onClick.AddListener(ToggleMenu);
        Main_Button.transform.SetAsLastSibling();

        Main_ButtonPosition = Main_Button.transform.position;

        //Reset all menu items position to Main_ButtonPosition
        ResetPositions ();
    }

    void ResetPositions ()
    {
        for (int i = 0; i < itemsCount; i++)
        {
            menuItems[i].trans.position = Main_ButtonPosition;
        }
    }

    void ToggleMenu ()
    {
        isExpanded = !isExpanded;

        if (isExpanded)
        {
            //menu opened
            for (int i = 0; i < itemsCount; i++)
            {
                //menuItems[i].trans.position = Main_ButtonPosition + spacing * (i + 1);
                menuItems[i].trans.DOMove(Main_ButtonPosition + spacing * (i + 1), expandDuration).SetEase(expandEase);
                menuItems[i].img.DOFade(1f, expandFadeDuration).From(0f);
            }
        }
        else
        {
            //menu closed
            for (int i = 0; i < itemsCount; i++)
            {
                //menuItems[i].trans.position = Main_ButtonPosition;
                menuItems[i].trans.DOMove(Main_ButtonPosition, collapseDuration).SetEase(collapseEase);
                menuItems[i].img.DOFade(0f, collapseFadeDuration);
            }
        }

        //rotate main button
        rotation += 90f;
        Main_Button.transform
            .DORotate(Vector3.forward * rotation, rotationDuration)
            //.From(Vector3.zero)
            .SetEase(rotationEase);
    }

    public void OnItemClick (int index)
    {
        switch (index)
        {
            case 0: //first button
                Debug.Log("Options");
                break;
            case 1: //second button
                Debug.Log("Mail");
                break;
            case 2: //third button
                Debug.Log("Book");
                break;
        }
    }

    private void OnDestroy()
    {
        Main_Button.onClick.RemoveListener(ToggleMenu);
    }
}
