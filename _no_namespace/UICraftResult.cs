public class UICraftResult : MonoBehaviour // TypeDefIndex: 8847
{
	// Fields
	[SerializeField] // RVA: 0x174380 Offset: 0x174481 VA: 0x174380
	private NonFocusButton skipButton; // 0x18
	[SerializeField] // RVA: 0x174390 Offset: 0x174491 VA: 0x174390
	private Image semiTrans; // 0x20
	[SerializeField] // RVA: 0x1743A0 Offset: 0x1744A1 VA: 0x1743A0
	private PlayableDirector[] resultTimeline; // 0x28
	private UICraftSuccess successTimeline; // 0x30
	private readonly int SUCCESS_ID; // 0x38
	private PlayableDirector failedTimeline; // 0x40
	private readonly int FAILED_ID; // 0x48
	private UICraftResult.CraftResultType resultType; // 0x4C
	private bool isPlaying; // 0x50

	// Methods

	// RVA: 0x1F0B150 Offset: 0x1F0B251 VA: 0x1F0B150
	private void Start() { }

	// RVA: 0x1F0B3E0 Offset: 0x1F0B4E1 VA: 0x1F0B3E0
	private void Update() { }

	// RVA: 0x1F0B510 Offset: 0x1F0B611 VA: 0x1F0B510
	private void OnDestroy() { }

	// RVA: 0x1F0A740 Offset: 0x1F0A841 VA: 0x1F0A740
	public void PlayResult(bool _success, UnityAction _call_back) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8900 Offset: 0x1A8A01 VA: 0x1A8900
	// RVA: 0x1F0B590 Offset: 0x1F0B691 VA: 0x1F0B590
	private IEnumerator PlayResultCoro(bool _success, UnityAction _call_back) { }

	// RVA: 0x1F0A700 Offset: 0x1F0A801 VA: 0x1F0A700
	public void CheckCraftResultType(CraftCategoryId _craft_id) { }

	// RVA: 0x1F0B670 Offset: 0x1F0B771 VA: 0x1F0B670
	public void CheckCraftResultType(bool _weapon) { }

	// RVA: 0x1F0B690 Offset: 0x1F0B791 VA: 0x1F0B690
	public void SetResultItem(ItemData _item) { }

	// RVA: 0x1F0A720 Offset: 0x1F0A821 VA: 0x1F0A720
	public void SetResultItem(ItemData _item, int _craft_num) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8970 Offset: 0x1A8A71 VA: 0x1A8970
	// RVA: 0x1F0B9A0 Offset: 0x1F0BAA1 VA: 0x1F0B9A0
	private IEnumerator PlaySemiTransAnim(bool _flag) { }

	// RVA: 0x1F0BA60 Offset: 0x1F0BB61 VA: 0x1F0BA60
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A89E0 Offset: 0x1A8AE1 VA: 0x1A89E0
	// RVA: 0x1F0BAE0 Offset: 0x1F0BBE1 VA: 0x1F0BAE0
	private void <Start>b__10_0(AssetHandle<GameObject> _handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A89F0 Offset: 0x1A8AF1 VA: 0x1A89F0
	// RVA: 0x1F0BBD0 Offset: 0x1F0BCD1 VA: 0x1F0BBD0
	private void <Start>b__10_1(AssetHandle<GameObject> _handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8A00 Offset: 0x1A8B01 VA: 0x1A8A00
	// RVA: 0x1F0BCC0 Offset: 0x1F0BDC1 VA: 0x1F0BCC0
	private void <Start>b__10_3() { }
}

