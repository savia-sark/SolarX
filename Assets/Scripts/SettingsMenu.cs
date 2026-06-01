using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsPanel;

    public GameObject mercury;
    public GameObject venus;
    public GameObject earth;
    public GameObject mars;
    public GameObject jupiter;
    public GameObject saturn;
    public GameObject uranus;
    public GameObject neptune;

    private bool isOpen = false;
    private Renderer[][] rens;
    void Start()
    {
        rens= new Renderer[8][];
        rens[0]= mercury.GetComponentsInChildren<Renderer>(true);
        rens[1] = venus.GetComponentsInChildren<Renderer>(true);
        rens[2] = earth.GetComponentsInChildren<Renderer>(true);
        rens[3] = mars.GetComponentsInChildren<Renderer>(true);
        rens[4] = jupiter.GetComponentsInChildren<Renderer>(true);
        rens[5] = saturn.GetComponentsInChildren<Renderer>(true);
        rens[6] = uranus.GetComponentsInChildren<Renderer>(true);
        rens[7] = neptune.GetComponentsInChildren<Renderer>(true);
    }

    public void SetTimeScale(float value)
    {
        Time.timeScale = value;
    }

    public void ToggleSettings()
    {
        isOpen = !isOpen;
        settingsPanel.SetActive(isOpen);
    }

    public void CloseSettings()
    {
        isOpen = false;
        settingsPanel.SetActive(false);
    }

    public void ToggleMercury(bool isOn)
    {
        foreach (var r in rens[0])
        {
            r.enabled = isOn;
        }
    }
    public void ToggleVenus(bool isOn)
    {
        foreach (var r in rens[1])
        {
            r.enabled = isOn;
        }
    }
    public void ToggleEarth(bool isOn)
    {
        foreach (var r in rens[2])
        {
            r.enabled = isOn;
        }
    }

    public void ToggleMars(bool isOn)
    {
        foreach (var r in rens[3])
        {
            r.enabled = isOn;
        }
    }

    public void ToggleJupiter(bool isOn)
    {
        foreach (var r in rens[4])
        {
            r.enabled = isOn;
        }
    }
    public void ToggleSaturn(bool isOn)
    {
        foreach (var r in rens[5])
        {
            r.enabled = isOn;
        }
    }
    public void ToggleUranus(bool isOn)
    {
        foreach (var r in rens[6])
        {
            r.enabled = isOn;
        }
    }
    public void ToggleNeptune(bool isOn)
    {
        foreach (var r in rens[7])
        {
            r.enabled = isOn;
        }
    }
}