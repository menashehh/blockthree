using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [Header("space between menu items")]
    [SerializeField] Vector2 spacing;

    [SerializeField] Button Main_Button;
    SettingsMenuItem[] menuItems;
    bool isExpanded = false;

    Vector2 Main_ButtonPosition;
    int itemsCount;

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
                menuItems[i].trans.position = Main_ButtonPosition + spacing * (i + 1);
            }
        }
        else
        {
            //menu closed
            for (int i = 0; i < itemsCount; i++)
            {
                menuItems[i].trans.position = Main_ButtonPosition;
            }
        }
    }

    private void OnDestroy()
    {
        Main_Button.onClick.RemoveListener(ToggleMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
