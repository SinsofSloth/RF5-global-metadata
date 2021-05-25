public class BeanSowingNPC : MonoBehaviour // TypeDefIndex: 7353
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x165E60 Offset: 0x165F61 VA: 0x165E60
	private bool <IsLookAtPlayer>k__BackingField; // 0x18
	private FestivalCharacterController controller; // 0x20
	private readonly Vector3[] BEAN_DIR_WAY2; // 0x28
	private readonly Vector3[] BEAN_DIR_WAY3; // 0x30
	private readonly Vector3[] BEAN_DIR_WAY4; // 0x38
	private readonly Vector3[] BEAN_DIR_WAY5; // 0x40
	private List<BeanID> beanListWay4; // 0x48
	private List<BeanID> beanListWay5; // 0x50

	// Properties
	public bool IsLookAtPlayer { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A0250 Offset: 0x1A0351 VA: 0x1A0250
	// RVA: 0x20D8750 Offset: 0x20D8851 VA: 0x20D8750
	public bool get_IsLookAtPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A0260 Offset: 0x1A0361 VA: 0x1A0260
	// RVA: 0x20D8760 Offset: 0x20D8861 VA: 0x20D8760
	public void set_IsLookAtPlayer(bool value) { }

	// RVA: 0x20D6FA0 Offset: 0x20D70A1 VA: 0x20D6FA0
	public void Init(FestivalCharacterController _controller) { }

	// RVA: 0x20D8770 Offset: 0x20D8871 VA: 0x20D8770
	private void BeanGenerator(BeanID _bean_id, Vector3 _dir) { }

	// RVA: 0x20D7F90 Offset: 0x20D8091 VA: 0x20D7F90
	public void Sowing(SowingPattern _pattern, BeanID _bean_id) { }

	// RVA: 0x20D89C0 Offset: 0x20D8AC1 VA: 0x20D89C0
	public void .ctor() { }
}

