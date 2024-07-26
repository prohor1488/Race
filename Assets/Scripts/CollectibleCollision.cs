using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectibleCollision : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    [SerializeField]
    private Text scoreText;

    private int _money;


    private void OnTriggerEnter(Collider other)
    {
        var tag = other.gameObject.tag;
        if (tag == "Money")
        {
            _money++;
            scoreText.text = _money.ToString();
            Destroy(other.gameObject);
            audioSource.PlayOneShot(clip);
        }
    }
}
