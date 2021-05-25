public class HUDEquipItemControl : MonoBehaviour // TypeDefIndex: 8559
{
	// Fields
	[SerializeField] // RVA: 0x1708C0 Offset: 0x1709C1 VA: 0x1708C0
	private HUDFadeMove ItemEquip; // 0x18
	[SerializeField] // RVA: 0x1708D0 Offset: 0x1709D1 VA: 0x1708D0
	private HUDFadeMove RuneEquip; // 0x20
	[SerializeField] // RVA: 0x1708E0 Offset: 0x1709E1 VA: 0x1708E0
	private HUDFadeMove OnHandItem; // 0x28
	[SerializeField] // RVA: 0x1708F0 Offset: 0x1709F1 VA: 0x1708F0
	private Image HoldItemButtonBorder_X; // 0x30
	[SerializeField] // RVA: 0x170900 Offset: 0x170A01 VA: 0x170900
	private Image HoldItemButtonBorder_Y; // 0x38
	[SerializeField] // RVA: 0x170910 Offset: 0x170A11 VA: 0x170910
	private Image HoldItemButtonBorder_A; // 0x40
	[SerializeField] // RVA: 0x170920 Offset: 0x170A21 VA: 0x170920
	private Image HoldItemButtonBorder_B; // 0x48
	[SerializeField] // RVA: 0x170930 Offset: 0x170A31 VA: 0x170930
	private SText HoldItemButton_X; // 0x50
	[SerializeField] // RVA: 0x170940 Offset: 0x170A41 VA: 0x170940
	private SText HoldItemButton_Y; // 0x58
	[SerializeField] // RVA: 0x170950 Offset: 0x170A51 VA: 0x170950
	private SText HoldItemButton_A; // 0x60
	[SerializeField] // RVA: 0x170960 Offset: 0x170A61 VA: 0x170960
	private SText HoldItemButton_B; // 0x68
	private HUDEquipItemControl.OpenStatus status; // 0x70
	private FocusInterface currentFocus; // 0x78
	private HoldableInterface _holdObj; // 0x80

	// Methods

	// RVA: 0x1EBFC70 Offset: 0x1EBFD71 VA: 0x1EBFC70
	private string SetInteractionButtonText(HoldableInterface holdableInterface, FocusInterface currentFocus, ButtonInteractID buttonInteractID) { }

	// RVA: 0x1EBFE10 Offset: 0x1EBFF11 VA: 0x1EBFE10
	private void SetHoldItemText() { }

	// RVA: 0x1EC01B0 Offset: 0x1EC02B1 VA: 0x1EC01B0
	private void SetFishingText() { }

	// RVA: 0x1EC0220 Offset: 0x1EC0321 VA: 0x1EC0220
	private void SetGrapplingText() { }

	// RVA: 0x1EC02D0 Offset: 0x1EC03D1 VA: 0x1EC02D0
	private void Update() { }

	// RVA: 0x1EC0730 Offset: 0x1EC0831 VA: 0x1EC0730
	public void .ctor() { }
}

