public class UIStrengthening : CursorLinkConnector // TypeDefIndex: 8856
{
	// Fields
	public static bool IsWeapon; // 0x0
	[SerializeField] // RVA: 0x1743E0 Offset: 0x1744E1 VA: 0x1743E0
	private UIStrengtheningTopMenu topMenu; // 0x58
	[SerializeField] // RVA: 0x1743F0 Offset: 0x1744F1 VA: 0x1743F0
	private Text rpCostText; // 0x60
	[SerializeField] // RVA: 0x174400 Offset: 0x174501 VA: 0x174400
	private UICraftResult strengtheningResult; // 0x68
	[SerializeField] // RVA: 0x174410 Offset: 0x174511 VA: 0x174410
	private CursorLinker firstCursor; // 0x70
	[SerializeField] // RVA: 0x174420 Offset: 0x174521 VA: 0x174420
	private ButtonLinker confirmOKButton; // 0x78
	[SerializeField] // RVA: 0x174430 Offset: 0x174531 VA: 0x174430
	private List<UIStrengtheningSlot> strengtheningSlot; // 0x80
	private bool enoughRP; // 0x88
	private int cost; // 0x8C

	// Methods

	// RVA: 0x1FF3FB0 Offset: 0x1FF40B1 VA: 0x1FF3FB0
	private void Start() { }

	// RVA: 0x1FF4510 Offset: 0x1FF4611 VA: 0x1FF4510
	private void OnDestroy() { }

	// RVA: 0x1FF41A0 Offset: 0x1FF42A1 VA: 0x1FF41A0
	public void PreviwStrengtheningResult() { }

	// RVA: 0x1FF48F0 Offset: 0x1FF49F1 VA: 0x1FF48F0
	public void DoStrengthening() { }

	// RVA: 0x1FF4ED0 Offset: 0x1FF4FD1 VA: 0x1FF4ED0
	private void OnResultWindow() { }

	// RVA: 0x1FF4570 Offset: 0x1FF4671 VA: 0x1FF4570
	private void UpdateRPText() { }

	// RVA: 0x1FF4110 Offset: 0x1FF4211 VA: 0x1FF4110
	private void UpdatePlayerStatusOnTopMenu() { }

	// RVA: 0x1FF5590 Offset: 0x1FF5691 VA: 0x1FF5590
	public bool IsItemEnableStrengthening(ItemData _item_data) { }

	// RVA: 0x1FF5670 Offset: 0x1FF5771 VA: 0x1FF5670
	public void .ctor() { }

	// RVA: 0x1FF56F0 Offset: 0x1FF57F1 VA: 0x1FF56F0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8B00 Offset: 0x1A8C01 VA: 0x1A8B00
	// RVA: 0x1FF5750 Offset: 0x1FF5851 VA: 0x1FF5750
	private void <DoStrengthening>b__13_2() { }
}

