using UnityEngine;
public class ExitApplication : MonoBehaviour
{
    void Update()
    {
        // Close the application when the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}