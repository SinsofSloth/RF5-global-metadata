public abstract class GimmickBase : MonoBehaviour // TypeDefIndex: 7560
{
	// Fields
	[SerializeField] // RVA: 0x167460 Offset: 0x167561 VA: 0x167460
	private GimmickLayoutID _GimmickLayoutID; // 0x18
	private bool _GimmickFlag; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x167470 Offset: 0x167571 VA: 0x167470
	private bool <IsInit>k__BackingField; // 0x1D

	// Properties
	public GimmickLayoutID GimmickLayoutID { get; set; }
	public virtual bool GimmickPassFlag { get; set; }
	public bool IsInit { get; set; }

	// Methods

	// RVA: 0x1E4A870 Offset: 0x1E4A971 VA: 0x1E4A870
	public GimmickLayoutID get_GimmickLayoutID() { }

	// RVA: 0x1E4A880 Offset: 0x1E4A981 VA: 0x1E4A880
	public void set_GimmickLayoutID(GimmickLayoutID value) { }

	// RVA: 0x1E4A890 Offset: 0x1E4A991 VA: 0x1E4A890 Slot: 4
	public virtual bool get_GimmickPassFlag() { }

	// RVA: 0x1E4A8A0 Offset: 0x1E4A9A1 VA: 0x1E4A8A0
	private void set_GimmickPassFlag(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1AC0 Offset: 0x1A1BC1 VA: 0x1A1AC0
	// RVA: 0x1E4A8B0 Offset: 0x1E4A9B1 VA: 0x1E4A8B0
	public bool get_IsInit() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A1AD0 Offset: 0x1A1BD1 VA: 0x1A1AD0
	// RVA: 0x1E4A8C0 Offset: 0x1E4A9C1 VA: 0x1E4A8C0
	protected void set_IsInit(bool value) { }

	// RVA: 0x1E4A8D0 Offset: 0x1E4A9D1 VA: 0x1E4A8D0 Slot: 5
	protected virtual void OnDestroy() { }

	// RVA: 0x1E4A980 Offset: 0x1E4AA81 VA: 0x1E4A980 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x1E4AA00 Offset: 0x1E4AB01 VA: 0x1E4AA00 Slot: 7
	public virtual void SetGimmickState(bool newState) { }

	// RVA: 0x1E4AA10 Offset: 0x1E4AB11 VA: 0x1E4AA10 Slot: 8
	public virtual bool GetGimmickState() { }

	// RVA: 0x1E4AA20 Offset: 0x1E4AB21 VA: 0x1E4AA20 Slot: 9
	public virtual void Init() { }

	// RVA: 0x1E4AA30 Offset: 0x1E4AB31 VA: 0x1E4AA30 Slot: 10
	public virtual void SetGimmickActiveFlag(bool isActive) { }

	// RVA: 0x1E4AA70 Offset: 0x1E4AB71 VA: 0x1E4AA70
	protected void .ctor() { }
}

