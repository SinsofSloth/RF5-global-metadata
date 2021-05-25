public class ChoiceImage : MonoBehaviour // TypeDefIndex: 8808
{
	// Fields
	[SerializeField] // RVA: 0x1739F0 Offset: 0x173AF1 VA: 0x1739F0
	private Text contentText; // 0x18
	[SerializeField] // RVA: 0x173A00 Offset: 0x173B01 VA: 0x173A00
	private Text ptText; // 0x20
	[SerializeField] // RVA: 0x173A10 Offset: 0x173B11 VA: 0x173A10
	private Image selectedImage; // 0x28
	[SerializeField] // RVA: 0x173A20 Offset: 0x173B21 VA: 0x173A20
	private Text selectedContentText; // 0x30
	[SerializeField] // RVA: 0x173A30 Offset: 0x173B31 VA: 0x173A30
	private Text selectedPtText; // 0x38
	[SerializeField] // RVA: 0x173A40 Offset: 0x173B41 VA: 0x173A40
	private Image finishImage; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x173A50 Offset: 0x173B51 VA: 0x173A50
	private bool <IsSelected>k__BackingField; // 0x48
	private UnityAction touchAction; // 0x50

	// Properties
	public bool IsSelected { get; set; }
	public RectTransform RectTransform { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A87B0 Offset: 0x1A88B1 VA: 0x1A87B0
	// RVA: 0x1E61A10 Offset: 0x1E61B11 VA: 0x1E61A10
	public bool get_IsSelected() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A87C0 Offset: 0x1A88C1 VA: 0x1A87C0
	// RVA: 0x1E61A20 Offset: 0x1E61B21 VA: 0x1E61A20
	private void set_IsSelected(bool value) { }

	// RVA: 0x1E61A30 Offset: 0x1E61B31 VA: 0x1E61A30
	public RectTransform get_RectTransform() { }

	// RVA: 0x1E61A90 Offset: 0x1E61B91 VA: 0x1E61A90
	private void Awake() { }

	// RVA: 0x1E61BB0 Offset: 0x1E61CB1 VA: 0x1E61BB0
	public void SetEvent(UnityAction _action) { }

	// RVA: 0x1E61BC0 Offset: 0x1E61CC1 VA: 0x1E61BC0
	private void OnTouch() { }

	// RVA: 0x1E61BE0 Offset: 0x1E61CE1 VA: 0x1E61BE0
	public void SetOnSelect(bool select) { }

	// RVA: 0x1E61D40 Offset: 0x1E61E41 VA: 0x1E61D40
	public void Finish() { }

	// RVA: 0x1E61D50 Offset: 0x1E61E51 VA: 0x1E61D50
	public void SetDetail(string text, string text2) { }

	// RVA: 0x1E61E90 Offset: 0x1E61F91 VA: 0x1E61E90
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A87D0 Offset: 0x1A88D1 VA: 0x1A87D0
	// RVA: 0x1E61EA0 Offset: 0x1E61FA1 VA: 0x1E61EA0
	private void <Awake>b__13_0(BaseEventData _data) { }
}

