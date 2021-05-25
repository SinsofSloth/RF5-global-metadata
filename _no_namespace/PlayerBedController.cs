public class PlayerBedController : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 7543
{
	// Fields
	[SerializeField] // RVA: 0x166FC0 Offset: 0x1670C1 VA: 0x166FC0
	private float AllowDot; // 0x18

	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x1FE8D00 Offset: 0x1FE8E01 VA: 0x1FE8D00 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x1FE8DF0 Offset: 0x1FE8EF1 VA: 0x1FE8DF0 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x1FE8EB0 Offset: 0x1FE8FB1 VA: 0x1FE8EB0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x1FE8EC0 Offset: 0x1FE8FC1 VA: 0x1FE8EC0 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x1FE8ED0 Offset: 0x1FE8FD1 VA: 0x1FE8ED0 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x1FE8EE0 Offset: 0x1FE8FE1 VA: 0x1FE8EE0 Slot: 11
	public void OnFocus() { }

	// RVA: 0x1FE8EF0 Offset: 0x1FE8FF1 VA: 0x1FE8EF0 Slot: 12
	public void OffFocus() { }

	// RVA: 0x1FE8F00 Offset: 0x1FE9001 VA: 0x1FE8F00 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x1FE8FC0 Offset: 0x1FE90C1 VA: 0x1FE8FC0 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x1FE9330 Offset: 0x1FE9431 VA: 0x1FE9330
	private void Unmarried() { }

	// RVA: 0x1FE9270 Offset: 0x1FE9371 VA: 0x1FE9270
	private void Married() { }

	// RVA: 0x1FE9050 Offset: 0x1FE9151 VA: 0x1FE9050
	private bool BedJudgment() { }

	// RVA: 0x1FE9580 Offset: 0x1FE9681 VA: 0x1FE9580
	public void OnSelected(int select) { }

	// RVA: 0x1FE96E0 Offset: 0x1FE97E1 VA: 0x1FE96E0
	public static void PlayerSleep() { }

	// RVA: 0x1FE9740 Offset: 0x1FE9841 VA: 0x1FE9740
	public static void ProcessingPlayerSleep() { }

	// RVA: 0x1FE8F90 Offset: 0x1FE9091 VA: 0x1FE8F90 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x1FE9900 Offset: 0x1FE9A01 VA: 0x1FE9900 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x1FE9950 Offset: 0x1FE9A51 VA: 0x1FE9950 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x1FE9960 Offset: 0x1FE9A61 VA: 0x1FE9960 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x1FE9970 Offset: 0x1FE9A71 VA: 0x1FE9970
	public void .ctor() { }

	// RVA: 0x1FE9980 Offset: 0x1FE9A81 VA: 0x1FE9980 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x1FE9990 Offset: 0x1FE9A91 VA: 0x1FE9990 Slot: 18
	private Transform FocusInterface.get_transform() { }
}

