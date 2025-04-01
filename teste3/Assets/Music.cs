// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Music : MonoBehaviour
// {
//     [SerializeField] Slider volumeSlider;

//     void start()
//     {
//         if(!Playerprefs.HasKey("Music"))
//         {
//             Playerprefs.SetFloat("Music", 1);
//             Load();
//         }

//         else
//         {
//             Load();
//         }
//     }

//     public void ChangeVolume()
//     {
//         AudioListener.volume = volume.value;
//         Save();
//     }

//     private void Load()
//     {
//         volumeSlider.value = playerPrefs.GetFloat("Music");
//     }

//     private void Save()
//     {
//         Playerprefs.SetFloat("Music", volumeSlider.value);
//     }
// }
