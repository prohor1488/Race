using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CollisionObserver : MonoBehaviour
{
    [SerializeField]
    private Text winText;
    private void OnCollisionEnter(Collision other)
    {
        var tag = other.gameObject.tag;
        if (tag == "Player")
        {
            winText.text = "Победа";
            Invoke(nameof(ExitMenu),1f);
        }
        else if (tag == "Enemmy")
        {
            winText.text = "Поражение";
            Invoke(nameof(ExitMenu), 1f);
        }
    }


    private void ExitMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

