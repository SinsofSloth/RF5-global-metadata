public class TalkPoint : MonoBehaviour, InteractionInterface, FocusInterface // TypeDefIndex: 10380
{
	// Fields
	public bool isTalking; // 0x18
	private GameObject crystalCountDisplay; // 0x20
	private string scriptName; // 0x28

	// Properties
	public bool Focusable { get; }
	public FocusObjectType FocusObjectType { get; }
	public int FocusPriority { get; }
	public FocusPointType FocusPointType { get; }

	// Methods

	// RVA: 0x2029D60 Offset: 0x2029E61 VA: 0x2029D60 Slot: 9
	public string GetFocusName() { }

	// RVA: 0x2029FC0 Offset: 0x202A0C1 VA: 0x2029FC0 Slot: 10
	public bool get_Focusable() { }

	// RVA: 0x2029FD0 Offset: 0x202A0D1 VA: 0x2029FD0 Slot: 11
	public void OnFocus() { }

	// RVA: 0x2029FE0 Offset: 0x202A0E1 VA: 0x2029FE0 Slot: 12
	public void OffFocus() { }

	// RVA: 0x2029FF0 Offset: 0x202A0F1 VA: 0x2029FF0 Slot: 13
	public FocusObjectType get_FocusObjectType() { }

	// RVA: 0x202A000 Offset: 0x202A101 VA: 0x202A000 Slot: 14
	public int get_FocusPriority() { }

	// RVA: 0x202A010 Offset: 0x202A111 VA: 0x202A010 Slot: 15
	public FocusPointType get_FocusPointType() { }

	// RVA: 0x202A020 Offset: 0x202A121 VA: 0x202A020 Slot: 16
	public ushort GetInteractionType() { }

	// RVA: 0x202A030 Offset: 0x202A131 VA: 0x202A030 Slot: 4
	public void DoInteraction(HumanController character) { }

	// RVA: 0x202A280 Offset: 0x202A381 VA: 0x202A280 Slot: 5
	public bool CanInteraction(HumanController character) { }

	// RVA: 0x202A290 Offset: 0x202A391 VA: 0x202A290 Slot: 8
	public string GetInteractionButtonHint() { }

	// RVA: 0x202A040 Offset: 0x202A141 VA: 0x202A040
	private void talk2Dragon() { }

	// RVA: 0x202A2F0 Offset: 0x202A3F1 VA: 0x202A2F0 Slot: 6
	public void DoInteraction(MonsterControllerBase character) { }

	// RVA: 0x202A300 Offset: 0x202A401 VA: 0x202A300 Slot: 7
	public bool CanInteraction(MonsterControllerBase character) { }

	// RVA: 0x202A310 Offset: 0x202A411 VA: 0x202A310
	private void Update() { }

	// RVA: 0x202A670 Offset: 0x202A771 VA: 0x202A670
	public void .ctor() { }

	// RVA: 0x202A6D0 Offset: 0x202A7D1 VA: 0x202A6D0 Slot: 17
	private GameObject FocusInterface.get_gameObject() { }

	// RVA: 0x202A6E0 Offset: 0x202A7E1 VA: 0x202A6E0 Slot: 18
	private Transform FocusInterface.get_transform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEDF0 Offset: 0x1AEEF1 VA: 0x1AEDF0
	// RVA: 0x202A6F0 Offset: 0x202A7F1 VA: 0x202A6F0
	private void <Update>b__21_0(AssetHandle<GameObject> obj) { }
}

