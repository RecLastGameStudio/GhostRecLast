using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolicyMenu : MonoBehaviour
{

    private string policyKey = "policy";

    // Start is called before the first frame update
    void Start()
    {
        var accepted = PlayerPrefs.GetInt(policyKey, 0) == 1;

        if (accepted)
            return;

        SimpleGDPR.ShowDialog(new TermsOfServiceDialog().
                SetTermsOfServiceLink("https://unity3d.com/legal/terms-of-service").
                SetPrivacyPolicyLink("https://unity3d.com/legal/privacy-policy"),
                onMenuClosed);
    }

    private void onMenuClosed ()
    {
        Debug.LogWarning("Policy Accepted");
        PlayerPrefs.SetInt(policyKey, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
