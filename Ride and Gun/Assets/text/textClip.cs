using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class textClip : PlayableAsset, ITimelineClipAsset
{
    public textBehaviour template = new textBehaviour ();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.Blending; }
    }

    public override Playable CreatePlayable (PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<textBehaviour>.Create (graph, template);
        return playable;
    }
}
