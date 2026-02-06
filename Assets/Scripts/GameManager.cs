using UnityEngine;
using UnityEngine.SceneManagement;
using static Constants;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private GameObject settingPanelPrefab;
    private Canvas _canvas;
    
    // 게임의 종류(싱글, 듀얼)
    private GameType _gameType;
    
    protected override void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        _canvas = FindFirstObjectByType<Canvas>();
    }
    
    //Setting 패널 열기
    public void OpenSettingsPanel()
    {
        var settingsPanelObject = Instantiate(settingPanelPrefab, _canvas.transform);
        settingsPanelObject.GetComponent<SettingsPanelController>().Show();
        
    }

    public void ChangeToGameScene(GameType gameType)
    {
        _gameType = gameType;
        SceneManager.LoadScene("Game");
    }
    
    public void ChangeToMainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
