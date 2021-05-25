public abstract class CharaFaceController : MonoBehaviour // TypeDefIndex: 6587
{
	// Fields
	[SerializeField] // RVA: 0x15D840 Offset: 0x15D941 VA: 0x15D840
	protected Character chara; // 0x18
	[SerializeField] // RVA: 0x15D850 Offset: 0x15D951 VA: 0x15D850
	protected FaceType currentFaceType; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15D860 Offset: 0x15D961 VA: 0x15D860
	private FaceType <RequestFaceType>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x15D870 Offset: 0x15D971 VA: 0x15D870
	private bool <FaceTypeLocked>k__BackingField; // 0x28

	// Properties
	public FaceType CurrentFaceType { get; set; }
	public FaceType RequestFaceType { get; set; }
	public bool FaceTypeLocked { get; set; }

	// Methods

	// RVA: 0x1D413C0 Offset: 0x1D414C1 VA: 0x1D413C0
	protected void set_CurrentFaceType(FaceType value) { }

	// RVA: 0x1D413D0 Offset: 0x1D414D1 VA: 0x1D413D0
	public FaceType get_CurrentFaceType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B800 Offset: 0x19B901 VA: 0x19B800
	// RVA: 0x1D413E0 Offset: 0x1D414E1 VA: 0x1D413E0
	protected void set_RequestFaceType(FaceType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B810 Offset: 0x19B911 VA: 0x19B810
	// RVA: 0x1D413F0 Offset: 0x1D414F1 VA: 0x1D413F0
	public FaceType get_RequestFaceType() { }

	[CompilerGeneratedAttribute] // RVA: 0x19B820 Offset: 0x19B921 VA: 0x19B820
	// RVA: 0x1D41400 Offset: 0x1D41501 VA: 0x1D41400
	public void set_FaceTypeLocked(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19B830 Offset: 0x19B931 VA: 0x19B830
	// RVA: 0x1D41410 Offset: 0x1D41511 VA: 0x1D41410
	public bool get_FaceTypeLocked() { }

	// RVA: 0x1D41420 Offset: 0x1D41521 VA: 0x1D41420
	private void Awake() { }

	// RVA: 0x1D414E0 Offset: 0x1D415E1 VA: 0x1D414E0 Slot: 4
	protected virtual void OnEnable() { }

	// RVA: 0x1D414F0 Offset: 0x1D415F1 VA: 0x1D414F0 Slot: 5
	public virtual void SetFaceType(FaceType requestFaceType) { }

	// RVA: 0x1D41530 Offset: 0x1D41631 VA: 0x1D41530 Slot: 6
	public virtual void ResetFaceType() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ApplyFaceType(FaceType faceType) { }

	// RVA: 0x1D41550 Offset: 0x1D41651 VA: 0x1D41550
	protected void .ctor() { }
}

