using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class URL : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenURL(string link)
    {
            Application.OpenURL(link);
    }

}
