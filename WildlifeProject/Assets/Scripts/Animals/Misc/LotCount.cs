using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LotCount : MonoBehaviour
{
    public TMP_Text LotsCount;
    public int lotsCount = 1; // CHANGE FROM INSPECTOR
    public int restrictLimit = 0;

    public GameObject RestrictButton;

    private void Update()
    {
        LotsCount.text = lotsCount + "/15";

        if (GameObject.Find("Worm").GetComponent<WormInteraction>().wormLevel.text == "Level 7" && GameObject.Find("Frog").GetComponent<FrogInteraction>().frogLevel.text == "Level 5" 
            && GameObject.Find("Goose").GetComponent<GooseInteraction>().gooseLevel.text == "Level 2" && GameObject.Find("Wolf").GetComponent<WolfInteraction>().wolfLevel.text == "Level 3" 
            && GameObject.Find("Sparrow").GetComponent<SparrowInteraction>().sparrowLevel.text == "Level 4" && GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().buzzardLevel.text == "Level 3"
            && GameObject.Find("Beaver").GetComponent<BeaverInteraction>().beaverLevel.text == "Level 3" && GameObject.Find("Fly").GetComponent<FlyInteraction>().flyLevel.text == "Level 3"
            && GameObject.Find("Bee").GetComponent<BeeInteraction>().beeLevel.text == "Level 3" && restrictLimit == 0)
        {
            GameObject.Find("Worm").GetComponent<WormInteraction>().npcName = false;
            GameObject.Find("Worm").GetComponent<WormInteraction>().wormText.SetActive(false);

            GameObject.Find("Frog").GetComponent<FrogInteraction>().npcName = false;
            GameObject.Find("Frog").GetComponent<FrogInteraction>().frogText.SetActive(false);

            GameObject.Find("Goose").GetComponent<GooseInteraction>().npcName = false;
            GameObject.Find("Goose").GetComponent<GooseInteraction>().gooseText.SetActive(false);

            GameObject.Find("Wolf").GetComponent<WolfInteraction>().npcName = false;
            GameObject.Find("Wolf").GetComponent<WolfInteraction>().wolfText.SetActive(false);

            GameObject.Find("Sparrow").GetComponent<SparrowInteraction>().npcName = false;
            GameObject.Find("Sparrow").GetComponent<SparrowInteraction>().sparrowText.SetActive(false);

            GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().npcName = false;
            GameObject.Find("Buzzard").GetComponent<BuzzardInteraction>().buzzardText.SetActive(false);

            GameObject.Find("Beaver").GetComponent<BeaverInteraction>().npcName = false;
            GameObject.Find("Beaver").GetComponent<BeaverInteraction>().beaverText.SetActive(false);

            GameObject.Find("Fly").GetComponent<FlyInteraction>().npcName = false;
            GameObject.Find("Fly").GetComponent<FlyInteraction>().flyText.SetActive(false);

            GameObject.Find("Bee").GetComponent<BeeInteraction>().npcName = false;
            GameObject.Find("Bee").GetComponent<BeeInteraction>().beeText.SetActive(false);

            RestrictButton.SetActive(true);
        }
    }
}
