[Serializable]
public class HumanEquipClip : PlayableAsset, ITimelineClipAsset // TypeDefIndex: 8353
{
	// Fields
	public HumanEquipBehavior template; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x16F0C0 Offset: 0x16F1C1 VA: 0x16F0C0
	private HumanModel <HumanModel>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x16F0D0 Offset: 0x16F1D1 VA: 0x16F0D0
	private GameObject <BindTarget>k__BackingField; // 0x28
	[SerializeField] // RVA: 0x16F0E0 Offset: 0x16F1E1 VA: 0x16F0E0
	private ExposedReference<Transform> equipItem; // 0x30
	[SerializeField] // RVA: 0x16F0F0 Offset: 0x16F1F1 VA: 0x16F0F0
	private HumanAttachIDEnum attachIDEnum; // 0x40
	[SerializeField] // RVA: 0x16F100 Offset: 0x16F201 VA: 0x16F100
	private ExposedReference<Transform> returnItem; // 0x48
	private HumanEquipBehavior humanEquipBehavior; // 0x58

	// Properties
	public ClipCaps clipCaps { get; }
	public HumanModel HumanModel { get; set; }
	public GameObject BindTarget { get; set; }

	// Methods

	// RVA: 0x1E92860 Offset: 0x1E92961 VA: 0x1E92860 Slot: 9
	public ClipCaps get_clipCaps() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7140 Offset: 0x1A7241 VA: 0x1A7140
	// RVA: 0x1E92870 Offset: 0x1E92971 VA: 0x1E92870
	public HumanModel get_HumanModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7150 Offset: 0x1A7251 VA: 0x1A7150
	// RVA: 0x1E92880 Offset: 0x1E92981 VA: 0x1E92880
	public void set_HumanModel(HumanModel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7160 Offset: 0x1A7261 VA: 0x1A7160
	// RVA: 0x1E92890 Offset: 0x1E92991 VA: 0x1E92890
	public GameObject get_BindTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7170 Offset: 0x1A7271 VA: 0x1A7170
	// RVA: 0x1E928A0 Offset: 0x1E929A1 VA: 0x1E928A0
	public void set_BindTarget(GameObject value) { }

	// RVA: 0x1E928B0 Offset: 0x1E929B1 VA: 0x1E928B0
	public void SetHumanModel(HumanModel humanModel) { }

	// RVA: 0x1E92900 Offset: 0x1E92A01 VA: 0x1E92900 Slot: 6
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	// RVA: 0x1E92A90 Offset: 0x1E92B91 VA: 0x1E92A90
	public void .ctor() { }
}

