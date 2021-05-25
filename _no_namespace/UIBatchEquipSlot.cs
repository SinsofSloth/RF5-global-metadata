public class UIBatchEquipSlot : ButtonLinker // TypeDefIndex: 8686
{
	// Fields
	[SerializeField] // RVA: 0x172410 Offset: 0x172511 VA: 0x172410
	[RangeAttribute] // RVA: 0x172410 Offset: 0x172511 VA: 0x172410
	private int SlotId; // 0x5C
	[SerializeField] // RVA: 0x172450 Offset: 0x172551 VA: 0x172450
	private Image BatchImage; // 0x60
	[SerializeField] // RVA: 0x172460 Offset: 0x172561 VA: 0x172460
	private Text BatchNameText; // 0x68
	[SerializeField] // RVA: 0x172470 Offset: 0x172571 VA: 0x172470
	private Text BatchDiscriptText; // 0x70
	[SerializeField] // RVA: 0x172480 Offset: 0x172581 VA: 0x172480
	private Sprite OnSelectSprite; // 0x78
	[SerializeField] // RVA: 0x172490 Offset: 0x172591 VA: 0x172490
	private Sprite NotSelectSprite; // 0x80
	[SerializeField] // RVA: 0x1724A0 Offset: 0x1725A1 VA: 0x1724A0
	private UIBatchPageControl UIBatchPageControl; // 0x88
	[SerializeField] // RVA: 0x1724B0 Offset: 0x1725B1 VA: 0x1724B0
	private CursorLinkConnector BatchEquipSlotConnector; // 0x90
	[SerializeField] // RVA: 0x1724C0 Offset: 0x1725C1 VA: 0x1724C0
	private GameObject resetLinkerObj; // 0x98

	// Properties
	public PoliceBatchId PoliceBatchId { get; set; }

	// Methods

	// RVA: 0x1F01E30 Offset: 0x1F01F31 VA: 0x1F01E30
	public PoliceBatchId get_PoliceBatchId() { }

	// RVA: 0x1F01EB0 Offset: 0x1F01FB1 VA: 0x1F01EB0
	public void set_PoliceBatchId(PoliceBatchId value) { }

	// RVA: 0x1F01E70 Offset: 0x1F01F71 VA: 0x1F01E70
	private PoliceBatchId GetBatch(int slot) { }

	// RVA: 0x1F01EC0 Offset: 0x1F01FC1 VA: 0x1F01EC0
	private void SetBatch(int slot, PoliceBatchId value) { }

	// RVA: 0x1F02170 Offset: 0x1F02271 VA: 0x1F02170
	public void DoEquip(PoliceBatchId policeBatchId) { }

	// RVA: 0x1F02240 Offset: 0x1F02341 VA: 0x1F02240
	public void DoUnEquip() { }

	// RVA: 0x1F02300 Offset: 0x1F02401 VA: 0x1F02300
	private void OnEnable() { }

	// RVA: 0x1F02060 Offset: 0x1F02161 VA: 0x1F02060
	public void DispBatch() { }

	// RVA: 0x1F02490 Offset: 0x1F02591 VA: 0x1F02490
	public void EndSelect() { }

	// RVA: 0x1F02500 Offset: 0x1F02601 VA: 0x1F02500 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x1F028D0 Offset: 0x1F029D1 VA: 0x1F028D0 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x1F028E0 Offset: 0x1F029E1 VA: 0x1F028E0 Slot: 8
	public override void OnNextFocus(CursorLinker nextObject) { }

	// RVA: 0x1F029F0 Offset: 0x1F02AF1 VA: 0x1F029F0
	private void OnDisable() { }

	// RVA: 0x1F02340 Offset: 0x1F02441 VA: 0x1F02340
	private void SetLinker() { }

	// RVA: 0x1F02A60 Offset: 0x1F02B61 VA: 0x1F02A60
	public void .ctor() { }
}

