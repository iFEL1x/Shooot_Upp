using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    [SerializeField] private int _targetScreenWidth = 720;
    [SerializeField] private int _targetScreenHeight = 1280;

    private void Start() =>
        SetResolution(_targetScreenWidth, _targetScreenHeight);

    private void SetResolution(int width, int height) =>
        Screen.SetResolution(width, height, false);
}
