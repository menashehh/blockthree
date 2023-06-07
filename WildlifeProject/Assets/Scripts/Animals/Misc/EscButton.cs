using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscButton : MonoBehaviour
{
    WormInteraction wormInteractionScript;
    WormHex wormHexScript;
    WormHex2 wormHex2Script;
    WormHex3 wormHex3Script;
    WormHex4 wormHex4Script;

    FrogInteraction frogInteractionScript;
    FrogHex frogHexScript;
    FrogHex2 frogHex2Script;
    FrogHex3 frogHex3Script;

    GooseInteraction gooseInteractionScript;
    GooseHex gooseHexScript;

    WolfInteraction wolfInteractionScript;
    WolfHex wolfHexScript;
    WolfHex2 wolfHex2Script;

    SparrowInteraction sparrowInteractionScript;
    SparrowHex sparrowHexScript;
    SparrowHex2 sparrowHex2Script;

    BuzzardInteraction buzzardInteractionScript;
    BuzzardHex buzzardHexScript;
    BuzzardHex2 buzzardHex2Script;

    BeaverInteraction beaverInteractionScript;
    BeaverHex beaverHexScript;

    FlyInteraction flyInteractionScript;
    FlyHex flyHexScript;
    FlyHex2 flyHex2Script;

    BeeInteraction beeInteractionScript;
    BeeHex beeHexScript;

    public GameObject worm;
    public GameObject wormBuildHex;
    public GameObject wormBuildHex2;
    public GameObject wormBuildHex3;
    public GameObject wormBuildHex4;

    public GameObject frog;
    public GameObject frogBuildHex;
    public GameObject frogBuildHex2;
    public GameObject frogBuildHex3;

    public GameObject goose;
    public GameObject gooseBuildHex;

    public GameObject wolf;
    public GameObject wolfBuildHex;
    public GameObject wolfBuildHex2;

    public GameObject sparrow;
    public GameObject sparrowBuildHex;
    public GameObject sparrowBuildHex2;

    public GameObject buzzard;
    public GameObject buzzardBuildHex;
    public GameObject buzzardBuildHex2;

    public GameObject beaver;
    public GameObject beaverBuildHex;

    public GameObject fly;
    public GameObject flyBuildHex;
    public GameObject flyBuildHex2;

    public GameObject bee;
    public GameObject beeBuildHex;

    private void Start()
    {
        wormInteractionScript = worm.GetComponent<WormInteraction>();
        wormHexScript = wormBuildHex.GetComponent<WormHex>();
        wormHex2Script = wormBuildHex2.GetComponent<WormHex2>();
        wormHex3Script = wormBuildHex3.GetComponent<WormHex3>();
        wormHex4Script = wormBuildHex4.GetComponent<WormHex4>();

        frogInteractionScript = frog.GetComponent<FrogInteraction>();
        frogHexScript = frogBuildHex.GetComponent<FrogHex>();
        frogHex2Script = frogBuildHex2.GetComponent<FrogHex2>();
        frogHex3Script = frogBuildHex3.GetComponent<FrogHex3>();

        gooseInteractionScript = goose.GetComponent<GooseInteraction>();
        gooseHexScript = gooseBuildHex.GetComponent<GooseHex>();

        wolfInteractionScript = wolf.GetComponent<WolfInteraction>();
        wolfHexScript = wolfBuildHex.GetComponent<WolfHex>();
        wolfHex2Script = wolfBuildHex2.GetComponent<WolfHex2>();

        sparrowInteractionScript = sparrow.GetComponent<SparrowInteraction>();
        sparrowHexScript = sparrowBuildHex.GetComponent<SparrowHex>();
        sparrowHex2Script = sparrowBuildHex2.GetComponent<SparrowHex2>();

        buzzardInteractionScript = buzzard.GetComponent<BuzzardInteraction>();
        buzzardHexScript = buzzardBuildHex.GetComponent<BuzzardHex>();
        buzzardHex2Script = buzzardBuildHex2.GetComponent<BuzzardHex2>();

        beaverInteractionScript = beaver.GetComponent<BeaverInteraction>();
        beaverHexScript = beaverBuildHex.GetComponent<BeaverHex>();

        flyInteractionScript = fly.GetComponent<FlyInteraction>();
        flyHexScript = flyBuildHex.GetComponent<FlyHex>();
        flyHex2Script = flyBuildHex2.GetComponent<FlyHex2>();

        beeInteractionScript = bee.GetComponent<BeeInteraction>();
        beeHexScript = beeBuildHex.GetComponent<BeeHex>();
    }

    public void Escape()
    {
        if (GameObject.Find("Build Button Worm"))
        {
            wormInteractionScript.npcName = false;
            wormInteractionScript.menuOpen = 0;
            wormInteractionScript.wormText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Worm"))
        {
            wormHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Worm 2"))
        {
            wormHex2Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Worm 3"))
        {
            wormHex3Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Worm 4"))
        {
            wormHex4Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Build Button Frog"))
        {
            frogInteractionScript.npcName = false;
            frogInteractionScript.menuOpen = 0;
            frogInteractionScript.frogText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Frog"))
        {
            frogHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Frog 2"))
        {
            frogHex2Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Frog 3"))
        {
            frogHex3Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Build Button Goose"))
        {
            gooseInteractionScript.npcName = false;
            gooseInteractionScript.menuOpen = 0;
            gooseInteractionScript.gooseText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Goose"))
        {
            gooseHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Build Button Wolf"))
        {
            wolfInteractionScript.npcName = false;
            wolfInteractionScript.menuOpen = 0;
            wolfInteractionScript.wolfText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Wolf"))
        {
            wolfHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Wolf 2"))
        {
            wolfHex2Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Build Button Sparrow"))
        {
            sparrowInteractionScript.npcName = false;
            sparrowInteractionScript.menuOpen = 0;
            sparrowInteractionScript.sparrowText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Sparrow"))
        {
            sparrowHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Sparrow 2"))
        {
            sparrowHex2Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Build Button Buzzard"))
        {
            buzzardInteractionScript.npcName = false;
            buzzardInteractionScript.menuOpen = 0;
            buzzardInteractionScript.buzzardText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Buzzard"))
        {
            buzzardHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Buzzard 2"))
        {
            buzzardHex2Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Build Button Beaver"))
        {
            beaverInteractionScript.npcName = false;
            beaverInteractionScript.menuOpen = 0;
            beaverInteractionScript.beaverText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Beaver"))
        {
            beaverHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Build Button Fly"))
        {
            flyInteractionScript.npcName = false;
            flyInteractionScript.menuOpen = 0;
            flyInteractionScript.flyText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Fly"))
        {
            flyHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Hex Button Fly 2"))
        {
            flyHex2Script.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Build Button Bee"))
        {
            beeInteractionScript.npcName = false;
            beeInteractionScript.menuOpen = 0;
            beeInteractionScript.beeText.SetActive(false);

            return;
        }

        if (GameObject.Find("Hex Button Bee"))
        {
            beeHexScript.menuOpen = 0;

            return;
        }

        if (GameObject.Find("Restrict Button"))
        {
            GameObject.Find("Restrict Button").SetActive(false);

            GameObject.Find("LotCenter1").GetComponent<LotCount>().restrictLimit = 1;

            return;
        }
    }
}
