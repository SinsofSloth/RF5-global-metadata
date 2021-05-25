public class HUDButtonController : MonoBehaviour // TypeDefIndex: 8541
{
	// Fields
	private Image buttonImage; // 0x18
	[SerializeField] // RVA: 0x170520 Offset: 0x170621 VA: 0x170520
	private Sprite buttonSprite; // 0x20
	[SerializeField] // RVA: 0x170530 Offset: 0x170631 VA: 0x170530
	private Sprite clickedSprite; // 0x28
	private EventTrigger eventTrigger; // 0x30

	// Methods

	// RVA: 0x1EB7240 Offset: 0x1EB7341 VA: 0x1EB7240
	private void Awake() { }

	// RVA: 0x1EB7350 Offset: 0x1EB7451 VA: 0x1EB7350
	public void AddEvent(EventTriggerType _type, UnityAction _action) { }

	// RVA: 0x1EB74A0 Offset: 0x1EB75A1 VA: 0x1EB74A0
	private void OnClick(UnityAction _action) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A7B90 Offset: 0x1A7C91 VA: 0x1A7B90
	// RVA: 0x1EB7540 Offset: 0x1EB7641 VA: 0x1EB7540
	private IEnumerator InvokeAction(UnityAction _action) { }

	// RVA: 0x1EB7610 Offset: 0x1EB7711 VA: 0x1EB7610
	public void .ctor() { }
}

