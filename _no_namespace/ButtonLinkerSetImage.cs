public class ButtonLinkerSetImage : ButtonLinker // TypeDefIndex: 8447
{
	// Fields
	[SerializeField] // RVA: 0x16F990 Offset: 0x16FA91 VA: 0x16F990
	private Image BorderImage; // 0x60
	[SerializeField] // RVA: 0x16F9A0 Offset: 0x16FAA1 VA: 0x16F9A0
	private Sprite OutFocusSprite; // 0x68
	[SerializeField] // RVA: 0x16F9B0 Offset: 0x16FAB1 VA: 0x16F9B0
	private Sprite OnFocusSprite; // 0x70
	[SerializeField] // RVA: 0x16F9C0 Offset: 0x16FAC1 VA: 0x16F9C0
	private Vector2 AddPosOnFocus; // 0x78
	[SerializeField] // RVA: 0x16F9D0 Offset: 0x16FAD1 VA: 0x16F9D0
	private Text text; // 0x80
	[SerializeField] // RVA: 0x16F9E0 Offset: 0x16FAE1 VA: 0x16F9E0
	private Color OutTextColor; // 0x88
	[SerializeField] // RVA: 0x16F9F0 Offset: 0x16FAF1 VA: 0x16F9F0
	private Color OnTextColor; // 0x98
	private bool initdSize; // 0xA8
	private Vector2 OffSize; // 0xAC
	private Vector2 OnSize; // 0xB4

	// Methods

	// RVA: 0x206E120 Offset: 0x206E221 VA: 0x206E120 Slot: 4
	protected override void Awake() { }

	// RVA: 0x206E150 Offset: 0x206E251 VA: 0x206E150
	private void initSize() { }

	// RVA: 0x206E2E0 Offset: 0x206E3E1 VA: 0x206E2E0 Slot: 10
	public override void OnFocus() { }

	// RVA: 0x206E550 Offset: 0x206E651 VA: 0x206E550 Slot: 11
	public override void EndFocus() { }

	// RVA: 0x206E770 Offset: 0x206E871 VA: 0x206E770
	public void .ctor() { }
}

