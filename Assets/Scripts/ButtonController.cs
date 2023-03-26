using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public string EscenaNombre;

    public void nextScene(string EscenaNombre)
    {
        SceneManager.LoadScene(EscenaNombre);
    }

}
