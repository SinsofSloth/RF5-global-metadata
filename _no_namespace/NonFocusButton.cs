public class NonFocusButton : MonoBehaviour // TypeDefIndex: 8458
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16FBA0 Offset: 0x16FCA1 VA: 0x16FBA0
	private bool <EnableButton>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x16FBB0 Offset: 0x16FCB1 VA: 0x16FBB0
	private float animTime; // 0x1C
	[SerializeField] // RVA: 0x16FBC0 Offset: 0x16FCC1 VA: 0x16FBC0
	private float goalRate; // 0x20
	[SerializeField] // RVA: 0x16FBD0 Offset: 0x16FCD1 VA: 0x16FBD0
	private Image buttonImage; // 0x28
	[SerializeField] // RVA: 0x16FBE0 Offset: 0x16FCE1 VA: 0x16FBE0
	private Sprite buttonSprite; // 0x30
	[SerializeField] // RVA: 0x16FBF0 Offset: 0x16FCF1 VA: 0x16FBF0
	private Sprite clickedSprite; // 0x38
	[SerializeField] // RVA: 0x16FC00 Offset: 0x16FD01 VA: 0x16FC00
	private UnityEvent firstAction; // 0x40
	[SerializeField] // RVA: 0x16FC10 Offset: 0x16FD11 VA: 0x16FC10
	private UnityEvent action; // 0x48
	private EventTrigger eventTrigger; // 0x50
	private Vector2 startScale; // 0x58
	private Vector2 goalScale; // 0x60

	// Properties
	public bool EnableButton { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7780 Offset: 0x1A7881 VA: 0x1A7780
	// RVA: 0x1FB7080 Offset: 0x1FB7181 VA: 0x1FB7080
	public bool get_EnableButton() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7790 Offset: 0x1A7891 VA: 0x1A7790
	// RVA: 0x1FB7090 Offset: 0x1FB7191 VA: 0x1FB7090
	public void set_EnableButton(bool value) { }

	// RVA: 0x1FB70A0 Offset: 0x1FB71A1 VA: 0x1FB70A0
	private void Awake() { }

	// RVA: 0x1FB72E0 Offset: 0x1FB73E1 VA: 0x1FB72E0
	public void SetFirstEvent(UnityAction _action) { }

	// RVA: 0x1FB7370 Offset: 0x1FB7471 VA: 0x1FB7370
	public void SetEvent(UnityAction _action) { }

	// RVA: 0x1FB7400 Offset: 0x1FB7501 VA: 0x1FB7400
	public void DoButton() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A77A0 Offset: 0x1A78A1 VA: 0x1A77A0
	// RVA: 0x1FB74D0 Offset: 0x1FB75D1 VA: 0x1FB74D0
	private IEnumerator SwitchSprite() { }

	// RVA: 0x1FB7580 Offset: 0x1FB7681 VA: 0x1FB7580
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7810 Offset: 0x1A7911 VA: 0x1A7810
	// RVA: 0x1FB7620 Offset: 0x1FB7721 VA: 0x1FB7620
	private void <Awake>b__14_0(BaseEventData _data) { }
}

