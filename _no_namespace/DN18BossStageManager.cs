public class DN18BossStageManager : BossStageManager // TypeDefIndex: 7733
{
	// Fields
	private Animator WallPaperAnimator; // 0xA8
	public List<Transform> OutsidePoints; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x168FF0 Offset: 0x1690F1 VA: 0x168FF0
	private CinemachineSmoothPath <InsidePath>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x169000 Offset: 0x169101 VA: 0x169000
	private CinemachineSmoothPath <OutsidePath>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x169010 Offset: 0x169111 VA: 0x169010
	private CinemachineDollyCart <DollyCart>k__BackingField; // 0xC8
	public Transform PlayerWarpTransform; // 0xD0

	// Properties
	public CinemachineSmoothPath InsidePath { get; set; }
	public CinemachineSmoothPath OutsidePath { get; set; }
	public CinemachineDollyCart DollyCart { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2B70 Offset: 0x1A2C71 VA: 0x1A2B70
	// RVA: 0x1CA8220 Offset: 0x1CA8321 VA: 0x1CA8220
	public CinemachineSmoothPath get_InsidePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2B80 Offset: 0x1A2C81 VA: 0x1A2B80
	// RVA: 0x1CA8230 Offset: 0x1CA8331 VA: 0x1CA8230
	private void set_InsidePath(CinemachineSmoothPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2B90 Offset: 0x1A2C91 VA: 0x1A2B90
	// RVA: 0x1CA8240 Offset: 0x1CA8341 VA: 0x1CA8240
	public CinemachineSmoothPath get_OutsidePath() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2BA0 Offset: 0x1A2CA1 VA: 0x1A2BA0
	// RVA: 0x1CA8250 Offset: 0x1CA8351 VA: 0x1CA8250
	private void set_OutsidePath(CinemachineSmoothPath value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2BB0 Offset: 0x1A2CB1 VA: 0x1A2BB0
	// RVA: 0x1CA8260 Offset: 0x1CA8361 VA: 0x1CA8260
	public CinemachineDollyCart get_DollyCart() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2BC0 Offset: 0x1A2CC1 VA: 0x1A2BC0
	// RVA: 0x1CA8270 Offset: 0x1CA8371 VA: 0x1CA8270
	private void set_DollyCart(CinemachineDollyCart value) { }

	// RVA: 0x1CA8280 Offset: 0x1CA8381 VA: 0x1CA8280 Slot: 4
	protected override void Start() { }

	// RVA: 0x1CA83B0 Offset: 0x1CA84B1 VA: 0x1CA83B0
	public void PlayWallPaper() { }

	// RVA: 0x1CA8410 Offset: 0x1CA8511 VA: 0x1CA8410
	public void SetDollyCartPos(Transform tf) { }

	// RVA: 0x1CA85D0 Offset: 0x1CA86D1 VA: 0x1CA85D0
	public void .ctor() { }
}

