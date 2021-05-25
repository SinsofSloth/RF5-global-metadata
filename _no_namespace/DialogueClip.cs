[Serializable]
public class DialogueClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8327
{
	// Fields
	public DialogueBehaviour template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16EDD0 Offset: 0x16EED1 VA: 0x16EDD0
	private GameObject <BindTarget>k__BackingField; // 0x20

	// Properties
	public ClipCaps clipCaps { get; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x1CEA500 Offset: 0x1CEA601 VA: 0x1CEA500 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6E10 Offset: 0x1A6F11 VA: 0x1A6E10
	// RVA: 0x1CEA510 Offset: 0x1CEA611 VA: 0x1CEA510
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6E20 Offset: 0x1A6F21 VA: 0x1A6E20
	// RVA: 0x1CEA520 Offset: 0x1CEA621 VA: 0x1CEA520
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x1CEA530 Offset: 0x1CEA631 VA: 0x1CEA530 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1CEA5D0 Offset: 0x1CEA6D1 VA: 0x1CEA5D0
	public void .ctor() { }
}

