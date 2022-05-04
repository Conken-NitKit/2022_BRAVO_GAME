using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

/// <summary>
/// ツイートボタンのクラス
/// </summary>
public class TweetButton : MonoBehaviour
{
    [SerializeField]
    private PlayerStatus playerStatus;

    /// <summary>
    /// ツイートボタンが押された時の動作
    /// </summary>
    public void PushTweetButton()
    {
        string esctext = UnityWebRequest.EscapeURL($"カスった回数は{playerStatus.playerGraze}回でした！\n\n");
        string linkUrl = UnityWebRequest.EscapeURL("https://unityroom.com/games/kisei \n");
        string tag = UnityWebRequest.EscapeURL("体内厨");
        var url = "https://twitter.com/intent/tweet?"
            + "text=" + esctext
            + "&hashtags=" + tag
            + "&url=" + linkUrl;
        Application.OpenURL(url);
    }
}
