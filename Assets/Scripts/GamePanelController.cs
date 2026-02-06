using UnityEngine;

public class GamePanelController : MonoBehaviour
{
    // 뒤로가기 버튼
    public void OnClickBackButton()
    {
        GameManager.Instance.ChangeToMainScene();
    }

    // 설정팝업
    public void OnClickSettingsButton()
    {
        GameManager.Instance.OpenSettingsPanel();
    }
    
}
