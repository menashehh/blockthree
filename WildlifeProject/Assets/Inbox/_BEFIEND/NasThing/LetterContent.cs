using UnityEngine;

[CreateAssetMenu(fileName = "Letter", menuName = "Bos")]
public class LetterContent : ScriptableObject
{
    public string Title;
    public string Date;
    public string TextContent;
    public string LocationPlace;
    public string LocationCity;
    public string LinkToPage;
    public Sprite Picture;
}
