using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadBattleScene()
    {
        SceneManager.LoadScene("BattleScene"); // �̸����� �� ��ȯ
    }

    public void LoadTilemapScene()
    {
        SceneManager.LoadScene("Tilemap"); // �̸����� �� ��ȯ
    }

    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex); // �ε����� �� ��ȯ
    }
}
