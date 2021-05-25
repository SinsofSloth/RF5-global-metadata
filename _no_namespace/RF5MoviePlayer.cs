public class RF5MoviePlayer : SingletonMonoBehaviour<RF5MoviePlayer> // TypeDefIndex: 6828
{
	// Fields
	private RF5MoviePlayer.State m_State; // 0x18
	private RF5MoviePlayer.State m_PrevState; // 0x1C
	private float m_Elapsed; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x15FC80 Offset: 0x15FD81 VA: 0x15FC80
	private MovieID <CurrentMovie>k__BackingField; // 0x24
	private SEController[] SEControllers; // 0x28
	[SerializeField] // RVA: 0x15FC90 Offset: 0x15FD91 VA: 0x15FC90
	private MoviePlayer MoviePlayer; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x15FCA0 Offset: 0x15FDA1 VA: 0x15FCA0
	private UnityAction <CallBack>k__BackingField; // 0x38
	private static MovieRoomDataTable MovieRoomDataTable; // 0x0
	private static bool HasSystemPause; // 0x8
	private bool FirstFrameReady; // 0x40
	private int wait_frame; // 0x44

	// Properties
	private MovieID CurrentMovie { get; set; }
	private UnityAction CallBack { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x19D310 Offset: 0x19D411 VA: 0x19D310
	// RVA: 0x1DF1990 Offset: 0x1DF1A91 VA: 0x1DF1990
	private MovieID get_CurrentMovie() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D320 Offset: 0x19D421 VA: 0x19D320
	// RVA: 0x1DF19A0 Offset: 0x1DF1AA1 VA: 0x1DF19A0
	private void set_CurrentMovie(MovieID value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19D330 Offset: 0x19D431 VA: 0x19D330
	// RVA: 0x1DF19B0 Offset: 0x1DF1AB1 VA: 0x1DF19B0
	private UnityAction get_CallBack() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D340 Offset: 0x19D441 VA: 0x19D340
	// RVA: 0x1DF19C0 Offset: 0x1DF1AC1 VA: 0x1DF19C0
	private void set_CallBack(UnityAction value) { }

	// RVA: 0x1DF19D0 Offset: 0x1DF1AD1 VA: 0x1DF19D0
	public static void Play(MovieID id, UnityAction callback) { }

	// RVA: 0x1DF1E30 Offset: 0x1DF1F31 VA: 0x1DF1E30
	public static void Pause() { }

	// RVA: 0x1DF1EC0 Offset: 0x1DF1FC1 VA: 0x1DF1EC0
	public static void Resume() { }

	// RVA: 0x1DF1F30 Offset: 0x1DF2031 VA: 0x1DF1F30
	public static void Stop() { }

	// RVA: 0x1DF1FB0 Offset: 0x1DF20B1 VA: 0x1DF1FB0
	private void None_Enter() { }

	// RVA: 0x1DF1FC0 Offset: 0x1DF20C1 VA: 0x1DF1FC0
	private void None_Update() { }

	// RVA: 0x1DF1FD0 Offset: 0x1DF20D1 VA: 0x1DF1FD0
	private void Load_Enter() { }

	// RVA: 0x1DF2100 Offset: 0x1DF2201 VA: 0x1DF2100
	private void Load_Update() { }

	// RVA: 0x1DF21F0 Offset: 0x1DF22F1 VA: 0x1DF21F0
	private void WaitPlay_Enter() { }

	// RVA: 0x1DF2330 Offset: 0x1DF2431 VA: 0x1DF2330
	private void WaitPlay_Update() { }

	// RVA: 0x1DF2360 Offset: 0x1DF2461 VA: 0x1DF2360
	private void Play_Enter() { }

	// RVA: 0x1DF2780 Offset: 0x1DF2881 VA: 0x1DF2780
	private void Play_Update() { }

	// RVA: 0x1DF2800 Offset: 0x1DF2901 VA: 0x1DF2800
	private void Pause_Enter() { }

	// RVA: 0x1DF2820 Offset: 0x1DF2921 VA: 0x1DF2820
	private void Pause_Update() { }

	// RVA: 0x1DF2880 Offset: 0x1DF2981 VA: 0x1DF2880
	private void Done_Enter() { }

	// RVA: 0x1DF2B10 Offset: 0x1DF2C11 VA: 0x1DF2B10
	private void Done_Update() { }

	// RVA: 0x1DF1DC0 Offset: 0x1DF1EC1 VA: 0x1DF1DC0
	private void ChangeState(RF5MoviePlayer.State state) { }

	// RVA: 0x1DF2B20 Offset: 0x1DF2C21 VA: 0x1DF2B20
	private void Update() { }

	// RVA: 0x1DF2C50 Offset: 0x1DF2D51 VA: 0x1DF2C50 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1DF2DA0 Offset: 0x1DF2EA1 VA: 0x1DF2DA0
	private void Start() { }

	// RVA: 0x1DF2DC0 Offset: 0x1DF2EC1 VA: 0x1DF2DC0
	public void .ctor() { }

	// RVA: 0x1DF2E40 Offset: 0x1DF2F41 VA: 0x1DF2E40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x19D350 Offset: 0x19D451 VA: 0x19D350
	// RVA: 0x1DF2E50 Offset: 0x1DF2F51 VA: 0x1DF2E50
	private void <WaitPlay_Enter>b__25_0() { }
}

