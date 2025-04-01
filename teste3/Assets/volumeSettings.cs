using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumeSettings : MonoBehaviour
{
    // Referência ao AudioMixer do Unity, que será configurado no Inspector.
    // O AudioMixer precisa ter um parâmetro exposto chamado "music" para funcionar corretamente.
    [SerializeField] private AudioMixer myMixer;

    // Referência ao Slider que controla o volume da música.
    // Deve ser configurado no Inspector arrastando o Slider correspondente.
    [SerializeField] private Slider musicSlider;

    /// <summary>
    /// Método chamado automaticamente quando o jogo é iniciado.
    /// Inicializa o volume chamando o método SetMusicVolume().
    /// </summary>
    private void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolume();

        }
        else
        {
            SetMusicVolume();
        }

        SetMusicVolume(); // Define o volume inicial da música de acordo com o valor atual do Slider.
    }
    
    /// <summary>
    /// Ajusta o volume da música no AudioMixer com base no valor do Slider.
    /// O volume é convertido para decibéis, que é o formato aceito pelo AudioMixer.
    /// </summary>
    public void SetMusicVolume()
    {
        // Pega o valor do Slider (geralmente variando de 0 a 1).
        float volume = musicSlider.value;

        // Converte o valor do Slider para decibéis usando uma fórmula logarítmica.
        // Multiplicar por 20 é necessário porque o AudioMixer utiliza uma escala logarítmica em decibéis.
        myMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("musicVolume", volume);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
         
         SetMusicVolume();
    }
}
