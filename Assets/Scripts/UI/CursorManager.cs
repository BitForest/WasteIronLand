using UnityEngine;
using System.Collections;

public class CursorManager : MonoBehaviour
{
    private static MouseLook _mouseLookCam,_mouseLookPlayer;
    private static FPSInputController _fpsInput;
	// Use this for initialization
	void Start () {
        var goPlayer = GameObject.FindGameObjectWithTag("Player");
        _mouseLookCam = Camera.main.GetComponent<MouseLook>();
        _mouseLookPlayer = goPlayer.GetComponent<MouseLook>();
        _fpsInput = goPlayer.GetComponent<FPSInputController>();
        Hide();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Show();
        }
	}

    public static void Hide()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _mouseLookCam.enabled = true;
        _mouseLookPlayer.enabled = true;
        _fpsInput.enabled = true;
    }

    public static void Show()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        _mouseLookCam.enabled = false;
        _mouseLookPlayer.enabled = false;
        _fpsInput.enabled = false;
    }
}