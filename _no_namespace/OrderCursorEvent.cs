public class OrderCursorEvent : CursorEvent // TypeDefIndex: 8745
{
	// Fields
	[SerializeField] // RVA: 0x173160 Offset: 0x173261 VA: 0x173160
	private Text TopicText; // 0x18
	[SerializeField] // RVA: 0x173170 Offset: 0x173271 VA: 0x173170
	private Image TopicIcon; // 0x20
	[SerializeField] // RVA: 0x173180 Offset: 0x173281 VA: 0x173180
	private Text NPCNameText; // 0x28
	[SerializeField] // RVA: 0x173190 Offset: 0x173291 VA: 0x173190
	private Text ContentHeadText; // 0x30
	[SerializeField] // RVA: 0x1731A0 Offset: 0x1732A1 VA: 0x1731A0
	private Text ContentText; // 0x38
	[SerializeField] // RVA: 0x1731B0 Offset: 0x1732B1 VA: 0x1731B0
	private Text RewardHeadText; // 0x40
	[SerializeField] // RVA: 0x1731C0 Offset: 0x1732C1 VA: 0x1731C0
	private Text RewardItemText; // 0x48
	[SerializeField] // RVA: 0x1731D0 Offset: 0x1732D1 VA: 0x1731D0
	private Sprite[] IconSprite; // 0x50
	[SerializeField] // RVA: 0x1731E0 Offset: 0x1732E1 VA: 0x1731E0
	private UIFaceIconLoader UIFaceIconLoader; // 0x58

	// Methods

	// RVA: 0x1F1D8A0 Offset: 0x1F1D9A1 VA: 0x1F1D8A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F1D9A0 Offset: 0x1F1DAA1 VA: 0x1F1D9A0
	public void UpdateOrderData(OrderData _data) { }

	// RVA: 0x1F1E6D0 Offset: 0x1F1E7D1 VA: 0x1F1E6D0
	public void .ctor() { }
}

