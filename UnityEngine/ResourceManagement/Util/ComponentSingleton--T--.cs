[ExecuteInEditMode] // RVA: 0x129960 Offset: 0x129A61 VA: 0x129960
public abstract class ComponentSingleton<T> : MonoBehaviour // TypeDefIndex: 4462
{
	// Fields
	private static T s_Instance; // 0x0

	// Properties
	public static bool Exists { get; }
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static bool get_Exists() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA79C0 Offset: 0x2AA7AC1 VA: 0x2AA79C0
	|-ComponentSingleton<MonoBehaviourCallbackHooks>.get_Exists
	|-ComponentSingleton<object>.get_Exists
	|-ComponentSingleton<DiagnosticEventCollectorSingleton>.get_Exists
	|-ComponentSingleton<DelayedActionManager>.get_Exists
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7A80 Offset: 0x2AA7B81 VA: 0x2AA7A80
	|-ComponentSingleton<MonoBehaviourCallbackHooks>.get_Instance
	|-ComponentSingleton<object>.get_Instance
	|-ComponentSingleton<DiagnosticEventCollectorSingleton>.get_Instance
	|-ComponentSingleton<DelayedActionManager>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private static T FindInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7CA0 Offset: 0x2AA7DA1 VA: 0x2AA7CA0
	|-ComponentSingleton<object>.FindInstance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual string GetGameObjectName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7D70 Offset: 0x2AA7E71 VA: 0x2AA7D70
	|-ComponentSingleton<object>.GetGameObjectName
	|-ComponentSingleton<DelayedActionManager>.GetGameObjectName
	*/

	// RVA: -1 Offset: -1
	private static T CreateNewSingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7E00 Offset: 0x2AA7F01 VA: 0x2AA7E00
	|-ComponentSingleton<object>.CreateNewSingleton
	*/

	// RVA: -1 Offset: -1
	private void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA7F30 Offset: 0x2AA8031 VA: 0x2AA7F30
	|-ComponentSingleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	public static void DestroySingleton() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA8110 Offset: 0x2AA8211 VA: 0x2AA8110
	|-ComponentSingleton<object>.DestroySingleton
	|-ComponentSingleton<DiagnosticEventCollectorSingleton>.DestroySingleton
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2AA82C0 Offset: 0x2AA83C1 VA: 0x2AA82C0
	|-ComponentSingleton<MonoBehaviourCallbackHooks>..ctor
	|-ComponentSingleton<object>..ctor
	|-ComponentSingleton<DiagnosticEventCollectorSingleton>..ctor
	|-ComponentSingleton<DelayedActionManager>..ctor
	*/
}

