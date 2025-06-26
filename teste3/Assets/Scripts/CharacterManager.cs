using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class CharacterManager : MonoBehaviour
{
    public CharacterDataBase characterDb;

    public TextMeshProUGUI nameText;
    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;

        }
        else
        {
            Load();
        }
        UpdateCharacter(selectedOption);
    }

    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDb.CharacterCount)
        {
            selectedOption = 0;

        }
        UpdateCharacter(selectedOption);
        Save();
    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0)
        {
            selectedOption = characterDb.CharacterCount - 1;
        }
        UpdateCharacter(selectedOption);
        Save();
    }


    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDb.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
        nameText.text = character.characterName;
    }

    public void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selecttedOption");
    }

    private void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }


    public void ChangeScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
