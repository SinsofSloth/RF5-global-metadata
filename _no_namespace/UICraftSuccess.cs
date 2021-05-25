public class UICraftSuccess : MonoBehaviour // TypeDefIndex: 8853
{
	// Fields
	[SerializeField] // RVA: 0x1743B0 Offset: 0x1744B1 VA: 0x1743B0
	private Image resultImage; // 0x18
	[SerializeField] // RVA: 0x1743C0 Offset: 0x1744C1 VA: 0x1743C0
	private Text resultText; // 0x20
	[SerializeField] // RVA: 0x1743D0 Offset: 0x1744D1 VA: 0x1743D0
	private Image semiTrans; // 0x28
	private PlayableDirector playableDirector; // 0x30
	private UnityAction callBack; // 0x38

	// Methods

	// RVA: 0x1F0D110 Offset: 0x1F0D211 VA: 0x1F0D110
	private void Awake() { }

	// RVA: 0x1F0C4D0 Offset: 0x1F0C5D1 VA: 0x1F0C4D0
	public void Play(bool _dual_work = False, UnityAction _callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8A10 Offset: 0x1A8B11 VA: 0x1A8A10
	// RVA: 0x1F0D1A0 Offset: 0x1F0D2A1 VA: 0x1F0D1A0
	private IEnumerator PlayDualWorkResult() { }

	// RVA: 0x1F0BE50 Offset: 0x1F0BF51 VA: 0x1F0BE50
	public bool IsDone() { }

	// RVA: 0x1F0B6B0 Offset: 0x1F0B7B1 VA: 0x1F0B6B0
	public void SetResultItem(ItemData _item) { }

	// RVA: 0x1F0B800 Offset: 0x1F0B901 VA: 0x1F0B800
	public void SetResultItem(ItemData _item, int _craft_num) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8A80 Offset: 0x1A8B81 VA: 0x1A8A80
	// RVA: 0x1F0D250 Offset: 0x1F0D351 VA: 0x1F0D250
	private IEnumerator PlaySemiTransAnim(bool _flag) { }

	// RVA: 0x1F0D310 Offset: 0x1F0D411 VA: 0x1F0D310
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8AF0 Offset: 0x1A8BF1 VA: 0x1A8AF0
	// RVA: 0x1F0D320 Offset: 0x1F0D421 VA: 0x1F0D320
	private bool <PlayDualWorkResult>b__7_0() { }
}

