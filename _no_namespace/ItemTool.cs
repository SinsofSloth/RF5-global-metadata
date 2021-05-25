public class ItemTool : ItemEquip // TypeDefIndex: 7658
{
	// Fields
	[SerializeField] // RVA: 0x168830 Offset: 0x168931 VA: 0x168830
	private LayerMask m_HitLayer; // 0x60
	[SerializeField] // RVA: 0x168840 Offset: 0x168941 VA: 0x168840
	public Transform LeftHandIkTarget; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x168850 Offset: 0x168951 VA: 0x168850
	private bool <IsRightEquip>k__BackingField; // 0x70
	public static List<ItemTool> m_ActiveToolList; // 0x0

	// Properties
	public bool IsRightEquip { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2400 Offset: 0x1A2501 VA: 0x1A2400
	// RVA: 0x2092A30 Offset: 0x2092B31 VA: 0x2092A30
	public bool get_IsRightEquip() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2410 Offset: 0x1A2511 VA: 0x1A2410
	// RVA: 0x2092A40 Offset: 0x2092B41 VA: 0x2092A40
	private void set_IsRightEquip(bool value) { }

	// RVA: 0x2092A50 Offset: 0x2092B51 VA: 0x2092A50 Slot: 4
	public override void Awake() { }

	// RVA: 0x2092A60 Offset: 0x2092B61 VA: 0x2092A60 Slot: 8
	protected override void OnEnable() { }

	// RVA: 0x2092AF0 Offset: 0x2092BF1 VA: 0x2092AF0 Slot: 9
	protected override void OnDisable() { }

	// RVA: 0x2092B80 Offset: 0x2092C81 VA: 0x2092B80 Slot: 5
	public override bool Attach(HumanController human, HumanAttachIDEnum attachId) { }

	// RVA: 0x2092BC0 Offset: 0x2092CC1 VA: 0x2092BC0
	public void OnTrail() { }

	// RVA: 0x2092BD0 Offset: 0x2092CD1 VA: 0x2092BD0
	public void OffTrail(float fadeTime = 0.1) { }

	// RVA: 0x2092BE0 Offset: 0x2092CE1 VA: 0x2092BE0 Slot: 7
	public override void SetVisible(bool visible) { }

	// RVA: 0x2092BF0 Offset: 0x2092CF1 VA: 0x2092BF0
	public static void DisableAllHit() { }

	// RVA: 0x2092C00 Offset: 0x2092D01 VA: 0x2092C00
	public void .ctor() { }

	// RVA: 0x2092C40 Offset: 0x2092D41 VA: 0x2092C40
	private static void .cctor() { }
}

