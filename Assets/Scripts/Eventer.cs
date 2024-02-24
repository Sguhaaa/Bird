using UnityEngine;
using UnityEngine.Events;

public class Eventer : MonoBehaviour
{
    public UnityEvent onMouseClicked;

    private void Update() {
        if (!Input.GetMouseButtonDown(0) && !Input.GetKeyDown(KeyCode.Space)) return;

        GameManager.instance.AudioManager.PlayJump(true);
        onMouseClicked?.Invoke();
    }
}
