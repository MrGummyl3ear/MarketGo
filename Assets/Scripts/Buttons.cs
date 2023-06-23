using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class Buttons : MonoBehaviour {
    public GameObject gameObject;
    public GameObject gameObjects;
    public GameObject gameObjecta;

        public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
public void QuitGame()
    {
        Application.Quit();
    }
    public void GettingData()
    {
        PlayerPrefs.SetFloat("x1", gameObject.transform.localPosition.x);
        PlayerPrefs.SetFloat("y1", gameObject.transform.localPosition.y);
        PlayerPrefs.SetFloat("z1", gameObject.transform.localPosition.z);
        PlayerPrefs.SetFloat("x2", gameObjects.transform.localPosition.x);
        PlayerPrefs.SetFloat("y2", gameObjects.transform.localPosition.y);
        PlayerPrefs.SetFloat("z2", gameObjects.transform.localPosition.z);
        PlayerPrefs.SetFloat("x3", gameObjecta.transform.localPosition.x);
        PlayerPrefs.SetFloat("y3", gameObjecta.transform.localPosition.y);
        PlayerPrefs.SetFloat("z3", gameObjecta.transform.localPosition.z);
    }
    public void Reset()
    {
        gameObject.transform.localPosition = new Vector3(200f, 10f, 46f);
        gameObjects.transform.localPosition = new Vector3(15f, -150f, 46f);
        gameObjecta.transform.localPosition = new Vector3(-200f, 10f, 46f);
    }
}
