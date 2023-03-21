using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    public void EscenaP2()
    {
        SceneManager.LoadScene("Practica2");
       
    }

    public void EscenaP3Cilindro()
    {
        SceneManager.LoadScene("Practica3-Cilindro");
    }

    public void EscenaP3Esfera()
    {
        SceneManager.LoadScene("Practica3-Esfera");
    }

    public void EscenaP3Skybox()
    {
        SceneManager.LoadScene("Practica3-Skybox");
    }

}
