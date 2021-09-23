using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class textMixerBehaviour : PlayableBehaviour
{
    string m_DefaultText;

    string m_AssignedText;

    Text m_TrackBinding;

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        m_TrackBinding = playerData as Text;

        if (m_TrackBinding == null)
            return;

        if (m_TrackBinding.text != m_AssignedText)
            m_DefaultText = m_TrackBinding.text;

        int inputCount = playable.GetInputCount ();

        float totalWeight = 0f;
        float greatestWeight = 0f;
        int currentInputs = 0;

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);
            ScriptPlayable<textBehaviour> inputPlayable = (ScriptPlayable<textBehaviour>)playable.GetInput(i);
            textBehaviour input = inputPlayable.GetBehaviour ();
            
            totalWeight += inputWeight;

            if (inputWeight > greatestWeight)
            {
                m_AssignedText = input.text;
                m_TrackBinding.text = m_AssignedText;
                greatestWeight = inputWeight;
            }

            if (!Mathf.Approximately (inputWeight, 0f))
                currentInputs++;
        }

        if (currentInputs != 1 && 1f - totalWeight > greatestWeight)
        {
            m_TrackBinding.text = m_DefaultText;
        }
    }
}
