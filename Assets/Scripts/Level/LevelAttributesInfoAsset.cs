using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="LevelAttributesInfoAsset", menuName ="Level/Level Attributes Info Asset")]
public class LevelAttributesInfoAsset : ScriptableObject
{
    public List<LevelInfoAsset> levelInfoAssets = new List<LevelInfoAsset>();
}
