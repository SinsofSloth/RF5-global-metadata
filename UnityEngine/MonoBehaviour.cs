[RequiredByNativeCodeAttribute] // RVA: 0xC6BF0 Offset: 0xC6CF1 VA: 0xC6BF0
[NativeHeaderAttribute] // RVA: 0xC6BF0 Offset: 0xC6CF1 VA: 0xC6BF0
[NativeHeaderAttribute] // RVA: 0xC6BF0 Offset: 0xC6CF1 VA: 0xC6BF0
[ExtensionOfNativeClassAttribute] // RVA: 0xC6BF0 Offset: 0xC6CF1 VA: 0xC6BF0
public class MonoBehaviour : Behaviour // TypeDefIndex: 3017
{
	// Properties
	public bool useGUILayout { get; set; }

	// Methods

	// RVA: 0x1A43830 Offset: 0x1A43931 VA: 0x1A43830
	public bool IsInvoking() { }

	// RVA: 0x1A438D0 Offset: 0x1A439D1 VA: 0x1A438D0
	public void CancelInvoke() { }

	// RVA: 0x1A43970 Offset: 0x1A43A71 VA: 0x1A43970
	public void Invoke(string methodName, float time) { }

	// RVA: 0x1A43A50 Offset: 0x1A43B51 VA: 0x1A43A50
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x1A43B30 Offset: 0x1A43C31 VA: 0x1A43B30
	public void CancelInvoke(string methodName) { }

	// RVA: 0x1A43BD0 Offset: 0x1A43CD1 VA: 0x1A43BD0
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocsAttribute] // RVA: 0xD6CB0 Offset: 0xD6DB1 VA: 0xD6CB0
	// RVA: 0x1A43C70 Offset: 0x1A43D71 VA: 0x1A43C70
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x1A43C80 Offset: 0x1A43D81 VA: 0x1A43C80
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x1A43E50 Offset: 0x1A43F51 VA: 0x1A43E50
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[ObsoleteAttribute] // RVA: 0xD6CC0 Offset: 0xD6DC1 VA: 0xD6CC0
	// RVA: 0x1A43FB0 Offset: 0x1A440B1 VA: 0x1A43FB0
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x1A43FC0 Offset: 0x1A440C1 VA: 0x1A43FC0
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x1A44120 Offset: 0x1A44221 VA: 0x1A44120
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x1A44280 Offset: 0x1A44381 VA: 0x1A44280
	public void StopCoroutine(string methodName) { }

	// RVA: 0x1A442D0 Offset: 0x1A443D1 VA: 0x1A442D0
	public void StopAllCoroutines() { }

	// RVA: 0x1A44320 Offset: 0x1A44421 VA: 0x1A44320
	public bool get_useGUILayout() { }

	// RVA: 0x1A44370 Offset: 0x1A44471 VA: 0x1A44370
	public void set_useGUILayout(bool value) { }

	// RVA: 0x1A443C0 Offset: 0x1A444C1 VA: 0x1A443C0
	public static void print(object message) { }

	[FreeFunctionAttribute] // RVA: 0xD6D00 Offset: 0xD6E01 VA: 0xD6D00
	// RVA: 0x1A43920 Offset: 0x1A43A21 VA: 0x1A43920
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0xD6D40 Offset: 0xD6E41 VA: 0xD6D40
	// RVA: 0x1A43880 Offset: 0x1A43981 VA: 0x1A43880
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunctionAttribute] // RVA: 0xD6D80 Offset: 0xD6E81 VA: 0xD6D80
	// RVA: 0x1A439E0 Offset: 0x1A43AE1 VA: 0x1A439E0
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunctionAttribute] // RVA: 0xD6D90 Offset: 0xD6E91 VA: 0xD6D90
	// RVA: 0x1A43B80 Offset: 0x1A43C81 VA: 0x1A43B80
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xD6DA0 Offset: 0xD6EA1 VA: 0xD6DA0
	// RVA: 0x1A43C20 Offset: 0x1A43D21 VA: 0x1A43C20
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunctionAttribute] // RVA: 0xD6DB0 Offset: 0xD6EB1 VA: 0xD6DB0
	// RVA: 0x1A43DA0 Offset: 0x1A43EA1 VA: 0x1A43DA0
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x1A43DF0 Offset: 0x1A43EF1 VA: 0x1A43DF0
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x1A43F60 Offset: 0x1A44061 VA: 0x1A43F60
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x1A44230 Offset: 0x1A44331 VA: 0x1A44230
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x1A440D0 Offset: 0x1A441D1 VA: 0x1A440D0
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x1A44430 Offset: 0x1A44531 VA: 0x1A44430
	internal string GetScriptClassName() { }

	// RVA: 0x1A44480 Offset: 0x1A44581 VA: 0x1A44480
	public void .ctor() { }
}

