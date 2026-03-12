using UnityEngine;
using UnityEngine.SceneManagement;


public class Door : Interactable
{
    public string levelName;
    public override void Interaction()
    {
        SceneManager.LoadScene(levelName);
    }
}
