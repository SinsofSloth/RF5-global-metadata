public class TimelineControl : MonoBehaviour // TypeDefIndex: 8375
{
	// Fields
	[SerializeField] // RVA: 0x16F2D0 Offset: 0x16F3D1 VA: 0x16F2D0
	private PlayableDirector playableDirector; // 0x18
	[SerializeField] // RVA: 0x16F2E0 Offset: 0x16F3E1 VA: 0x16F2E0
	private FieldSceneData FieldSceneData; // 0x20
	public Camera TimelineCamera; // 0x28
	private FxPro FxPro; // 0x30
	public Bloom Bloom; // 0x38
	[SpaceAttribute] // RVA: 0x16F2F0 Offset: 0x16F3F1 VA: 0x16F2F0
	[SerializeField] // RVA: 0x16F2F0 Offset: 0x16F3F1 VA: 0x16F2F0
	private TimelineControl.PlayingState _playingState; // 0x40
	private UnityAction _initAction; // 0x48
	private UnityAction _playAction; // 0x50
	private UnityAction _endAction; // 0x58
	private UnityAction _disableAction; // 0x60
	private bool _isInit; // 0x68

	// Properties
	public TimelineControl.PlayingState State { get; set; }

	// Methods

	// RVA: 0x1D224C0 Offset: 0x1D225C1 VA: 0x1D224C0
	public TimelineControl.PlayingState get_State() { }

	// RVA: 0x1D224D0 Offset: 0x1D225D1 VA: 0x1D224D0
	private void set_State(TimelineControl.PlayingState value) { }

	// RVA: 0x1D224E0 Offset: 0x1D225E1 VA: 0x1D224E0
	public void Init() { }

	// RVA: 0x1D22870 Offset: 0x1D22971 VA: 0x1D22870
	public void Play() { }

	// RVA: 0x1D22980 Offset: 0x1D22A81 VA: 0x1D22980
	public void Pause() { }

	// RVA: 0x1D229F0 Offset: 0x1D22AF1 VA: 0x1D229F0
	public void Resume() { }

	// RVA: 0x1D22A60 Offset: 0x1D22B61 VA: 0x1D22A60
	public void Stop() { }

	// RVA: 0x1D22B40 Offset: 0x1D22C41 VA: 0x1D22B40
	public void EndTimelineAddAction(UnityAction endCallback) { }

	// RVA: 0x1D22BD0 Offset: 0x1D22CD1 VA: 0x1D22BD0
	public void InitEventAddAction(UnityAction action) { }

	// RVA: 0x1D22C60 Offset: 0x1D22D61 VA: 0x1D22C60
	public void PlayEventAddAction(UnityAction action) { }

	// RVA: 0x1D22CF0 Offset: 0x1D22DF1 VA: 0x1D22CF0
	public void DisableEventAddAction(UnityAction action) { }

	// RVA: 0x1D22710 Offset: 0x1D22811 VA: 0x1D22710
	public void SetupActiveSceneCameraEffect() { }

	// RVA: 0x1D22D80 Offset: 0x1D22E81 VA: 0x1D22D80
	public void PlayBGM(BGMID bgmId) { }

	// RVA: 0x1D22D90 Offset: 0x1D22E91 VA: 0x1D22D90
	public void StopBGM(BGMID bgmId) { }

	// RVA: 0x1D22DA0 Offset: 0x1D22EA1 VA: 0x1D22DA0
	private void Awake() { }

	// RVA: 0x1D22DB0 Offset: 0x1D22EB1 VA: 0x1D22DB0
	private void Start() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A7320 Offset: 0x1A7421 VA: 0x1A7320
	// RVA: 0x1D22900 Offset: 0x1D22A01 VA: 0x1D22900
	private IEnumerator PlayAsync() { }

	// RVA: 0x1D22F00 Offset: 0x1D23001 VA: 0x1D22F00
	private void OnDisable() { }

	// RVA: 0x1D22FA0 Offset: 0x1D230A1 VA: 0x1D22FA0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A7390 Offset: 0x1A7491 VA: 0x1A7390
	// RVA: 0x1D22FB0 Offset: 0x1D230B1 VA: 0x1D22FB0
	private void <Init>b__15_0(PlayableDirector d) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A73A0 Offset: 0x1A74A1 VA: 0x1A73A0
	// RVA: 0x1D22FC0 Offset: 0x1D230C1 VA: 0x1D22FC0
	private bool <PlayAsync>b__29_0() { }
}

