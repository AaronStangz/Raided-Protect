using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hub : MonoBehaviour
{
    public GameObject mainManager;
    MainManager MM;

    public int openRange;
    public bool HubOpen;
    public bool BuildModeOpen;

    public GameObject HubGUI;
    public GameObject HubBuildModeGUI;
    public GameObject HubBuildMode;

    public GameObject Player;
    public GameObject PlayerCam;
    public GameObject BuildModeCam;

    void Start()
    {
        MM = mainManager.GetComponent<MainManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && HubOpen)
        {
            HubOpen = false;
            HubGUI.SetActive(false);
            HubBuildModeGUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Player.GetComponent<PlayerMovement>().enabled = true;
            PlayerCam.GetComponent<PlayerCam>().enabled = true;
        }

        if (Input.GetKey(KeyCode.Escape) && BuildModeOpen)
        {
            BuildModeOpen = false;
            HubGUI.SetActive(true);
            PlayerCam.SetActive(true);
            HubBuildModeGUI.SetActive(false);
            BuildModeCam.SetActive(false);
            HubBuildMode.SetActive(false);
        }
    }

    public void Open()
    {
        HubOpen = true;
        HubGUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Player.GetComponent<PlayerMovement>().enabled = false;
        PlayerCam.GetComponent<PlayerCam>().enabled = false;
    }

    public void UpgradeHub()
    {
        
    }

    public void UpgradeingMode()
    {
        BuildModeOpen = true;
        HubGUI.SetActive(false);
        PlayerCam.SetActive(false);
        HubBuildModeGUI.SetActive(true);
        BuildModeCam.SetActive(true);
        HubBuildMode.SetActive(true);
    }

    public GameObject[] Pages;
    public GameObject[] Backdrops;

    public void TogglePages(int indexToEnable)
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].SetActive(indexToEnable == i);
        }
    }

}
