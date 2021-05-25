public class MoviePlayer : SingletonMonoBehaviour<MoviePlayer> // TypeDefIndex: 6824
{
	// Fields
	private string MoviePath; // 0x18
	[SerializeField] // RVA: 0x15FC10 Offset: 0x15FD11 VA: 0x15FC10
	private Camera MovieCamera; // 0x20
	[SerializeField] // RVA: 0x15FC20 Offset: 0x15FD21 VA: 0x15FC20
	private AudioListener MovieListener; // 0x28
	[SerializeField] // RVA: 0x15FC30 Offset: 0x15FD31 VA: 0x15FC30
	private Renderer MovieRenderer; // 0x30
	[SerializeField] // RVA: 0x15FC40 Offset: 0x15FD41 VA: 0x15FC40
	private Text Subtitle; // 0x38
	[SerializeField] // RVA: 0x15FC50 Offset: 0x15FD51 VA: 0x15FC50
	private GameObject ScreenObj; // 0x40
	[SerializeField] // RVA: 0x15FC60 Offset: 0x15FD61 VA: 0x15FC60
	private GameObject SubtitlesObj; // 0x48
	private SwitchVideoPlayer video; // 0x50
	private SwitchFMVTexture lumaTex; // 0x58
	private SwitchFMVTexture chromaTex; // 0x60
	private readonly float movieScreenAspectWidth; // 0x68
	private readonly float movieScreenAspectHeight; // 0x6C
	public bool isInitialized; // 0x70
	private List<MoviePlayer.SUBTITLEDATA> subTitleDatas; // 0x78
	private int displaySubtitleCount; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x15FC70 Offset: 0x15FD71 VA: 0x15FC70
	private bool <IsDisplaySubtitle>k__BackingField; // 0x84
	public UnityAction CreatedCallBack; // 0x88
	public UnityAction FirstFrameReadyCallBack; // 0x90
	public UnityAction LoopPointCallBack; // 0x98
	public UnityAction EndOfStreamCallBack; // 0xA0

	// Properties
	public bool IsDisplaySubtitle { get; set; }
	public bool Visible { get; set; }
	public bool EnableListener { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19D2F0 Offset: 0x19D3F1 VA: 0x19D2F0
	// RVA: 0x1CDBF40 Offset: 0x1CDC041 VA: 0x1CDBF40
	public bool get_IsDisplaySubtitle() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D300 Offset: 0x19D401 VA: 0x19D300
	// RVA: 0x1CDBF50 Offset: 0x1CDC051 VA: 0x1CDBF50
	public void set_IsDisplaySubtitle(bool value) { }

	// RVA: 0x1CDBF60 Offset: 0x1CDC061 VA: 0x1CDBF60
	public bool get_Visible() { }

	// RVA: 0x1CDBF80 Offset: 0x1CDC081 VA: 0x1CDBF80
	public void set_Visible(bool value) { }

	// RVA: 0x1CDBFF0 Offset: 0x1CDC0F1 VA: 0x1CDBFF0
	public bool get_EnableListener() { }

	// RVA: 0x1CDC010 Offset: 0x1CDC111 VA: 0x1CDC010
	public void set_EnableListener(bool value) { }

	// RVA: 0x1CDC030 Offset: 0x1CDC131 VA: 0x1CDC030
	public bool Initialize(int screenWidth = 1920, int screenHeight = 1080) { }

	// RVA: 0x1CDC350 Offset: 0x1CDC451 VA: 0x1CDC350
	public bool SetUp(string filepath, List<MoviePlayer.SUBTITLEDATA> subtitledatas, bool isLoop = False) { }

	// RVA: 0x1CDC610 Offset: 0x1CDC711 VA: 0x1CDC610
	public void Play(float jumptosecond = 0) { }

	// RVA: 0x1CDC730 Offset: 0x1CDC831 VA: 0x1CDC730
	public void Pause(bool value) { }

	// RVA: 0x1CDC750 Offset: 0x1CDC851 VA: 0x1CDC750
	public void Stop() { }

	// RVA: 0x1CDC7F0 Offset: 0x1CDC8F1 VA: 0x1CDC7F0
	public bool IsPlaying() { }

	// RVA: 0x1CDC870 Offset: 0x1CDC971 VA: 0x1CDC870
	public float GetTime() { }

	// RVA: 0x1CDC890 Offset: 0x1CDC991 VA: 0x1CDC890
	public float GetMovieTimeLength() { }

	// RVA: 0x1CDC8B0 Offset: 0x1CDC9B1 VA: 0x1CDC8B0
	public void Terminate() { }

	// RVA: 0x1CDC250 Offset: 0x1CDC351 VA: 0x1CDC250
	private static int Gcd(int a, int b) { }

	// RVA: 0x1CDC960 Offset: 0x1CDCA61 VA: 0x1CDC960
	private void loopPointMovieEvent() { }

	// RVA: 0x1CDC970 Offset: 0x1CDCA71 VA: 0x1CDC970
	private void OnMovieEvent(SwitchVideoPlayer.Event FMVevent) { }

	// RVA: 0x1CDCAB0 Offset: 0x1CDCBB1 VA: 0x1CDCAB0
	public void PlaySubtitle(int MovieId) { }

	// RVA: 0x1CDCB20 Offset: 0x1CDCC21 VA: 0x1CDCB20
	private void Start() { }

	// RVA: 0x1CDCB90 Offset: 0x1CDCC91 VA: 0x1CDCB90
	private void Update() { }

	// RVA: 0x1CDCCC0 Offset: 0x1CDCDC1 VA: 0x1CDCCC0
	private void OnPreRender() { }

	// RVA: 0x1CDCCE0 Offset: 0x1CDCDE1 VA: 0x1CDCCE0
	private void OnDestroy() { }

	// RVA: 0x1CDCCF0 Offset: 0x1CDCDF1 VA: 0x1CDCCF0
	public void .ctor() { }
}

