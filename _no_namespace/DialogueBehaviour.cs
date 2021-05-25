[Serializable]
public class DialogueBehaviour : PlayableBehaviour // TypeDefIndex: 8326
{
	// Fields
	public string TextId; // 0x10
	public TimelineMsgID msgId; // 0x18
	public bool hasToPause; // 0x1C
	public bool endOfDialogClose; // 0x1D
	private bool clipPlayed; // 0x1E
	private bool pauseScheduled; // 0x1F

	// Methods

	// RVA: 0x1CEA0F0 Offset: 0x1CEA1F1 VA: 0x1CEA0F0 Slot: 15
	public override void OnPlayableCreate(Playable playable) { }

	// RVA: 0x1CEA230 Offset: 0x1CEA331 VA: 0x1CEA230 Slot: 20
	public override void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1CEA3F0 Offset: 0x1CEA4F1 VA: 0x1CEA3F0 Slot: 18
	public override void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1CEA4F0 Offset: 0x1CEA5F1 VA: 0x1CEA4F0
	public void .ctor() { }
}

