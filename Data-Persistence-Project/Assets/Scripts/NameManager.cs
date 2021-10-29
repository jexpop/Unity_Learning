using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.IO;

public class NameManager : MonoBehaviour
{
    public static NameManager Instance;

    public TMP_InputField nameInput;

    public string namePlayer;
    public int best_m_Points;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

        Load();

    }

    public void StartGame()
    {
        namePlayer = nameInput.text;
        SceneManager.LoadScene(1);
    }

    [System.Serializable]
    class SaveData
    {
        public string TeamName;
        public int TeamScore;
    }

    public void Save()
    {
        SaveData data = new SaveData();
        data.TeamName = namePlayer;
        data.TeamScore = best_m_Points;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            nameInput.text = data.TeamName;
            best_m_Points = data.TeamScore;
        }
    }

}
