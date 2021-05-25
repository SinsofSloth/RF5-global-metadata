[Serializable]
public class FxProClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8345
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16F010 Offset: 0x16F111 VA: 0x16F010
	private FxPro <FxPro>k__BackingField; // 0x18
	public bool IsChangeFocusTarget; // 0x20
	public ExposedReference<Transform> FocusTargetStart; // 0x28
	public ExposedReference<Transform> FocusTargetEnd; // 0x38
	public FxProBehaviour FxProBehaviour; // 0x48

	// Properties
	public FxPro FxPro { get; set; }
	public ClipCaps clipCaps { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7020 Offset: 0x1A7121 VA: 0x1A7020
	// RVA: 0x22A04F0 Offset: 0x22A05F1 VA: 0x22A04F0
	public FxPro get_FxPro() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7030 Offset: 0x1A7131 VA: 0x1A7030
	// RVA: 0x22A0500 Offset: 0x22A0601 VA: 0x22A0500
	public void set_FxPro(FxPro value) { }

	// RVA: 0x22A0510 Offset: 0x22A0611 VA: 0x22A0510 Slot: 9
	public ClipCaps get_clipCaps() { }

	// RVA: 0x22A0520 Offset: 0x22A0621 VA: 0x22A0520 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x22A0680 Offset: 0x22A0781 VA: 0x22A0680
	public void .ctor() { }
}

