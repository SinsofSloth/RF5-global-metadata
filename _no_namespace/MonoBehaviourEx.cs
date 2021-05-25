[ExtensionAttribute] // RVA: 0x146450 Offset: 0x146551 VA: 0x146450
public static class MonoBehaviourEx // TypeDefIndex: 7302
{
	// Methods

	[ExtensionAttribute] // RVA: 0x19F860 Offset: 0x19F961 VA: 0x19F860
	// RVA: 0x1CBFB10 Offset: 0x1CBFC11 VA: 0x1CBFB10
	public static void SetActive(MonoBehaviour self, bool isActive) { }

	[ExtensionAttribute] // RVA: 0x19F870 Offset: 0x19F971 VA: 0x19F870
	// RVA: 0x1CBFBE0 Offset: 0x1CBFCE1 VA: 0x1CBFBE0
	public static bool IsActive(MonoBehaviour self) { }

	[ExtensionAttribute] // RVA: 0x19F880 Offset: 0x19F981 VA: 0x19F880
	// RVA: 0x1CC2F90 Offset: 0x1CC3091 VA: 0x1CC2F90
	public static bool IsEnabled(MonoBehaviour self) { }

	[ExtensionAttribute] // RVA: 0x19F890 Offset: 0x19F991 VA: 0x19F890
	// RVA: 0x1CC2FB0 Offset: 0x1CC30B1 VA: 0x1CC2FB0
	public static void IsEnabled(MonoBehaviour self, bool value) { }

	[ExtensionAttribute] // RVA: 0x19F8A0 Offset: 0x19F9A1 VA: 0x19F8A0
	// RVA: 0x1CC2FD0 Offset: 0x1CC30D1 VA: 0x1CC2FD0
	public static void SetLayer(MonoBehaviour self, int layer, bool isRecursion = True) { }

	[ExtensionAttribute] // RVA: 0x19F8B0 Offset: 0x19F9B1 VA: 0x19F8B0
	// RVA: 0x1CC3010 Offset: 0x1CC3111 VA: 0x1CC3010
	public static void Invoke(MonoBehaviour self, Action method, float delay) { }

	[ExtensionAttribute] // RVA: 0x19F8C0 Offset: 0x19F9C1 VA: 0x19F8C0
	// RVA: 0x1CC3070 Offset: 0x1CC3171 VA: 0x1CC3070
	public static void DoEvent(MonoBehaviour self, Action handler) { }

	[ExtensionAttribute] // RVA: 0x19F8D0 Offset: 0x19F9D1 VA: 0x19F8D0
	// RVA: -1 Offset: -1
	public static void DoEvent<T>(MonoBehaviour self, Action<T> handler, T parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6A40 Offset: 0x21D6B41 VA: 0x21D6A40
	|-MonoBehaviourEx.DoEvent<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F8E0 Offset: 0x19F9E1 VA: 0x19F8E0
	// RVA: -1 Offset: -1
	public static void DoEvent<T1, T2>(MonoBehaviour self, Action<T1, T2> handler, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D6A10 Offset: 0x21D6B11 VA: 0x21D6A10
	|-MonoBehaviourEx.DoEvent<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x19F8F0 Offset: 0x19F9F1 VA: 0x19F8F0
	// RVA: -1 Offset: -1
	public static void DoEvent<T1, T2, T3>(MonoBehaviour self, Action<T1, T2, T3> handler, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21D69E0 Offset: 0x21D6AE1 VA: 0x21D69E0
	|-MonoBehaviourEx.DoEvent<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x19F900 Offset: 0x19FA01 VA: 0x19F900
	// RVA: -1 Offset: -1
	public static TResult DoEvent<TResult>(MonoBehaviour self, Func<TResult> handler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22683F0 Offset: 0x22684F1 VA: 0x22683F0
	|-MonoBehaviourEx.DoEvent<object>
	*/

	[ExtensionAttribute] // RVA: 0x19F910 Offset: 0x19FA11 VA: 0x19F910
	// RVA: -1 Offset: -1
	public static TResult DoEvent<T, TResult>(MonoBehaviour self, Func<T, TResult> handler, T parameter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22683C0 Offset: 0x22684C1 VA: 0x22683C0
	|-MonoBehaviourEx.DoEvent<object, object>
	*/

	[ExtensionAttribute] // RVA: 0x19F920 Offset: 0x19FA21 VA: 0x19F920
	// RVA: -1 Offset: -1
	public static TResult DoEvent<T1, T2, TResult>(MonoBehaviour self, Func<T1, T2, TResult> handler, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2268390 Offset: 0x2268491 VA: 0x2268390
	|-MonoBehaviourEx.DoEvent<object, object, object>
	*/

	[ExtensionAttribute] // RVA: 0x19F930 Offset: 0x19FA31 VA: 0x19F930
	// RVA: 0x1CC3090 Offset: 0x1CC3191 VA: 0x1CC3090
	public static void StartCoroutine(MonoBehaviour self, Func<IEnumerator> method) { }

	[ExtensionAttribute] // RVA: 0x19F940 Offset: 0x19FA41 VA: 0x19F940
	// RVA: 0x1CC30E0 Offset: 0x1CC31E1 VA: 0x1CC30E0
	public static void StopCoroutine(MonoBehaviour self, Func<IEnumerator> method) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F950 Offset: 0x19FA51 VA: 0x19F950
	[ExtensionAttribute] // RVA: 0x19F950 Offset: 0x19FA51 VA: 0x19F950
	// RVA: 0x1CC3130 Offset: 0x1CC3231 VA: 0x1CC3130
	public static IEnumerator PlayAnimationAsync(MonoBehaviour self, string animationName, Animation playAnimation) { }

	[IteratorStateMachineAttribute] // RVA: 0x19F9D0 Offset: 0x19FAD1 VA: 0x19F9D0
	[ExtensionAttribute] // RVA: 0x19F9D0 Offset: 0x19FAD1 VA: 0x19F9D0
	// RVA: 0x1CC3210 Offset: 0x1CC3311 VA: 0x1CC3210
	public static IEnumerator PlayAnimatorStateAsync(MonoBehaviour self, string stateName, Animator playAnimator) { }
}

