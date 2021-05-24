public abstract class SRSingleton<T> : SRMonoBehaviour // TypeDefIndex: 4364
{
	// Fields
	private static T _instance; // 0x0

	// Properties
	public static T Instance { get; }
	public static bool HasInstance { get; }

	// Methods

	[DebuggerStepThroughAttribute] // RVA: 0x128370 Offset: 0x128471 VA: 0x128370
	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA8CE0 Offset: 0x2CA8DE1 VA: 0x2CA8CE0
	|-SRSingleton<object>.get_Instance
	*/

	[DebuggerStepThroughAttribute] // RVA: 0x128380 Offset: 0x128481 VA: 0x128380
	// RVA: -1 Offset: -1
	public static bool get_HasInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA8ED0 Offset: 0x2CA8FD1 VA: 0x2CA8ED0
	|-SRSingleton<object>.get_HasInstance
	*/

	// RVA: -1 Offset: -1
	private void Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA8F90 Offset: 0x2CA9091 VA: 0x2CA8F90
	|-SRSingleton<object>.Register
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9220 Offset: 0x2CA9321 VA: 0x2CA9220
	|-SRSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void OnEnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9250 Offset: 0x2CA9351 VA: 0x2CA9250
	|-SRSingleton<object>.OnEnable
	*/

	// RVA: -1 Offset: -1
	private void OnApplicationQuit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9320 Offset: 0x2CA9421 VA: 0x2CA9320
	|-SRSingleton<object>.OnApplicationQuit
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA9360 Offset: 0x2CA9461 VA: 0x2CA9360
	|-SRSingleton<object>..ctor
	*/
}

