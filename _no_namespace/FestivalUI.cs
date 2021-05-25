public class FestivalUI : MonoBehaviour // TypeDefIndex: 7369
{
	// Fields
	protected Animator animator; // 0x18
	[SerializeField] // RVA: 0x166000 Offset: 0x166101 VA: 0x166000
	private Image startImage; // 0x20
	[SerializeField] // RVA: 0x166010 Offset: 0x166111 VA: 0x166010
	private Image finishImage; // 0x28
	[SerializeField] // RVA: 0x166020 Offset: 0x166121 VA: 0x166020
	private FestivalCountDown countDownUI; // 0x30
	[SerializeField] // RVA: 0x166030 Offset: 0x166131 VA: 0x166030
	private FestivalNumScore scoreUI; // 0x38
	[SerializeField] // RVA: 0x166040 Offset: 0x166141 VA: 0x166040
	private FestivalNumScore timerUI; // 0x40

	// Methods

	// RVA: 0x1E23540 Offset: 0x1E23641 VA: 0x1E23540 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1E235E0 Offset: 0x1E236E1 VA: 0x1E235E0
	public void SetScoreUI(int _score) { }

	// RVA: 0x1E23600 Offset: 0x1E23701 VA: 0x1E23600
	public void SetTimer(float _time) { }

	// RVA: 0x1E1F2A0 Offset: 0x1E1F3A1 VA: 0x1E1F2A0
	public void ActiveTimer(bool _flag) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0460 Offset: 0x1A0561 VA: 0x1A0460
	// RVA: 0x1E23620 Offset: 0x1E23721 VA: 0x1E23620
	public IEnumerator OnStart() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A04D0 Offset: 0x1A05D1 VA: 0x1A04D0
	// RVA: 0x1E1EE90 Offset: 0x1E1EF91 VA: 0x1E1EE90
	public IEnumerator OnFinish() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A0540 Offset: 0x1A0641 VA: 0x1A0540
	// RVA: 0x1E23700 Offset: 0x1E23801 VA: 0x1E23700
	public IEnumerator OnCountDown(int _count) { }

	// RVA: 0x1E237C0 Offset: 0x1E238C1 VA: 0x1E237C0
	public void .ctor() { }
}

