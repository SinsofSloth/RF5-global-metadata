public class UICanvasGroupAnimation : MonoBehaviour // TypeDefIndex: 8462
{
	// Fields
	private CanvasGroup canvasGroup; // 0x18
	private RectTransform rectTrans; // 0x20
	[SerializeField] // RVA: 0x16FC60 Offset: 0x16FD61 VA: 0x16FC60
	private float animTime; // 0x28
	private float roundAnimTime; // 0x2C
	[SerializeField] // RVA: 0x16FC70 Offset: 0x16FD71 VA: 0x16FC70
	private AnimationCurve fadeCurve; // 0x30
	[SerializeField] // RVA: 0x16FC80 Offset: 0x16FD81 VA: 0x16FC80
	private AnimationCurve slideCurve; // 0x38
	[SerializeField] // RVA: 0x16FC90 Offset: 0x16FD91 VA: 0x16FC90
	private Vector2 slideRange; // 0x40
	private Vector2 objectPos; // 0x48

	// Methods

	// RVA: 0x1F065E0 Offset: 0x1F066E1 VA: 0x1F065E0
	private void Awake() { }

	// RVA: 0x1F06690 Offset: 0x1F06791 VA: 0x1F06690
	private void OnEnable() { }

	// RVA: 0x1F06880 Offset: 0x1F06981 VA: 0x1F06880
	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A78A0 Offset: 0x1A79A1 VA: 0x1A78A0
	// RVA: 0x1F067F0 Offset: 0x1F068F1 VA: 0x1F067F0
	public IEnumerator OnSlideAnimation(bool _flag) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A7910 Offset: 0x1A7A11 VA: 0x1A7910
	// RVA: 0x1F069A0 Offset: 0x1F06AA1 VA: 0x1F069A0
	public IEnumerator OnRoundAnimation(UnityAction _first_call_back, CursorLinker _cursor) { }

	// RVA: 0x1F06A80 Offset: 0x1F06B81 VA: 0x1F06A80
	public void .ctor() { }
}

