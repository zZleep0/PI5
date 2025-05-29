using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    public bool silenciar;

    public AudioSource musica;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        int cena = SceneManager.GetActiveScene().buildIndex;
        if (cena == 1)
        {
            Toggle volume = GameObject.Find("TogAudio").GetComponent<Toggle>();
            silenciar = volume.isOn;
        }
        if (cena != 0)
        {
            musica = GameObject.Find("#_MusicManager").GetComponent<AudioSource>();
            musica.mute = silenciar;
        }
    }
}
