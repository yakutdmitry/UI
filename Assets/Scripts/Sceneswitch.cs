using UnityEngine;
using UnityEngine.SceneManagement;
using Scene = Unity.VectorGraphics.Scene;

public class Sceneswitch : MonoBehaviour
{
    public string Scene;

    public void LoadScene()
    {
        SceneManager.LoadScene(Scene);
    }
}
