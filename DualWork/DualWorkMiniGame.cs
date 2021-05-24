public class DualWorkMiniGame : SingletonMonoBehaviour<DualWorkMiniGame> // TypeDefIndex: 10389
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1816A0 Offset: 0x1817A1 VA: 0x1816A0
	private DualWorkSetup <DualWorkSetup>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1816B0 Offset: 0x1817B1 VA: 0x1816B0
	private DualWorkTimelineLinker <DualWorkTimelineLinker>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1816C0 Offset: 0x1817C1 VA: 0x1816C0
	private UIDualWork <UIDualWork>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1816D0 Offset: 0x1817D1 VA: 0x1816D0
	private Transform <CanvasTransform>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x1816E0 Offset: 0x1817E1 VA: 0x1816E0
	private Transform <ObjectTransform>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x1816F0 Offset: 0x1817F1 VA: 0x1816F0
	private ActorID <SubActor>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181700 Offset: 0x181801 VA: 0x181700
	private bool <IsMiniGame>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x181710 Offset: 0x181811 VA: 0x181710
	private bool <IsMiniGameSuccess>k__BackingField; // 0x45
	private readonly Dictionary<DualWorkType, Prefab> DualWorkTypeToAssetID; // 0x48
	private UnityAction<bool> EndCallBack; // 0x50
	private bool IsSwitchSPCBase; // 0x58
	private UICraftSuccess ResultWindow; // 0x60
	private DualWorkMiniGame.PushResult LastPushResult; // 0x68
	private float MiniGameTimeLimit; // 0x6C
	private int Count; // 0x70
	private int CurrentSynchroGauge; // 0x74
	private int SynchroGaugeMax; // 0x78
	private int SynchroGaugePerfect; // 0x7C
	private int SynchroGaugeNice; // 0x80
	private int SynchroGaugeBad; // 0x84
	private int SuccessGaugeBase; // 0x88
	[SerializeField] // RVA: 0x181720 Offset: 0x181821 VA: 0x181720
	private int CriticalGaugeBase; // 0x8C
	private float BarPosition; // 0x90
	private bool BarDirectionLeft; // 0x94
	private float SuccessGauge; // 0x98
	private float CriticalGauge; // 0x9C
	private float SuccessGauge_Rand_L; // 0xA0
	private float SuccessGauge_Rand_R; // 0xA4
	private float SuccessGauge_Position; // 0xA8
	private float CriticalGauge_Position; // 0xAC
	[SerializeField] // RVA: 0x181730 Offset: 0x181831 VA: 0x181730
	private float BarSpeed; // 0xB0
	private float CurrentTimeLimit; // 0xB4
	private float CurrentCoolTime; // 0xB8
	[SerializeField] // RVA: 0x181740 Offset: 0x181841 VA: 0x181740
	private float CoolTimeMax; // 0xBC

	// Properties
	private DualWorkSetup DualWorkSetup { get; set; }
	private DualWorkTimelineLinker DualWorkTimelineLinker { get; set; }
	private UIDualWork UIDualWork { get; set; }
	private Transform CanvasTransform { get; set; }
	private Transform ObjectTransform { get; set; }
	public ActorID SubActor { get; set; }
	public bool IsMiniGame { get; set; }
	public bool IsMiniGameSuccess { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEEC0 Offset: 0x1AEFC1 VA: 0x1AEEC0
	// RVA: 0x1CF9540 Offset: 0x1CF9641 VA: 0x1CF9540
	private DualWorkSetup get_DualWorkSetup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEED0 Offset: 0x1AEFD1 VA: 0x1AEED0
	// RVA: 0x1CF9550 Offset: 0x1CF9651 VA: 0x1CF9550
	private void set_DualWorkSetup(DualWorkSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEE0 Offset: 0x1AEFE1 VA: 0x1AEEE0
	// RVA: 0x1CF9560 Offset: 0x1CF9661 VA: 0x1CF9560
	private DualWorkTimelineLinker get_DualWorkTimelineLinker() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEF0 Offset: 0x1AEFF1 VA: 0x1AEEF0
	// RVA: 0x1CF9570 Offset: 0x1CF9671 VA: 0x1CF9570
	private void set_DualWorkTimelineLinker(DualWorkTimelineLinker value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF00 Offset: 0x1AF001 VA: 0x1AEF00
	// RVA: 0x1CF9580 Offset: 0x1CF9681 VA: 0x1CF9580
	private UIDualWork get_UIDualWork() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF10 Offset: 0x1AF011 VA: 0x1AEF10
	// RVA: 0x1CF9590 Offset: 0x1CF9691 VA: 0x1CF9590
	private void set_UIDualWork(UIDualWork value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF20 Offset: 0x1AF021 VA: 0x1AEF20
	// RVA: 0x1CF95A0 Offset: 0x1CF96A1 VA: 0x1CF95A0
	private Transform get_CanvasTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF30 Offset: 0x1AF031 VA: 0x1AEF30
	// RVA: 0x1CF95B0 Offset: 0x1CF96B1 VA: 0x1CF95B0
	private void set_CanvasTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF40 Offset: 0x1AF041 VA: 0x1AEF40
	// RVA: 0x1CF95C0 Offset: 0x1CF96C1 VA: 0x1CF95C0
	private Transform get_ObjectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF50 Offset: 0x1AF051 VA: 0x1AEF50
	// RVA: 0x1CF95D0 Offset: 0x1CF96D1 VA: 0x1CF95D0
	private void set_ObjectTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF60 Offset: 0x1AF061 VA: 0x1AEF60
	// RVA: 0x1CF95E0 Offset: 0x1CF96E1 VA: 0x1CF95E0
	public ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF70 Offset: 0x1AF071 VA: 0x1AEF70
	// RVA: 0x1CF95F0 Offset: 0x1CF96F1 VA: 0x1CF95F0
	public void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF80 Offset: 0x1AF081 VA: 0x1AEF80
	// RVA: 0x1CF9600 Offset: 0x1CF9701 VA: 0x1CF9600
	public bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF90 Offset: 0x1AF091 VA: 0x1AEF90
	// RVA: 0x1CF9610 Offset: 0x1CF9711 VA: 0x1CF9610
	public void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFA0 Offset: 0x1AF0A1 VA: 0x1AEFA0
	// RVA: 0x1CF9620 Offset: 0x1CF9721 VA: 0x1CF9620
	public bool get_IsMiniGameSuccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFB0 Offset: 0x1AF0B1 VA: 0x1AEFB0
	// RVA: 0x1CF9630 Offset: 0x1CF9731 VA: 0x1CF9630
	private void set_IsMiniGameSuccess(bool value) { }

	// RVA: 0x1CF77A0 Offset: 0x1CF78A1 VA: 0x1CF77A0
	public void PlayMiniGame(Transform objectTransform, ActorID actorID, int loveLevel, UnityAction<bool> endCallBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEFC0 Offset: 0x1AF0C1 VA: 0x1AEFC0
	// RVA: 0x1CF96D0 Offset: 0x1CF97D1 VA: 0x1CF96D0
	private IEnumerator LoadWithContinueMiniGame() { }

	// RVA: 0x1CF9750 Offset: 0x1CF9851 VA: 0x1CF9750
	private void LoadAssetsAfterStart() { }

	// RVA: 0x1CF9C10 Offset: 0x1CF9D11 VA: 0x1CF9C10
	private void StartTimeline(PlayableDirector director) { }

	// RVA: 0x1CF9C80 Offset: 0x1CF9D81 VA: 0x1CF9C80
	public void EndTimeline() { }

	// RVA: 0x1CFA530 Offset: 0x1CFA631 VA: 0x1CFA530
	public void Update() { }

	// RVA: 0x1CFA1B0 Offset: 0x1CFA2B1 VA: 0x1CFA1B0
	public void DispResultWindow() { }

	// RVA: 0x1CF9C90 Offset: 0x1CF9D91 VA: 0x1CF9C90
	private void EndDualwork() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF030 Offset: 0x1AF131 VA: 0x1AF030
	// RVA: 0x1CFA940 Offset: 0x1CFAA41 VA: 0x1CFA940
	private IEnumerator RebindNextFrame(Animator animator) { }

	// RVA: 0x1CFA9C0 Offset: 0x1CFAAC1 VA: 0x1CFA9C0
	private DualWorkMiniGame.PushResult CheckPush(float position) { }

	// RVA: 0x1CF9640 Offset: 0x1CF9741 VA: 0x1CF9640
	private void InitMiniGame(int loveLevel) { }

	// RVA: 0x1CFA570 Offset: 0x1CFA671 VA: 0x1CFA570
	private void UpdateMiniGame(float deltaTime) { }

	// RVA: 0x1CFAA10 Offset: 0x1CFAB11 VA: 0x1CFAA10
	private void OnMiniGameEnd(bool isSkip) { }

	// RVA: 0x1CFAB80 Offset: 0x1CFAC81 VA: 0x1CFAB80
	private void Start() { }

	// RVA: 0x1CFAC30 Offset: 0x1CFAD31 VA: 0x1CFAC30
	private void OnDestroy() { }

	// RVA: 0x1CFAD40 Offset: 0x1CFAE41 VA: 0x1CFAD40
	private void OnCarryDay(int day) { }

	// RVA: 0x1CFADF0 Offset: 0x1CFAEF1 VA: 0x1CFADF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0A0 Offset: 0x1AF1A1 VA: 0x1AF0A0
	// RVA: 0x1CFAF20 Offset: 0x1CFB021 VA: 0x1CFAF20
	private void <DispResultWindow>b__43_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0B0 Offset: 0x1AF1B1 VA: 0x1AF0B0
	// RVA: 0x1CFAF30 Offset: 0x1CFB031 VA: 0x1CFAF30
	private void <OnMiniGameEnd>b__71_0() { }
}

public class DualWorkMiniGame : SingletonMonoBehaviour<DualWorkMiniGame> // TypeDefIndex: 10389
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1816A0 Offset: 0x1817A1 VA: 0x1816A0
	private DualWorkSetup <DualWorkSetup>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1816B0 Offset: 0x1817B1 VA: 0x1816B0
	private DualWorkTimelineLinker <DualWorkTimelineLinker>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1816C0 Offset: 0x1817C1 VA: 0x1816C0
	private UIDualWork <UIDualWork>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1816D0 Offset: 0x1817D1 VA: 0x1816D0
	private Transform <CanvasTransform>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x1816E0 Offset: 0x1817E1 VA: 0x1816E0
	private Transform <ObjectTransform>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x1816F0 Offset: 0x1817F1 VA: 0x1816F0
	private ActorID <SubActor>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181700 Offset: 0x181801 VA: 0x181700
	private bool <IsMiniGame>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x181710 Offset: 0x181811 VA: 0x181710
	private bool <IsMiniGameSuccess>k__BackingField; // 0x45
	private readonly Dictionary<DualWorkType, Prefab> DualWorkTypeToAssetID; // 0x48
	private UnityAction<bool> EndCallBack; // 0x50
	private bool IsSwitchSPCBase; // 0x58
	private UICraftSuccess ResultWindow; // 0x60
	private DualWorkMiniGame.PushResult LastPushResult; // 0x68
	private float MiniGameTimeLimit; // 0x6C
	private int Count; // 0x70
	private int CurrentSynchroGauge; // 0x74
	private int SynchroGaugeMax; // 0x78
	private int SynchroGaugePerfect; // 0x7C
	private int SynchroGaugeNice; // 0x80
	private int SynchroGaugeBad; // 0x84
	private int SuccessGaugeBase; // 0x88
	[SerializeField] // RVA: 0x181720 Offset: 0x181821 VA: 0x181720
	private int CriticalGaugeBase; // 0x8C
	private float BarPosition; // 0x90
	private bool BarDirectionLeft; // 0x94
	private float SuccessGauge; // 0x98
	private float CriticalGauge; // 0x9C
	private float SuccessGauge_Rand_L; // 0xA0
	private float SuccessGauge_Rand_R; // 0xA4
	private float SuccessGauge_Position; // 0xA8
	private float CriticalGauge_Position; // 0xAC
	[SerializeField] // RVA: 0x181730 Offset: 0x181831 VA: 0x181730
	private float BarSpeed; // 0xB0
	private float CurrentTimeLimit; // 0xB4
	private float CurrentCoolTime; // 0xB8
	[SerializeField] // RVA: 0x181740 Offset: 0x181841 VA: 0x181740
	private float CoolTimeMax; // 0xBC

	// Properties
	private DualWorkSetup DualWorkSetup { get; set; }
	private DualWorkTimelineLinker DualWorkTimelineLinker { get; set; }
	private UIDualWork UIDualWork { get; set; }
	private Transform CanvasTransform { get; set; }
	private Transform ObjectTransform { get; set; }
	public ActorID SubActor { get; set; }
	public bool IsMiniGame { get; set; }
	public bool IsMiniGameSuccess { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEEC0 Offset: 0x1AEFC1 VA: 0x1AEEC0
	// RVA: 0x1CF9540 Offset: 0x1CF9641 VA: 0x1CF9540
	private DualWorkSetup get_DualWorkSetup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEED0 Offset: 0x1AEFD1 VA: 0x1AEED0
	// RVA: 0x1CF9550 Offset: 0x1CF9651 VA: 0x1CF9550
	private void set_DualWorkSetup(DualWorkSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEE0 Offset: 0x1AEFE1 VA: 0x1AEEE0
	// RVA: 0x1CF9560 Offset: 0x1CF9661 VA: 0x1CF9560
	private DualWorkTimelineLinker get_DualWorkTimelineLinker() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEF0 Offset: 0x1AEFF1 VA: 0x1AEEF0
	// RVA: 0x1CF9570 Offset: 0x1CF9671 VA: 0x1CF9570
	private void set_DualWorkTimelineLinker(DualWorkTimelineLinker value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF00 Offset: 0x1AF001 VA: 0x1AEF00
	// RVA: 0x1CF9580 Offset: 0x1CF9681 VA: 0x1CF9580
	private UIDualWork get_UIDualWork() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF10 Offset: 0x1AF011 VA: 0x1AEF10
	// RVA: 0x1CF9590 Offset: 0x1CF9691 VA: 0x1CF9590
	private void set_UIDualWork(UIDualWork value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF20 Offset: 0x1AF021 VA: 0x1AEF20
	// RVA: 0x1CF95A0 Offset: 0x1CF96A1 VA: 0x1CF95A0
	private Transform get_CanvasTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF30 Offset: 0x1AF031 VA: 0x1AEF30
	// RVA: 0x1CF95B0 Offset: 0x1CF96B1 VA: 0x1CF95B0
	private void set_CanvasTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF40 Offset: 0x1AF041 VA: 0x1AEF40
	// RVA: 0x1CF95C0 Offset: 0x1CF96C1 VA: 0x1CF95C0
	private Transform get_ObjectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF50 Offset: 0x1AF051 VA: 0x1AEF50
	// RVA: 0x1CF95D0 Offset: 0x1CF96D1 VA: 0x1CF95D0
	private void set_ObjectTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF60 Offset: 0x1AF061 VA: 0x1AEF60
	// RVA: 0x1CF95E0 Offset: 0x1CF96E1 VA: 0x1CF95E0
	public ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF70 Offset: 0x1AF071 VA: 0x1AEF70
	// RVA: 0x1CF95F0 Offset: 0x1CF96F1 VA: 0x1CF95F0
	public void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF80 Offset: 0x1AF081 VA: 0x1AEF80
	// RVA: 0x1CF9600 Offset: 0x1CF9701 VA: 0x1CF9600
	public bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF90 Offset: 0x1AF091 VA: 0x1AEF90
	// RVA: 0x1CF9610 Offset: 0x1CF9711 VA: 0x1CF9610
	public void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFA0 Offset: 0x1AF0A1 VA: 0x1AEFA0
	// RVA: 0x1CF9620 Offset: 0x1CF9721 VA: 0x1CF9620
	public bool get_IsMiniGameSuccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFB0 Offset: 0x1AF0B1 VA: 0x1AEFB0
	// RVA: 0x1CF9630 Offset: 0x1CF9731 VA: 0x1CF9630
	private void set_IsMiniGameSuccess(bool value) { }

	// RVA: 0x1CF77A0 Offset: 0x1CF78A1 VA: 0x1CF77A0
	public void PlayMiniGame(Transform objectTransform, ActorID actorID, int loveLevel, UnityAction<bool> endCallBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEFC0 Offset: 0x1AF0C1 VA: 0x1AEFC0
	// RVA: 0x1CF96D0 Offset: 0x1CF97D1 VA: 0x1CF96D0
	private IEnumerator LoadWithContinueMiniGame() { }

	// RVA: 0x1CF9750 Offset: 0x1CF9851 VA: 0x1CF9750
	private void LoadAssetsAfterStart() { }

	// RVA: 0x1CF9C10 Offset: 0x1CF9D11 VA: 0x1CF9C10
	private void StartTimeline(PlayableDirector director) { }

	// RVA: 0x1CF9C80 Offset: 0x1CF9D81 VA: 0x1CF9C80
	public void EndTimeline() { }

	// RVA: 0x1CFA530 Offset: 0x1CFA631 VA: 0x1CFA530
	public void Update() { }

	// RVA: 0x1CFA1B0 Offset: 0x1CFA2B1 VA: 0x1CFA1B0
	public void DispResultWindow() { }

	// RVA: 0x1CF9C90 Offset: 0x1CF9D91 VA: 0x1CF9C90
	private void EndDualwork() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF030 Offset: 0x1AF131 VA: 0x1AF030
	// RVA: 0x1CFA940 Offset: 0x1CFAA41 VA: 0x1CFA940
	private IEnumerator RebindNextFrame(Animator animator) { }

	// RVA: 0x1CFA9C0 Offset: 0x1CFAAC1 VA: 0x1CFA9C0
	private DualWorkMiniGame.PushResult CheckPush(float position) { }

	// RVA: 0x1CF9640 Offset: 0x1CF9741 VA: 0x1CF9640
	private void InitMiniGame(int loveLevel) { }

	// RVA: 0x1CFA570 Offset: 0x1CFA671 VA: 0x1CFA570
	private void UpdateMiniGame(float deltaTime) { }

	// RVA: 0x1CFAA10 Offset: 0x1CFAB11 VA: 0x1CFAA10
	private void OnMiniGameEnd(bool isSkip) { }

	// RVA: 0x1CFAB80 Offset: 0x1CFAC81 VA: 0x1CFAB80
	private void Start() { }

	// RVA: 0x1CFAC30 Offset: 0x1CFAD31 VA: 0x1CFAC30
	private void OnDestroy() { }

	// RVA: 0x1CFAD40 Offset: 0x1CFAE41 VA: 0x1CFAD40
	private void OnCarryDay(int day) { }

	// RVA: 0x1CFADF0 Offset: 0x1CFAEF1 VA: 0x1CFADF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0A0 Offset: 0x1AF1A1 VA: 0x1AF0A0
	// RVA: 0x1CFAF20 Offset: 0x1CFB021 VA: 0x1CFAF20
	private void <DispResultWindow>b__43_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0B0 Offset: 0x1AF1B1 VA: 0x1AF0B0
	// RVA: 0x1CFAF30 Offset: 0x1CFB031 VA: 0x1CFAF30
	private void <OnMiniGameEnd>b__71_0() { }
}

public class DualWorkMiniGame : SingletonMonoBehaviour<DualWorkMiniGame> // TypeDefIndex: 10389
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1816A0 Offset: 0x1817A1 VA: 0x1816A0
	private DualWorkSetup <DualWorkSetup>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1816B0 Offset: 0x1817B1 VA: 0x1816B0
	private DualWorkTimelineLinker <DualWorkTimelineLinker>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1816C0 Offset: 0x1817C1 VA: 0x1816C0
	private UIDualWork <UIDualWork>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1816D0 Offset: 0x1817D1 VA: 0x1816D0
	private Transform <CanvasTransform>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x1816E0 Offset: 0x1817E1 VA: 0x1816E0
	private Transform <ObjectTransform>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x1816F0 Offset: 0x1817F1 VA: 0x1816F0
	private ActorID <SubActor>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181700 Offset: 0x181801 VA: 0x181700
	private bool <IsMiniGame>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x181710 Offset: 0x181811 VA: 0x181710
	private bool <IsMiniGameSuccess>k__BackingField; // 0x45
	private readonly Dictionary<DualWorkType, Prefab> DualWorkTypeToAssetID; // 0x48
	private UnityAction<bool> EndCallBack; // 0x50
	private bool IsSwitchSPCBase; // 0x58
	private UICraftSuccess ResultWindow; // 0x60
	private DualWorkMiniGame.PushResult LastPushResult; // 0x68
	private float MiniGameTimeLimit; // 0x6C
	private int Count; // 0x70
	private int CurrentSynchroGauge; // 0x74
	private int SynchroGaugeMax; // 0x78
	private int SynchroGaugePerfect; // 0x7C
	private int SynchroGaugeNice; // 0x80
	private int SynchroGaugeBad; // 0x84
	private int SuccessGaugeBase; // 0x88
	[SerializeField] // RVA: 0x181720 Offset: 0x181821 VA: 0x181720
	private int CriticalGaugeBase; // 0x8C
	private float BarPosition; // 0x90
	private bool BarDirectionLeft; // 0x94
	private float SuccessGauge; // 0x98
	private float CriticalGauge; // 0x9C
	private float SuccessGauge_Rand_L; // 0xA0
	private float SuccessGauge_Rand_R; // 0xA4
	private float SuccessGauge_Position; // 0xA8
	private float CriticalGauge_Position; // 0xAC
	[SerializeField] // RVA: 0x181730 Offset: 0x181831 VA: 0x181730
	private float BarSpeed; // 0xB0
	private float CurrentTimeLimit; // 0xB4
	private float CurrentCoolTime; // 0xB8
	[SerializeField] // RVA: 0x181740 Offset: 0x181841 VA: 0x181740
	private float CoolTimeMax; // 0xBC

	// Properties
	private DualWorkSetup DualWorkSetup { get; set; }
	private DualWorkTimelineLinker DualWorkTimelineLinker { get; set; }
	private UIDualWork UIDualWork { get; set; }
	private Transform CanvasTransform { get; set; }
	private Transform ObjectTransform { get; set; }
	public ActorID SubActor { get; set; }
	public bool IsMiniGame { get; set; }
	public bool IsMiniGameSuccess { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEEC0 Offset: 0x1AEFC1 VA: 0x1AEEC0
	// RVA: 0x1CF9540 Offset: 0x1CF9641 VA: 0x1CF9540
	private DualWorkSetup get_DualWorkSetup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEED0 Offset: 0x1AEFD1 VA: 0x1AEED0
	// RVA: 0x1CF9550 Offset: 0x1CF9651 VA: 0x1CF9550
	private void set_DualWorkSetup(DualWorkSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEE0 Offset: 0x1AEFE1 VA: 0x1AEEE0
	// RVA: 0x1CF9560 Offset: 0x1CF9661 VA: 0x1CF9560
	private DualWorkTimelineLinker get_DualWorkTimelineLinker() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEF0 Offset: 0x1AEFF1 VA: 0x1AEEF0
	// RVA: 0x1CF9570 Offset: 0x1CF9671 VA: 0x1CF9570
	private void set_DualWorkTimelineLinker(DualWorkTimelineLinker value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF00 Offset: 0x1AF001 VA: 0x1AEF00
	// RVA: 0x1CF9580 Offset: 0x1CF9681 VA: 0x1CF9580
	private UIDualWork get_UIDualWork() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF10 Offset: 0x1AF011 VA: 0x1AEF10
	// RVA: 0x1CF9590 Offset: 0x1CF9691 VA: 0x1CF9590
	private void set_UIDualWork(UIDualWork value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF20 Offset: 0x1AF021 VA: 0x1AEF20
	// RVA: 0x1CF95A0 Offset: 0x1CF96A1 VA: 0x1CF95A0
	private Transform get_CanvasTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF30 Offset: 0x1AF031 VA: 0x1AEF30
	// RVA: 0x1CF95B0 Offset: 0x1CF96B1 VA: 0x1CF95B0
	private void set_CanvasTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF40 Offset: 0x1AF041 VA: 0x1AEF40
	// RVA: 0x1CF95C0 Offset: 0x1CF96C1 VA: 0x1CF95C0
	private Transform get_ObjectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF50 Offset: 0x1AF051 VA: 0x1AEF50
	// RVA: 0x1CF95D0 Offset: 0x1CF96D1 VA: 0x1CF95D0
	private void set_ObjectTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF60 Offset: 0x1AF061 VA: 0x1AEF60
	// RVA: 0x1CF95E0 Offset: 0x1CF96E1 VA: 0x1CF95E0
	public ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF70 Offset: 0x1AF071 VA: 0x1AEF70
	// RVA: 0x1CF95F0 Offset: 0x1CF96F1 VA: 0x1CF95F0
	public void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF80 Offset: 0x1AF081 VA: 0x1AEF80
	// RVA: 0x1CF9600 Offset: 0x1CF9701 VA: 0x1CF9600
	public bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF90 Offset: 0x1AF091 VA: 0x1AEF90
	// RVA: 0x1CF9610 Offset: 0x1CF9711 VA: 0x1CF9610
	public void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFA0 Offset: 0x1AF0A1 VA: 0x1AEFA0
	// RVA: 0x1CF9620 Offset: 0x1CF9721 VA: 0x1CF9620
	public bool get_IsMiniGameSuccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFB0 Offset: 0x1AF0B1 VA: 0x1AEFB0
	// RVA: 0x1CF9630 Offset: 0x1CF9731 VA: 0x1CF9630
	private void set_IsMiniGameSuccess(bool value) { }

	// RVA: 0x1CF77A0 Offset: 0x1CF78A1 VA: 0x1CF77A0
	public void PlayMiniGame(Transform objectTransform, ActorID actorID, int loveLevel, UnityAction<bool> endCallBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEFC0 Offset: 0x1AF0C1 VA: 0x1AEFC0
	// RVA: 0x1CF96D0 Offset: 0x1CF97D1 VA: 0x1CF96D0
	private IEnumerator LoadWithContinueMiniGame() { }

	// RVA: 0x1CF9750 Offset: 0x1CF9851 VA: 0x1CF9750
	private void LoadAssetsAfterStart() { }

	// RVA: 0x1CF9C10 Offset: 0x1CF9D11 VA: 0x1CF9C10
	private void StartTimeline(PlayableDirector director) { }

	// RVA: 0x1CF9C80 Offset: 0x1CF9D81 VA: 0x1CF9C80
	public void EndTimeline() { }

	// RVA: 0x1CFA530 Offset: 0x1CFA631 VA: 0x1CFA530
	public void Update() { }

	// RVA: 0x1CFA1B0 Offset: 0x1CFA2B1 VA: 0x1CFA1B0
	public void DispResultWindow() { }

	// RVA: 0x1CF9C90 Offset: 0x1CF9D91 VA: 0x1CF9C90
	private void EndDualwork() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF030 Offset: 0x1AF131 VA: 0x1AF030
	// RVA: 0x1CFA940 Offset: 0x1CFAA41 VA: 0x1CFA940
	private IEnumerator RebindNextFrame(Animator animator) { }

	// RVA: 0x1CFA9C0 Offset: 0x1CFAAC1 VA: 0x1CFA9C0
	private DualWorkMiniGame.PushResult CheckPush(float position) { }

	// RVA: 0x1CF9640 Offset: 0x1CF9741 VA: 0x1CF9640
	private void InitMiniGame(int loveLevel) { }

	// RVA: 0x1CFA570 Offset: 0x1CFA671 VA: 0x1CFA570
	private void UpdateMiniGame(float deltaTime) { }

	// RVA: 0x1CFAA10 Offset: 0x1CFAB11 VA: 0x1CFAA10
	private void OnMiniGameEnd(bool isSkip) { }

	// RVA: 0x1CFAB80 Offset: 0x1CFAC81 VA: 0x1CFAB80
	private void Start() { }

	// RVA: 0x1CFAC30 Offset: 0x1CFAD31 VA: 0x1CFAC30
	private void OnDestroy() { }

	// RVA: 0x1CFAD40 Offset: 0x1CFAE41 VA: 0x1CFAD40
	private void OnCarryDay(int day) { }

	// RVA: 0x1CFADF0 Offset: 0x1CFAEF1 VA: 0x1CFADF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0A0 Offset: 0x1AF1A1 VA: 0x1AF0A0
	// RVA: 0x1CFAF20 Offset: 0x1CFB021 VA: 0x1CFAF20
	private void <DispResultWindow>b__43_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0B0 Offset: 0x1AF1B1 VA: 0x1AF0B0
	// RVA: 0x1CFAF30 Offset: 0x1CFB031 VA: 0x1CFAF30
	private void <OnMiniGameEnd>b__71_0() { }
}

public class DualWorkMiniGame : SingletonMonoBehaviour<DualWorkMiniGame> // TypeDefIndex: 10389
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1816A0 Offset: 0x1817A1 VA: 0x1816A0
	private DualWorkSetup <DualWorkSetup>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1816B0 Offset: 0x1817B1 VA: 0x1816B0
	private DualWorkTimelineLinker <DualWorkTimelineLinker>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1816C0 Offset: 0x1817C1 VA: 0x1816C0
	private UIDualWork <UIDualWork>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1816D0 Offset: 0x1817D1 VA: 0x1816D0
	private Transform <CanvasTransform>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x1816E0 Offset: 0x1817E1 VA: 0x1816E0
	private Transform <ObjectTransform>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x1816F0 Offset: 0x1817F1 VA: 0x1816F0
	private ActorID <SubActor>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181700 Offset: 0x181801 VA: 0x181700
	private bool <IsMiniGame>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x181710 Offset: 0x181811 VA: 0x181710
	private bool <IsMiniGameSuccess>k__BackingField; // 0x45
	private readonly Dictionary<DualWorkType, Prefab> DualWorkTypeToAssetID; // 0x48
	private UnityAction<bool> EndCallBack; // 0x50
	private bool IsSwitchSPCBase; // 0x58
	private UICraftSuccess ResultWindow; // 0x60
	private DualWorkMiniGame.PushResult LastPushResult; // 0x68
	private float MiniGameTimeLimit; // 0x6C
	private int Count; // 0x70
	private int CurrentSynchroGauge; // 0x74
	private int SynchroGaugeMax; // 0x78
	private int SynchroGaugePerfect; // 0x7C
	private int SynchroGaugeNice; // 0x80
	private int SynchroGaugeBad; // 0x84
	private int SuccessGaugeBase; // 0x88
	[SerializeField] // RVA: 0x181720 Offset: 0x181821 VA: 0x181720
	private int CriticalGaugeBase; // 0x8C
	private float BarPosition; // 0x90
	private bool BarDirectionLeft; // 0x94
	private float SuccessGauge; // 0x98
	private float CriticalGauge; // 0x9C
	private float SuccessGauge_Rand_L; // 0xA0
	private float SuccessGauge_Rand_R; // 0xA4
	private float SuccessGauge_Position; // 0xA8
	private float CriticalGauge_Position; // 0xAC
	[SerializeField] // RVA: 0x181730 Offset: 0x181831 VA: 0x181730
	private float BarSpeed; // 0xB0
	private float CurrentTimeLimit; // 0xB4
	private float CurrentCoolTime; // 0xB8
	[SerializeField] // RVA: 0x181740 Offset: 0x181841 VA: 0x181740
	private float CoolTimeMax; // 0xBC

	// Properties
	private DualWorkSetup DualWorkSetup { get; set; }
	private DualWorkTimelineLinker DualWorkTimelineLinker { get; set; }
	private UIDualWork UIDualWork { get; set; }
	private Transform CanvasTransform { get; set; }
	private Transform ObjectTransform { get; set; }
	public ActorID SubActor { get; set; }
	public bool IsMiniGame { get; set; }
	public bool IsMiniGameSuccess { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEEC0 Offset: 0x1AEFC1 VA: 0x1AEEC0
	// RVA: 0x1CF9540 Offset: 0x1CF9641 VA: 0x1CF9540
	private DualWorkSetup get_DualWorkSetup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEED0 Offset: 0x1AEFD1 VA: 0x1AEED0
	// RVA: 0x1CF9550 Offset: 0x1CF9651 VA: 0x1CF9550
	private void set_DualWorkSetup(DualWorkSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEE0 Offset: 0x1AEFE1 VA: 0x1AEEE0
	// RVA: 0x1CF9560 Offset: 0x1CF9661 VA: 0x1CF9560
	private DualWorkTimelineLinker get_DualWorkTimelineLinker() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEF0 Offset: 0x1AEFF1 VA: 0x1AEEF0
	// RVA: 0x1CF9570 Offset: 0x1CF9671 VA: 0x1CF9570
	private void set_DualWorkTimelineLinker(DualWorkTimelineLinker value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF00 Offset: 0x1AF001 VA: 0x1AEF00
	// RVA: 0x1CF9580 Offset: 0x1CF9681 VA: 0x1CF9580
	private UIDualWork get_UIDualWork() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF10 Offset: 0x1AF011 VA: 0x1AEF10
	// RVA: 0x1CF9590 Offset: 0x1CF9691 VA: 0x1CF9590
	private void set_UIDualWork(UIDualWork value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF20 Offset: 0x1AF021 VA: 0x1AEF20
	// RVA: 0x1CF95A0 Offset: 0x1CF96A1 VA: 0x1CF95A0
	private Transform get_CanvasTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF30 Offset: 0x1AF031 VA: 0x1AEF30
	// RVA: 0x1CF95B0 Offset: 0x1CF96B1 VA: 0x1CF95B0
	private void set_CanvasTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF40 Offset: 0x1AF041 VA: 0x1AEF40
	// RVA: 0x1CF95C0 Offset: 0x1CF96C1 VA: 0x1CF95C0
	private Transform get_ObjectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF50 Offset: 0x1AF051 VA: 0x1AEF50
	// RVA: 0x1CF95D0 Offset: 0x1CF96D1 VA: 0x1CF95D0
	private void set_ObjectTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF60 Offset: 0x1AF061 VA: 0x1AEF60
	// RVA: 0x1CF95E0 Offset: 0x1CF96E1 VA: 0x1CF95E0
	public ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF70 Offset: 0x1AF071 VA: 0x1AEF70
	// RVA: 0x1CF95F0 Offset: 0x1CF96F1 VA: 0x1CF95F0
	public void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF80 Offset: 0x1AF081 VA: 0x1AEF80
	// RVA: 0x1CF9600 Offset: 0x1CF9701 VA: 0x1CF9600
	public bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF90 Offset: 0x1AF091 VA: 0x1AEF90
	// RVA: 0x1CF9610 Offset: 0x1CF9711 VA: 0x1CF9610
	public void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFA0 Offset: 0x1AF0A1 VA: 0x1AEFA0
	// RVA: 0x1CF9620 Offset: 0x1CF9721 VA: 0x1CF9620
	public bool get_IsMiniGameSuccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFB0 Offset: 0x1AF0B1 VA: 0x1AEFB0
	// RVA: 0x1CF9630 Offset: 0x1CF9731 VA: 0x1CF9630
	private void set_IsMiniGameSuccess(bool value) { }

	// RVA: 0x1CF77A0 Offset: 0x1CF78A1 VA: 0x1CF77A0
	public void PlayMiniGame(Transform objectTransform, ActorID actorID, int loveLevel, UnityAction<bool> endCallBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEFC0 Offset: 0x1AF0C1 VA: 0x1AEFC0
	// RVA: 0x1CF96D0 Offset: 0x1CF97D1 VA: 0x1CF96D0
	private IEnumerator LoadWithContinueMiniGame() { }

	// RVA: 0x1CF9750 Offset: 0x1CF9851 VA: 0x1CF9750
	private void LoadAssetsAfterStart() { }

	// RVA: 0x1CF9C10 Offset: 0x1CF9D11 VA: 0x1CF9C10
	private void StartTimeline(PlayableDirector director) { }

	// RVA: 0x1CF9C80 Offset: 0x1CF9D81 VA: 0x1CF9C80
	public void EndTimeline() { }

	// RVA: 0x1CFA530 Offset: 0x1CFA631 VA: 0x1CFA530
	public void Update() { }

	// RVA: 0x1CFA1B0 Offset: 0x1CFA2B1 VA: 0x1CFA1B0
	public void DispResultWindow() { }

	// RVA: 0x1CF9C90 Offset: 0x1CF9D91 VA: 0x1CF9C90
	private void EndDualwork() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF030 Offset: 0x1AF131 VA: 0x1AF030
	// RVA: 0x1CFA940 Offset: 0x1CFAA41 VA: 0x1CFA940
	private IEnumerator RebindNextFrame(Animator animator) { }

	// RVA: 0x1CFA9C0 Offset: 0x1CFAAC1 VA: 0x1CFA9C0
	private DualWorkMiniGame.PushResult CheckPush(float position) { }

	// RVA: 0x1CF9640 Offset: 0x1CF9741 VA: 0x1CF9640
	private void InitMiniGame(int loveLevel) { }

	// RVA: 0x1CFA570 Offset: 0x1CFA671 VA: 0x1CFA570
	private void UpdateMiniGame(float deltaTime) { }

	// RVA: 0x1CFAA10 Offset: 0x1CFAB11 VA: 0x1CFAA10
	private void OnMiniGameEnd(bool isSkip) { }

	// RVA: 0x1CFAB80 Offset: 0x1CFAC81 VA: 0x1CFAB80
	private void Start() { }

	// RVA: 0x1CFAC30 Offset: 0x1CFAD31 VA: 0x1CFAC30
	private void OnDestroy() { }

	// RVA: 0x1CFAD40 Offset: 0x1CFAE41 VA: 0x1CFAD40
	private void OnCarryDay(int day) { }

	// RVA: 0x1CFADF0 Offset: 0x1CFAEF1 VA: 0x1CFADF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0A0 Offset: 0x1AF1A1 VA: 0x1AF0A0
	// RVA: 0x1CFAF20 Offset: 0x1CFB021 VA: 0x1CFAF20
	private void <DispResultWindow>b__43_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0B0 Offset: 0x1AF1B1 VA: 0x1AF0B0
	// RVA: 0x1CFAF30 Offset: 0x1CFB031 VA: 0x1CFAF30
	private void <OnMiniGameEnd>b__71_0() { }
}

public class DualWorkMiniGame : SingletonMonoBehaviour<DualWorkMiniGame> // TypeDefIndex: 10389
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x1816A0 Offset: 0x1817A1 VA: 0x1816A0
	private DualWorkSetup <DualWorkSetup>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x1816B0 Offset: 0x1817B1 VA: 0x1816B0
	private DualWorkTimelineLinker <DualWorkTimelineLinker>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x1816C0 Offset: 0x1817C1 VA: 0x1816C0
	private UIDualWork <UIDualWork>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x1816D0 Offset: 0x1817D1 VA: 0x1816D0
	private Transform <CanvasTransform>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x1816E0 Offset: 0x1817E1 VA: 0x1816E0
	private Transform <ObjectTransform>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x1816F0 Offset: 0x1817F1 VA: 0x1816F0
	private ActorID <SubActor>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x181700 Offset: 0x181801 VA: 0x181700
	private bool <IsMiniGame>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x181710 Offset: 0x181811 VA: 0x181710
	private bool <IsMiniGameSuccess>k__BackingField; // 0x45
	private readonly Dictionary<DualWorkType, Prefab> DualWorkTypeToAssetID; // 0x48
	private UnityAction<bool> EndCallBack; // 0x50
	private bool IsSwitchSPCBase; // 0x58
	private UICraftSuccess ResultWindow; // 0x60
	private DualWorkMiniGame.PushResult LastPushResult; // 0x68
	private float MiniGameTimeLimit; // 0x6C
	private int Count; // 0x70
	private int CurrentSynchroGauge; // 0x74
	private int SynchroGaugeMax; // 0x78
	private int SynchroGaugePerfect; // 0x7C
	private int SynchroGaugeNice; // 0x80
	private int SynchroGaugeBad; // 0x84
	private int SuccessGaugeBase; // 0x88
	[SerializeField] // RVA: 0x181720 Offset: 0x181821 VA: 0x181720
	private int CriticalGaugeBase; // 0x8C
	private float BarPosition; // 0x90
	private bool BarDirectionLeft; // 0x94
	private float SuccessGauge; // 0x98
	private float CriticalGauge; // 0x9C
	private float SuccessGauge_Rand_L; // 0xA0
	private float SuccessGauge_Rand_R; // 0xA4
	private float SuccessGauge_Position; // 0xA8
	private float CriticalGauge_Position; // 0xAC
	[SerializeField] // RVA: 0x181730 Offset: 0x181831 VA: 0x181730
	private float BarSpeed; // 0xB0
	private float CurrentTimeLimit; // 0xB4
	private float CurrentCoolTime; // 0xB8
	[SerializeField] // RVA: 0x181740 Offset: 0x181841 VA: 0x181740
	private float CoolTimeMax; // 0xBC

	// Properties
	private DualWorkSetup DualWorkSetup { get; set; }
	private DualWorkTimelineLinker DualWorkTimelineLinker { get; set; }
	private UIDualWork UIDualWork { get; set; }
	private Transform CanvasTransform { get; set; }
	private Transform ObjectTransform { get; set; }
	public ActorID SubActor { get; set; }
	public bool IsMiniGame { get; set; }
	public bool IsMiniGameSuccess { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1AEEC0 Offset: 0x1AEFC1 VA: 0x1AEEC0
	// RVA: 0x1CF9540 Offset: 0x1CF9641 VA: 0x1CF9540
	private DualWorkSetup get_DualWorkSetup() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEED0 Offset: 0x1AEFD1 VA: 0x1AEED0
	// RVA: 0x1CF9550 Offset: 0x1CF9651 VA: 0x1CF9550
	private void set_DualWorkSetup(DualWorkSetup value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEE0 Offset: 0x1AEFE1 VA: 0x1AEEE0
	// RVA: 0x1CF9560 Offset: 0x1CF9661 VA: 0x1CF9560
	private DualWorkTimelineLinker get_DualWorkTimelineLinker() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEEF0 Offset: 0x1AEFF1 VA: 0x1AEEF0
	// RVA: 0x1CF9570 Offset: 0x1CF9671 VA: 0x1CF9570
	private void set_DualWorkTimelineLinker(DualWorkTimelineLinker value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF00 Offset: 0x1AF001 VA: 0x1AEF00
	// RVA: 0x1CF9580 Offset: 0x1CF9681 VA: 0x1CF9580
	private UIDualWork get_UIDualWork() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF10 Offset: 0x1AF011 VA: 0x1AEF10
	// RVA: 0x1CF9590 Offset: 0x1CF9691 VA: 0x1CF9590
	private void set_UIDualWork(UIDualWork value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF20 Offset: 0x1AF021 VA: 0x1AEF20
	// RVA: 0x1CF95A0 Offset: 0x1CF96A1 VA: 0x1CF95A0
	private Transform get_CanvasTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF30 Offset: 0x1AF031 VA: 0x1AEF30
	// RVA: 0x1CF95B0 Offset: 0x1CF96B1 VA: 0x1CF95B0
	private void set_CanvasTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF40 Offset: 0x1AF041 VA: 0x1AEF40
	// RVA: 0x1CF95C0 Offset: 0x1CF96C1 VA: 0x1CF95C0
	private Transform get_ObjectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF50 Offset: 0x1AF051 VA: 0x1AEF50
	// RVA: 0x1CF95D0 Offset: 0x1CF96D1 VA: 0x1CF95D0
	private void set_ObjectTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF60 Offset: 0x1AF061 VA: 0x1AEF60
	// RVA: 0x1CF95E0 Offset: 0x1CF96E1 VA: 0x1CF95E0
	public ActorID get_SubActor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF70 Offset: 0x1AF071 VA: 0x1AEF70
	// RVA: 0x1CF95F0 Offset: 0x1CF96F1 VA: 0x1CF95F0
	public void set_SubActor(ActorID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF80 Offset: 0x1AF081 VA: 0x1AEF80
	// RVA: 0x1CF9600 Offset: 0x1CF9701 VA: 0x1CF9600
	public bool get_IsMiniGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEF90 Offset: 0x1AF091 VA: 0x1AEF90
	// RVA: 0x1CF9610 Offset: 0x1CF9711 VA: 0x1CF9610
	public void set_IsMiniGame(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFA0 Offset: 0x1AF0A1 VA: 0x1AEFA0
	// RVA: 0x1CF9620 Offset: 0x1CF9721 VA: 0x1CF9620
	public bool get_IsMiniGameSuccess() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AEFB0 Offset: 0x1AF0B1 VA: 0x1AEFB0
	// RVA: 0x1CF9630 Offset: 0x1CF9731 VA: 0x1CF9630
	private void set_IsMiniGameSuccess(bool value) { }

	// RVA: 0x1CF77A0 Offset: 0x1CF78A1 VA: 0x1CF77A0
	public void PlayMiniGame(Transform objectTransform, ActorID actorID, int loveLevel, UnityAction<bool> endCallBack) { }

	[IteratorStateMachineAttribute] // RVA: 0x1AEFC0 Offset: 0x1AF0C1 VA: 0x1AEFC0
	// RVA: 0x1CF96D0 Offset: 0x1CF97D1 VA: 0x1CF96D0
	private IEnumerator LoadWithContinueMiniGame() { }

	// RVA: 0x1CF9750 Offset: 0x1CF9851 VA: 0x1CF9750
	private void LoadAssetsAfterStart() { }

	// RVA: 0x1CF9C10 Offset: 0x1CF9D11 VA: 0x1CF9C10
	private void StartTimeline(PlayableDirector director) { }

	// RVA: 0x1CF9C80 Offset: 0x1CF9D81 VA: 0x1CF9C80
	public void EndTimeline() { }

	// RVA: 0x1CFA530 Offset: 0x1CFA631 VA: 0x1CFA530
	public void Update() { }

	// RVA: 0x1CFA1B0 Offset: 0x1CFA2B1 VA: 0x1CFA1B0
	public void DispResultWindow() { }

	// RVA: 0x1CF9C90 Offset: 0x1CF9D91 VA: 0x1CF9C90
	private void EndDualwork() { }

	[IteratorStateMachineAttribute] // RVA: 0x1AF030 Offset: 0x1AF131 VA: 0x1AF030
	// RVA: 0x1CFA940 Offset: 0x1CFAA41 VA: 0x1CFA940
	private IEnumerator RebindNextFrame(Animator animator) { }

	// RVA: 0x1CFA9C0 Offset: 0x1CFAAC1 VA: 0x1CFA9C0
	private DualWorkMiniGame.PushResult CheckPush(float position) { }

	// RVA: 0x1CF9640 Offset: 0x1CF9741 VA: 0x1CF9640
	private void InitMiniGame(int loveLevel) { }

	// RVA: 0x1CFA570 Offset: 0x1CFA671 VA: 0x1CFA570
	private void UpdateMiniGame(float deltaTime) { }

	// RVA: 0x1CFAA10 Offset: 0x1CFAB11 VA: 0x1CFAA10
	private void OnMiniGameEnd(bool isSkip) { }

	// RVA: 0x1CFAB80 Offset: 0x1CFAC81 VA: 0x1CFAB80
	private void Start() { }

	// RVA: 0x1CFAC30 Offset: 0x1CFAD31 VA: 0x1CFAC30
	private void OnDestroy() { }

	// RVA: 0x1CFAD40 Offset: 0x1CFAE41 VA: 0x1CFAD40
	private void OnCarryDay(int day) { }

	// RVA: 0x1CFADF0 Offset: 0x1CFAEF1 VA: 0x1CFADF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0A0 Offset: 0x1AF1A1 VA: 0x1AF0A0
	// RVA: 0x1CFAF20 Offset: 0x1CFB021 VA: 0x1CFAF20
	private void <DispResultWindow>b__43_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1AF0B0 Offset: 0x1AF1B1 VA: 0x1AF0B0
	// RVA: 0x1CFAF30 Offset: 0x1CFB031 VA: 0x1CFAF30
	private void <OnMiniGameEnd>b__71_0() { }
}

