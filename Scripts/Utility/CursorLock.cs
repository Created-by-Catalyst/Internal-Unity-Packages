using UnityEngine;

public class CursorLock : MonoBehaviour
{
    [SerializeField] bool lockOnStart = true;
    private void Start()
    {
        if (lockOnStart)
        {
            LockCursor();
        }
        else
        {
            UnlockCursor();
        }
    }

    public void LockCursor()
    {
        // Lock the cursor in the center of the screen
        Cursor.lockState = CursorLockMode.Locked;

        // Hide the cursor
        Cursor.visible = false;
    }

    public void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ToggleCursorLock()
    {
        if (Cursor.visible)
        {
            LockCursor();
        }
        else
        {
            UnlockCursor();
        }
    }
}
