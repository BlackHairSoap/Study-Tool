using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiscButtons : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenDirectory()
    {
        System.Diagnostics.Process.Start(Application.persistentDataPath);
    }
}
