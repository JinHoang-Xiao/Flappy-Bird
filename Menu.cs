using UnityEngine;

public class UserInterfaceHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject _bird;
    [SerializeField]
    private Vector3 _birdStartPosition = Vector3.zero;
    [SerializeField]
    private GameObject _menuUI;

    public void OnStartPressed()
    {
        _bird.SetActive(true);
        _bird.transform.position = _birdStartPosition;
        _menuUI.SetActive(false);
    } 
}
