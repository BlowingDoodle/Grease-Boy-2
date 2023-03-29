using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void Nivel2()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1;
    }
    public void Nivel3()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1;
    }
    public void Nivel1()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void Reiniciar1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
 