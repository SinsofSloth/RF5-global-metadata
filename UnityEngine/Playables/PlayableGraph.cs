[NativeHeaderAttribute] // RVA: 0xC8C70 Offset: 0xC8D71 VA: 0xC8C70
[UsedByNativeCodeAttribute] // RVA: 0xC8C70 Offset: 0xC8D71 VA: 0xC8C70
[NativeHeaderAttribute] // RVA: 0xC8C70 Offset: 0xC8D71 VA: 0xC8C70
[NativeHeaderAttribute] // RVA: 0xC8C70 Offset: 0xC8D71 VA: 0xC8C70
[NativeHeaderAttribute] // RVA: 0xC8C70 Offset: 0xC8D71 VA: 0xC8C70
public struct PlayableGraph // TypeDefIndex: 3354
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8

	// Methods

	// RVA: 0x37F460 Offset: 0x37F561 VA: 0x37F460
	public Playable GetRootPlayable(int index) { }

	// RVA: -1 Offset: -1
	public bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F2110 Offset: 0x2F2211 VA: 0x2F2110
	|-PlayableGraph.Connect<AnimationMixerPlayable, Playable>
	|
	|-RVA: 0x2F21A0 Offset: 0x2F22A1 VA: 0x2F21A0
	|-PlayableGraph.Connect<AnimatorControllerPlayable, AnimationScriptPlayable>
	|
	|-RVA: 0x2F2230 Offset: 0x2F2331 VA: 0x2F2230
	|-PlayableGraph.Connect<Playable, AnimationLayerMixerPlayable>
	|
	|-RVA: 0x2F22C0 Offset: 0x2F23C1 VA: 0x2F22C0
	|-PlayableGraph.Connect<Playable, AnimationMixerPlayable>
	|
	|-RVA: 0x2F2350 Offset: 0x2F2451 VA: 0x2F2350
	|-PlayableGraph.Connect<Playable, AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0x2F23E0 Offset: 0x2F24E1 VA: 0x2F23E0
	|-PlayableGraph.Connect<Playable, AnimationOffsetPlayable>
	|
	|-RVA: 0x2F2470 Offset: 0x2F2571 VA: 0x2F2470
	|-PlayableGraph.Connect<Playable, AnimationRemoveScalePlayable>
	|
	|-RVA: 0x2F2500 Offset: 0x2F2601 VA: 0x2F2500
	|-PlayableGraph.Connect<Playable, AudioMixerPlayable>
	|
	|-RVA: 0x2F2590 Offset: 0x2F2691 VA: 0x2F2590
	|-PlayableGraph.Connect<Playable, Playable>
	|
	|-RVA: 0x2F2620 Offset: 0x2F2721 VA: 0x2F2620
	|-PlayableGraph.Connect<Playable, ScriptPlayable<object>>
	|-PlayableGraph.Connect<Playable, ScriptPlayable<TimeNotificationBehaviour>>
	*/

	// RVA: -1 Offset: -1
	public void Disconnect<U>(U input, int inputPort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302910 Offset: 0x302A11 VA: 0x302910
	|-PlayableGraph.Disconnect<AnimationMixerPlayable>
	*/

	// RVA: -1 Offset: -1
	public void DestroyPlayable<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x302870 Offset: 0x302971 VA: 0x302870
	|-PlayableGraph.DestroyPlayable<Playable>
	*/

	// RVA: -1 Offset: -1
	public void DestroySubgraph<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3028C0 Offset: 0x3029C1 VA: 0x3028C0
	|-PlayableGraph.DestroySubgraph<Playable>
	*/

	// RVA: 0x37F4D0 Offset: 0x37F5D1 VA: 0x37F4D0
	public void Evaluate() { }

	// RVA: 0x2B6DFB0 Offset: 0x2B6E0B1 VA: 0x2B6DFB0
	public static PlayableGraph Create() { }

	// RVA: 0x2B6E010 Offset: 0x2B6E111 VA: 0x2B6E010
	public static PlayableGraph Create(string name) { }

	[FreeFunctionAttribute] // RVA: 0xD9ED0 Offset: 0xD9FD1 VA: 0xD9ED0
	// RVA: 0x37F520 Offset: 0x37F621 VA: 0x37F520
	public void Destroy() { }

	// RVA: 0x37F570 Offset: 0x37F671 VA: 0x37F570
	public bool IsValid() { }

	[FreeFunctionAttribute] // RVA: 0xD9F20 Offset: 0xDA021 VA: 0xD9F20
	// RVA: 0x37F5C0 Offset: 0x37F6C1 VA: 0x37F5C0
	public bool IsPlaying() { }

	[FreeFunctionAttribute] // RVA: 0xD9F70 Offset: 0xDA071 VA: 0xD9F70
	// RVA: 0x37F610 Offset: 0x37F711 VA: 0x37F610
	public void Play() { }

	[FreeFunctionAttribute] // RVA: 0xD9FC0 Offset: 0xDA0C1 VA: 0xD9FC0
	// RVA: 0x37F660 Offset: 0x37F761 VA: 0x37F660
	public void Stop() { }

	[FreeFunctionAttribute] // RVA: 0xDA010 Offset: 0xDA111 VA: 0xDA010
	// RVA: 0x37F6B0 Offset: 0x37F7B1 VA: 0x37F6B0
	public void Evaluate(float deltaTime) { }

	[FreeFunctionAttribute] // RVA: 0xDA060 Offset: 0xDA161 VA: 0xDA060
	// RVA: 0x37F700 Offset: 0x37F801 VA: 0x37F700
	public void SetTimeUpdateMode(DirectorUpdateMode value) { }

	[FreeFunctionAttribute] // RVA: 0xDA0B0 Offset: 0xDA1B1 VA: 0xDA0B0
	// RVA: 0x37F750 Offset: 0x37F851 VA: 0x37F750
	public IExposedPropertyTable GetResolver() { }

	[FreeFunctionAttribute] // RVA: 0xDA100 Offset: 0xDA201 VA: 0xDA100
	// RVA: 0x37F7A0 Offset: 0x37F8A1 VA: 0x37F7A0
	public int GetPlayableCount() { }

	[FreeFunctionAttribute] // RVA: 0xDA150 Offset: 0xDA251 VA: 0xDA150
	// RVA: 0x37F7F0 Offset: 0x37F8F1 VA: 0x37F7F0
	public int GetRootPlayableCount() { }

	[FreeFunctionAttribute] // RVA: 0xDA1A0 Offset: 0xDA2A1 VA: 0xDA1A0
	// RVA: 0x37F840 Offset: 0x37F941 VA: 0x37F840
	internal PlayableHandle CreatePlayableHandle() { }

	[FreeFunctionAttribute] // RVA: 0xDA1F0 Offset: 0xDA2F1 VA: 0xDA1F0
	// RVA: 0x37F8A0 Offset: 0x37F9A1 VA: 0x37F8A0
	internal bool CreateScriptOutputInternal(string name, out PlayableOutputHandle handle) { }

	[FreeFunctionAttribute] // RVA: 0xDA240 Offset: 0xDA341 VA: 0xDA240
	// RVA: 0x37F900 Offset: 0x37FA01 VA: 0x37F900
	internal PlayableHandle GetRootPlayableInternal(int index) { }

	[FreeFunctionAttribute] // RVA: 0xDA290 Offset: 0xDA391 VA: 0xDA290
	// RVA: 0x37F970 Offset: 0x37FA71 VA: 0x37F970
	private bool ConnectInternal(PlayableHandle source, int sourceOutputPort, PlayableHandle destination, int destinationInputPort) { }

	[FreeFunctionAttribute] // RVA: 0xDA2E0 Offset: 0xDA3E1 VA: 0xDA2E0
	// RVA: 0x37F9F0 Offset: 0x37FAF1 VA: 0x37F9F0
	private void DisconnectInternal(PlayableHandle playable, int inputPort) { }

	[FreeFunctionAttribute] // RVA: 0xDA330 Offset: 0xDA431 VA: 0xDA330
	// RVA: 0x37FA60 Offset: 0x37FB61 VA: 0x37FA60
	private void DestroyPlayableInternal(PlayableHandle playable) { }

	[FreeFunctionAttribute] // RVA: 0xDA380 Offset: 0xDA481 VA: 0xDA380
	// RVA: 0x37FAC0 Offset: 0x37FBC1 VA: 0x37FAC0
	private void DestroySubgraphInternal(PlayableHandle playable) { }

	// RVA: 0x2B6E070 Offset: 0x2B6E171 VA: 0x2B6E070
	private static void Create_Injected(string name, out PlayableGraph ret) { }

	// RVA: 0x2B6E110 Offset: 0x2B6E211 VA: 0x2B6E110
	private static void Destroy_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2B6E1B0 Offset: 0x2B6E2B1 VA: 0x2B6E1B0
	private static bool IsValid_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2B6E250 Offset: 0x2B6E351 VA: 0x2B6E250
	private static bool IsPlaying_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2B6E2F0 Offset: 0x2B6E3F1 VA: 0x2B6E2F0
	private static void Play_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2B6E390 Offset: 0x2B6E491 VA: 0x2B6E390
	private static void Stop_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2B6E3E0 Offset: 0x2B6E4E1 VA: 0x2B6E3E0
	private static void Evaluate_Injected(ref PlayableGraph _unity_self, float deltaTime) { }

	// RVA: 0x2B6E480 Offset: 0x2B6E581 VA: 0x2B6E480
	private static void SetTimeUpdateMode_Injected(ref PlayableGraph _unity_self, DirectorUpdateMode value) { }

	// RVA: 0x2B6E520 Offset: 0x2B6E621 VA: 0x2B6E520
	private static IExposedPropertyTable GetResolver_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2B6E5C0 Offset: 0x2B6E6C1 VA: 0x2B6E5C0
	private static int GetPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2B6E660 Offset: 0x2B6E761 VA: 0x2B6E660
	private static int GetRootPlayableCount_Injected(ref PlayableGraph _unity_self) { }

	// RVA: 0x2B6E6B0 Offset: 0x2B6E7B1 VA: 0x2B6E6B0
	private static void CreatePlayableHandle_Injected(ref PlayableGraph _unity_self, out PlayableHandle ret) { }

	// RVA: 0x2B6E760 Offset: 0x2B6E861 VA: 0x2B6E760
	private static bool CreateScriptOutputInternal_Injected(ref PlayableGraph _unity_self, string name, out PlayableOutputHandle handle) { }

	// RVA: 0x2B6E7C0 Offset: 0x2B6E8C1 VA: 0x2B6E7C0
	private static void GetRootPlayableInternal_Injected(ref PlayableGraph _unity_self, int index, out PlayableHandle ret) { }

	// RVA: 0x2B6E8A0 Offset: 0x2B6E9A1 VA: 0x2B6E8A0
	private static bool ConnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle source, int sourceOutputPort, ref PlayableHandle destination, int destinationInputPort) { }

	// RVA: 0x2B6E980 Offset: 0x2B6EA81 VA: 0x2B6E980
	private static void DisconnectInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable, int inputPort) { }

	// RVA: 0x2B6EA40 Offset: 0x2B6EB41 VA: 0x2B6EA40
	private static void DestroyPlayableInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable) { }

	// RVA: 0x2B6EAF0 Offset: 0x2B6EBF1 VA: 0x2B6EAF0
	private static void DestroySubgraphInternal_Injected(ref PlayableGraph _unity_self, ref PlayableHandle playable) { }
}

