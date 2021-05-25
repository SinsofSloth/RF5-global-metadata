public class EventTimelineManager : SingletonMonoBehaviour<EventTimelineManager> // TypeDefIndex: 8341
{
	// Fields
	[SerializeField] // RVA: 0x16EF30 Offset: 0x16F031 VA: 0x16EF30
	private GameObject TimelineObject; // 0x18
	[SerializeField] // RVA: 0x16EF40 Offset: 0x16F041 VA: 0x16EF40
	public bool loopStart; // 0x20
	public float timeOfLoopEnd; // 0x24
	public TimeMachineCondition condition; // 0x28
	private TimelineControl _timelineControl; // 0x30
	public PlayableDirector director; // 0x38
	public bool pause; // 0x40
	public bool endOfDialogClose; // 0x41
	public int LoaderId; // 0x44
	private MovieRoomSkip MovieSkip; // 0x48
	private readonly int MOVIE_SKIP_ID; // 0x50
	private const Key ACTIVE_KEY = 2;
	public UnityEvent OnSetupEvent; // 0x58

	// Methods

	// RVA: 0x2078E40 Offset: 0x2078F41 VA: 0x2078E40
	private void Start() { }

	// RVA: 0x2078F00 Offset: 0x2079001 VA: 0x2078F00
	private void OnDestroy() { }

	// RVA: 0x2078F70 Offset: 0x2079071 VA: 0x2078F70
	public bool IsEndTimeLine() { }

	// RVA: 0x2079010 Offset: 0x2079111 VA: 0x2079010
	public void OnSetupTimeLine(string timelineName, bool IsEventScriptCalled = False) { }

	// RVA: 0x20792A0 Offset: 0x20793A1 VA: 0x20792A0
	public void OnStartTimeLine() { }

	// RVA: 0x20792B0 Offset: 0x20793B1 VA: 0x20792B0
	public void OnStopTimeLine() { }

	// RVA: 0x2079320 Offset: 0x2079421 VA: 0x2079320
	public void OnPlayableDirectorEnd() { }

	// RVA: 0x2079410 Offset: 0x2079511 VA: 0x2079410
	private void OnPlayableDirectorStopped(PlayableDirector aDirector) { }

	// RVA: 0x2079490 Offset: 0x2079591 VA: 0x2079490
	public void Pause(bool _endOfDialogClose) { }

	// RVA: 0x2079540 Offset: 0x2079641 VA: 0x2079540
	public void ResumeTimeline() { }

	// RVA: 0x2079690 Offset: 0x2079791 VA: 0x2079690
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6F90 Offset: 0x1A7091 VA: 0x1A6F90
	// RVA: 0x2079720 Offset: 0x2079821 VA: 0x2079720
	private void <Start>b__13_0(AssetHandle<GameObject> _handle) { }
}

