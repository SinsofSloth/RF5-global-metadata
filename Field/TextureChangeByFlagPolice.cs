public class TextureChangeByFlagPolice : TextureChangeByFlag // TypeDefIndex: 10469
{
	// Fields
	private static readonly BuilderId[] CurtainBuilderIds; // 0x0
	private static readonly BuilderId[] WallBuilderIds; // 0x8
	private static readonly BuilderId[] FloorBuilderIds; // 0x10
	private static readonly int[] CurtainLoaderIds; // 0x18
	private static readonly int[] WallLoaderIds; // 0x20
	private static readonly int[] FloorLoaderIds; // 0x28
	private static readonly int[] FloorNormalLoaderIds; // 0x30
	[SerializeField] // RVA: 0x181A80 Offset: 0x181B81 VA: 0x181A80
	protected Renderer[] CurtainChangeRenderers; // 0x38
	[SerializeField] // RVA: 0x181A90 Offset: 0x181B91 VA: 0x181A90
	protected Renderer[] WallChangeRenderers; // 0x40
	[SerializeField] // RVA: 0x181AA0 Offset: 0x181BA1 VA: 0x181AA0
	protected Renderer[] FloorChangeRenderers; // 0x48
	[SerializeField] // RVA: 0x181AB0 Offset: 0x181BB1 VA: 0x181AB0
	protected Material CurtainChangeMaterial; // 0x50
	[SerializeField] // RVA: 0x181AC0 Offset: 0x181BC1 VA: 0x181AC0
	protected Material WallChangeMaterial; // 0x58
	[SerializeField] // RVA: 0x181AD0 Offset: 0x181BD1 VA: 0x181AD0
	protected Material FloorChangeMaterial; // 0x60
	private int LoadCurtainId; // 0x68
	private int LoadWallId; // 0x6C
	private int LoadFloorId; // 0x70
	private int LoadFloorNormalId; // 0x74
	private int BumpMapPropertyId; // 0x78
	private bool IsLoad; // 0x7C

	// Methods

	// RVA: 0x1EF0050 Offset: 0x1EF0151 VA: 0x1EF0050 Slot: 5
	protected override void OnDestroy() { }

	// RVA: 0x1EF0170 Offset: 0x1EF0271 VA: 0x1EF0170 Slot: 6
	protected override void Awake() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF6A0 Offset: 0x1AF7A1 VA: 0x1AF6A0
	// RVA: 0x1EF01D0 Offset: 0x1EF02D1 VA: 0x1EF01D0 Slot: 4
	public override IEnumerator Load() { }

	// RVA: 0x1EF0280 Offset: 0x1EF0381 VA: 0x1EF0280
	public void .ctor() { }

	// RVA: 0x1EF0290 Offset: 0x1EF0391 VA: 0x1EF0290
	private static void .cctor() { }
}

