using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _restart;
    [SerializeField] private Button _exit;
    [SerializeField] private Player _player;

    private CanvasGroup _canvasGroup;

    private void OnEnable()
    {
        _player.Died += OnDied;
        _restart.onClick.AddListener(OnRestartButtonClick);
        _exit.onClick.AddListener(OnExitButtonClick);

    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _restart.onClick.RemoveListener(OnRestartButtonClick);
        _exit.onClick.RemoveListener(OnExitButtonClick);

    }
    private void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _canvasGroup.alpha = 0;

    }

    private void OnDied()
    {
        _canvasGroup.alpha = 1;
        Time.timeScale = 0;

    }

    private void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    private void OnExitButtonClick()
    {
       Application.Quit();
    }
}
