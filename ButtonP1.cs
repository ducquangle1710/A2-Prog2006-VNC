using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonP1 : MonoBehaviour
{
    public void SceneLoader(int sceneNumber)
{
    SceneManager.LoadScene(sceneNumber);
}
}
