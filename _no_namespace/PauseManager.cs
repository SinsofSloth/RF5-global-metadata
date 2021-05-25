public class PauseManager : SingletonMonoBehaviour<PauseManager> // TypeDefIndex: 7717
{
	// Fields
	private static bool m_ReserveSystemPause; // 0x0
	private static bool m_IsSystemPause; // 0x1
	private static bool m_IsGamePause; // 0x2
	private static bool m_IsInputPause; // 0x3
	private static bool m_IsGameTimePause; // 0x4
	[HideInInspector] // RVA: 0x168CB0 Offset: 0x168DB1 VA: 0x168CB0
	public UnityEvent OnGamePauseEvent; // 0x18
	private static float PrevTimeScale; // 0x8
	private static Coroutine m_endFrameUpdateCoroutine; // 0x10

	// Properties
	public static bool IsSystemPause { get; }
	public static bool IsGamePause { get; }
	public static bool IsInputPause { get; }
	public static bool IsTimePause { get; }

	// Methods

	// RVA: 0x1FDCC10 Offset: 0x1FDCD11 VA: 0x1FDCC10
	public static bool get_IsSystemPause() { }

	// RVA: 0x1FE0E50 Offset: 0x1FE0F51 VA: 0x1FE0E50
	public static bool get_IsGamePause() { }

	// RVA: 0x1FE0F90 Offset: 0x1FE1091 VA: 0x1FE0F90
	public static bool get_IsInputPause() { }

	// RVA: 0x1FE1100 Offset: 0x1FE1201 VA: 0x1FE1100
	public static bool get_IsTimePause() { }

	// RVA: 0x1FE12A0 Offset: 0x1FE13A1 VA: 0x1FE12A0
	private void OnApplicationQuit() { }

	// RVA: 0x1FE1310 Offset: 0x1FE1411 VA: 0x1FE1310
	private void StartUpdateCroutine() { }

	// RVA: 0x1FE1430 Offset: 0x1FE1531 VA: 0x1FE1430
	private void StopUpdateCroutine() { }

	// RVA: 0x1FE1560 Offset: 0x1FE1661 VA: 0x1FE1560
	private void OnEnable() { }

	// RVA: 0x1FE1570 Offset: 0x1FE1671 VA: 0x1FE1570
	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A29C0 Offset: 0x1A2AC1 VA: 0x1A29C0
	// RVA: 0x1FE1500 Offset: 0x1FE1601 VA: 0x1FE1500
	private IEnumerator EndFrameUpdate() { }

	// RVA: 0x1FE15B0 Offset: 0x1FE16B1 VA: 0x1FE15B0
	public static void OnSystemPause() { }

	// RVA: 0x1FE1620 Offset: 0x1FE1721 VA: 0x1FE1620
	public static void OffSystemPause() { }

	// RVA: 0x1FE1690 Offset: 0x1FE1791 VA: 0x1FE1690
	public static void OnGamePause() { }

	// RVA: 0x1FE1720 Offset: 0x1FE1821 VA: 0x1FE1720
	public static void OffGamePause() { }

	// RVA: 0x1FE1890 Offset: 0x1FE1991 VA: 0x1FE1890
	public static void OnInputPause() { }

	// RVA: 0x1FE1820 Offset: 0x1FE1921 VA: 0x1FE1820
	public static void OffInputPause() { }

	// RVA: 0x1FE1900 Offset: 0x1FE1A01 VA: 0x1FE1900
	public static void OnGameTimePause() { }

	// RVA: 0x1FE1970 Offset: 0x1FE1A71 VA: 0x1FE1970
	public static void OffGameTimePause() { }

	// RVA: 0x1FE1A00 Offset: 0x1FE1B01 VA: 0x1FE1A00
	public void .ctor() { }

	// RVA: 0x1FE1A80 Offset: 0x1FE1B81 VA: 0x1FE1A80
	private static void .cctor() { }
}

