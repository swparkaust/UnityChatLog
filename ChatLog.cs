using UnityEngine;
using System.Collections.Generic;

public class ChatLog : MonoBehaviour
{
    public int maxLines = 10;
    public Font font;

    private List<string> chatLog = new List<string>();
    private List<GUIText> guiTexts = new List<GUIText>();

    void Update()
    {
        List<GUIText> removeList = new List<GUIText>();
        for (int i = 0; i < guiTexts.Count - 1; i++)
        {
            GUIText guiTxt1 = guiTexts[i];
            GUIText guiTxt2 = guiTexts[i + 1];
            if (guiTxt1.Y + guiTxt1.Height > guiTxt2.Y)
            {
                guiTxt1.Y = guiTxt2.Y - guiTxt1.Height;
            }
            if (guiTxt1.Y + guiTxt1.Height < 0)
            {
                removeList.Add(guiTxt1);
            }
        }
        foreach (GUIText guiText in removeList)
        {
            guiTexts.Remove(guiText);
        }
        foreach (GUIText guiText in guiTexts)
        {
            guiText.Y -= 2;
            guiText.Opacity -= 0.00392f;
        }
    }

    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.font = font;
        myStyle.fontSize = 50;

        for (int i = 0; i < guiTexts.Count; i++)
        {
            GUI.color = new Color(1, 1, 1, guiTexts[i].Opacity);
            myStyle.normal.textColor = Color.gray;
            GUI.Label(new Rect(guiTexts[i].X, guiTexts[i].Y + 2, guiTexts[i].Width, guiTexts[i].Height), guiTexts[i].Text, myStyle);
            GUI.Label(new Rect(guiTexts[i].X + 2, guiTexts[i].Y, guiTexts[i].Width, guiTexts[i].Height), guiTexts[i].Text, myStyle);
            GUI.Label(new Rect(guiTexts[i].X + 2, guiTexts[i].Y + 4, guiTexts[i].Width, guiTexts[i].Height), guiTexts[i].Text, myStyle);
            GUI.Label(new Rect(guiTexts[i].X + 4, guiTexts[i].Y + 2, guiTexts[i].Width, guiTexts[i].Height), guiTexts[i].Text, myStyle);
            myStyle.normal.textColor = Color.white;
            GUI.Label(new Rect(guiTexts[i].X + 2, guiTexts[i].Y + 2, guiTexts[i].Width, guiTexts[i].Height), guiTexts[i].Text, myStyle);
        }
    }

    public void Write(string text)
    {
        chatLog.Add(text);

        if (chatLog.Count >= maxLines)
            chatLog.RemoveAt(0);

        GUIStyle myStyle = new GUIStyle();
        myStyle.font = font;
        myStyle.fontSize = 50;

        Vector2 size = myStyle.CalcSize(new GUIContent(text));
        guiTexts.Add(new GUIText(text, 0, Screen.height - 40, size.x, size.y, 1.0f));
    }

    public class GUIText
    {

        public string Text;
        public float X;
        public float Y;
        public float Width;
        public float Height;
        public float Opacity;

        public GUIText(string text, float x, float y, float width, float height, float opacity)
        {
            Text = text;
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Opacity = opacity;
        }
    }
}
