using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Simple UI Handler script that stats or stops the voice recording
/// and updates the UI
/// </summary>
public class UIHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject voiceInputButton;

    [SerializeField]
    TMPro.TMP_Dropdown languageSelector;

    [SerializeField]
    private SpeechtToText speechToText;

    public string GetLanguage()
    {
        string languageString = string.Empty;

        if (languageSelector != null)
        {
            switch (languageSelector.value)
            {
                case 1:
                    languageString = "GERMAN";
                    break;
                case 2:
                    languageString = "FRENCH";
                    break;
                default:
                    languageString = "ENGLISH";
                    break;
            }
        }    

        return languageString;
    }

    /// <summary>
    /// Starts the mic and saves audio input into audio clip on stop
    /// </summary>
    public void StartOrStopRecording()
    {
        if (!speechToText.IsRecording)
        {
            speechToText.StartRecording();
            voiceInputButton.GetComponent<Image>().enabled = true;
        }
        else
        {
            voiceInputButton.GetComponent<Image>().enabled = false;
            speechToText.StopRecording();
        }
    }
}
