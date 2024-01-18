using UnityEngine;

public class OnClickBtnStart : MonoBehaviour
{
    [SerializeField] private GameObject panelGameMenu;

    private Spawner spawner;
    private Difficulty difficulty;

    private void Awake()
    {
        difficulty = FindObjectOfType<Difficulty>();    
        spawner = FindObjectOfType<Spawner>();
    }

    public void OnClick()
    {
        spawner.spawnFrequency = difficulty.difficulty;
        spawner.spawnFrequencWaves = difficulty.difficulty;
        spawner.StartSpawn();
        panelGameMenu.SetActive(false);
    }
}
