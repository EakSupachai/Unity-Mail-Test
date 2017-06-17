using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MailTester : MonoBehaviour {

    public void SendMail() {
        Application.OpenURL("mailto:me.supachai@gmail.com?subject=You are a genius.&body=This is a test.");
    }
}
