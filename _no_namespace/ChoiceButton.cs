public class ChoiceButton : MonoBehaviour // TypeDefIndex: 8450
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x16FA20 Offset: 0x16FB21 VA: 0x16FA20
	private bool <IsButtonActive>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x16FA30 Offset: 0x16FB31 VA: 0x16FA30
	private float animTime; // 0x1C
	[SerializeField] // RVA: 0x16FA40 Offset: 0x16FB41 VA: 0x16FA40
	private AnimationCurve scaleCurve; // 0x20
	[SerializeField] // RVA: 0x16FA50 Offset: 0x16FB51 VA: 0x16FA50
	private AnimationCurve fadeCurve; // 0x28
	[SerializeField] // RVA: 0x16FA60 Offset: 0x16FB61 VA: 0x16FA60
	private Image focusedImage; // 0x30
	[SerializeField] // RVA: 0x16FA70 Offset: 0x16FB71 VA: 0x16FA70
	private UnityEvent action; // 0x38
	private UnityAction firstAction; // 0x40
	private EventTrigger eventTrigger; // 0x48
	private float curveRate; // 0x50
	private float curveSpeed; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x16FA80 Offset: 0x16FB81 VA: 0x16FA80
	private bool <isClicked>k__BackingField; // 0x58
	private bool isFocusing; // 0x59
	private float timeCount; // 0x5C
	private int loopRate; // 0x60

	// Properties
	public bool IsButtonActive { get; set; }
	protected bool isClicked { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A7620 Offset: 0x1A7721 VA: 0x1A7620
	// RVA: 0x1E60EA0 Offset: 0x1E60FA1 VA: 0x1E60EA0
	public bool get_IsButtonActive() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7630 Offset: 0x1A7731 VA: 0x1A7630
	// RVA: 0x1E60EB0 Offset: 0x1E60FB1 VA: 0x1E60EB0
	public void set_IsButtonActive(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7640 Offset: 0x1A7741 VA: 0x1A7640
	// RVA: 0x1E60EC0 Offset: 0x1E60FC1 VA: 0x1E60EC0
	protected bool get_isClicked() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7650 Offset: 0x1A7751 VA: 0x1A7650
	// RVA: 0x1E60ED0 Offset: 0x1E60FD1 VA: 0x1E60ED0
	private void set_isClicked(bool value) { }

	// RVA: 0x1E60EE0 Offset: 0x1E60FE1 VA: 0x1E60EE0
	private void Awake() { }

	// RVA: 0x1E61070 Offset: 0x1E61171 VA: 0x1E61070
	private void Update() { }

	// RVA: 0x1E61430 Offset: 0x1E61531 VA: 0x1E61430
	public void SetEvent(UnityAction _action) { }

	// RVA: 0x1E614C0 Offset: 0x1E615C1 VA: 0x1E614C0
	public void SetFirstEvent(UnityAction _action) { }

	// RVA: 0x1E614D0 Offset: 0x1E615D1 VA: 0x1E614D0 Slot: 4
	public virtual void DoButton() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A7660 Offset: 0x1A7761 VA: 0x1A7660
	// RVA: 0x1E61570 Offset: 0x1E61671 VA: 0x1E61570
	protected IEnumerator PlayButtonAnim() { }

	// RVA: 0x1E61620 Offset: 0x1E61721 VA: 0x1E61620
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A76D0 Offset: 0x1A77D1 VA: 0x1A76D0
	// RVA: 0x1E61640 Offset: 0x1E61741 VA: 0x1E61640
	private void <Awake>b__20_0(BaseEventData _data) { }
}

