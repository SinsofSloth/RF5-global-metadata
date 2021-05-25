[Serializable]
public class HumanIKClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8357
{
	// Fields
	public HumanIKBehavior template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F150 Offset: 0x16F251 VA: 0x16F150
	private GameObject <BindTarget>k__BackingField; // 0x20
	[SerializeField] // RVA: 0x16F160 Offset: 0x16F261 VA: 0x16F160
	private bool StartIK; // 0x28
	[SerializeField] // RVA: 0x16F170 Offset: 0x16F271 VA: 0x16F170
	private bool EndIK; // 0x29
	private HumanIKBehavior humanIKBehavior; // 0x30

	// Properties
	public ClipCaps clipCaps { get; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x1E970A0 Offset: 0x1E971A1 VA: 0x1E970A0 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7200 Offset: 0x1A7301 VA: 0x1A7200
	// RVA: 0x1E970B0 Offset: 0x1E971B1 VA: 0x1E970B0
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7210 Offset: 0x1A7311 VA: 0x1A7210
	// RVA: 0x1E970C0 Offset: 0x1E971C1 VA: 0x1E970C0
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x1E970D0 Offset: 0x1E971D1 VA: 0x1E970D0 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1E97210 Offset: 0x1E97311 VA: 0x1E97210
	public void .ctor() { }
}

