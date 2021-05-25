[Serializable]
public class SpringBoneClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8364
{
	// Fields
	public SpringBoneBehavior template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F250 Offset: 0x16F351 VA: 0x16F250
	private GameObject <BindTarget>k__BackingField; // 0x20
	[SerializeField] // RVA: 0x16F260 Offset: 0x16F361 VA: 0x16F260
	private bool StartEnable; // 0x28
	[SerializeField] // RVA: 0x16F270 Offset: 0x16F371 VA: 0x16F270
	private bool EndEnable; // 0x29

	// Properties
	public ClipCaps clipCaps { get; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x2248000 Offset: 0x2248101 VA: 0x2248000 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A72A0 Offset: 0x1A73A1 VA: 0x1A72A0
	// RVA: 0x2248010 Offset: 0x2248111 VA: 0x2248010
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A72B0 Offset: 0x1A73B1 VA: 0x1A72B0
	// RVA: 0x2248020 Offset: 0x2248121 VA: 0x2248020
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x2248030 Offset: 0x2248131 VA: 0x2248030 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x2248150 Offset: 0x2248251 VA: 0x2248150
	public void .ctor() { }
}

