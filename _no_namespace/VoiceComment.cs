public class VoiceComment : UIScrollBoxBase // TypeDefIndex: 8893
{
	// Fields
	private readonly Vector3[] ICON_SCALE; // 0x68
	private const int CAST_MAX = 34;
	private UnityAction action; // 0x70
	[SerializeField] // RVA: 0x174930 Offset: 0x174A31 VA: 0x174930
	private GameObject castListObject; // 0x78
	[SerializeField] // RVA: 0x174940 Offset: 0x174A41 VA: 0x174940
	private VoicePlayingWindow playingWindow; // 0x80
	[SerializeField] // RVA: 0x174950 Offset: 0x174A51 VA: 0x174950
	private CursorControllerLite cursor; // 0x88
	[SerializeField] // RVA: 0x174960 Offset: 0x174A61 VA: 0x174960
	private List<Image> sdCharaImage; // 0x90
	[SerializeField] // RVA: 0x174970 Offset: 0x174A71 VA: 0x174970
	private List<VoiceComment.CharaSprite> sdCharaIconSprite; // 0x98
	[SerializeField] // RVA: 0x174980 Offset: 0x174A81 VA: 0x174980
	private ButtonHintMain buttonHint; // 0xA0
	private VoiceCommentDataTable voiceCommentDataTable; // 0xA8
	private bool isPlaying; // 0xB0
	private bool isFading; // 0xB1

	// Methods

	// RVA: 0x1CFE8F0 Offset: 0x1CFE9F1 VA: 0x1CFE8F0
	public void OpenWindow(UnityAction _call_back) { }

	// RVA: 0x1CFEA30 Offset: 0x1CFEB31 VA: 0x1CFEA30
	private void OnEnable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8DC0 Offset: 0x1A8EC1 VA: 0x1A8DC0
	// RVA: 0x1CFECE0 Offset: 0x1CFEDE1 VA: 0x1CFECE0
	private IEnumerator SetupButtonHint() { }

	// RVA: 0x1CFED90 Offset: 0x1CFEE91 VA: 0x1CFED90 Slot: 8
	protected override void Start() { }

	// RVA: 0x1CFEF90 Offset: 0x1CFF091 VA: 0x1CFEF90 Slot: 9
	protected override void Update() { }

	// RVA: 0x1CFF1D0 Offset: 0x1CFF2D1 VA: 0x1CFF1D0 Slot: 10
	protected override void OnDisable() { }

	// RVA: 0x1CFF1E0 Offset: 0x1CFF2E1 VA: 0x1CFF1E0
	private void OnDestroy() { }

	// RVA: 0x1CFF090 Offset: 0x1CFF191 VA: 0x1CFF090
	private void InputSubmit() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8E30 Offset: 0x1A8F31 VA: 0x1A8E30
	// RVA: 0x1CFF400 Offset: 0x1CFF501 VA: 0x1CFF400
	private IEnumerator PlayVoice() { }

	// RVA: 0x1CFF4B0 Offset: 0x1CFF5B1 VA: 0x1CFF4B0
	private void UpdateSDCharaSprite() { }

	// RVA: 0x1CFF830 Offset: 0x1CFF931 VA: 0x1CFF830
	private Sprite GetSDCharaSprite(VoiceComment.IconType _type) { }

	// RVA: 0x1CFF900 Offset: 0x1CFFA01 VA: 0x1CFF900
	public void OnSlotTouch(CastSlot _slot) { }

	// RVA: 0x1CFF350 Offset: 0x1CFF451 VA: 0x1CFF350
	public bool IsReleased(int _index) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8EA0 Offset: 0x1A8FA1 VA: 0x1A8EA0
	// RVA: 0x1CFEC60 Offset: 0x1CFED61 VA: 0x1CFEC60
	private IEnumerator StartFading() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8F10 Offset: 0x1A9011 VA: 0x1A8F10
	// RVA: 0x1CFFA00 Offset: 0x1CFFB01 VA: 0x1CFFA00
	private IEnumerator CharaSpriteFading(int _index) { }

	// RVA: 0x1CFFAC0 Offset: 0x1CFFBC1 VA: 0x1CFFAC0 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1CFFAD0 Offset: 0x1CFFBD1 VA: 0x1CFFAD0 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1CFFB70 Offset: 0x1CFFC71 VA: 0x1CFFB70 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1CFFB80 Offset: 0x1CFFC81 VA: 0x1CFFB80
	private void InvokeCallBack() { }

	// RVA: 0x1CFE930 Offset: 0x1CFEA31 VA: 0x1CFE930
	private void FadeOut(bool _flag) { }

	// RVA: 0x1CFFBE0 Offset: 0x1CFFCE1 VA: 0x1CFFBE0
	private void FadeIn(bool _flag) { }

	// RVA: 0x1CFFCE0 Offset: 0x1CFFDE1 VA: 0x1CFFCE0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8F80 Offset: 0x1A9081 VA: 0x1A8F80
	// RVA: 0x1CFFE50 Offset: 0x1CFFF51 VA: 0x1CFFE50
	private bool <SetupButtonHint>b__16_0() { }
}

