[ExtensionAttribute] // RVA: 0xC8C60 Offset: 0xC8D61 VA: 0xC8C60
public static class PlayableExtensions // TypeDefIndex: 3352
{
	// Methods

	[ExtensionAttribute] // RVA: 0xD9CB0 Offset: 0xD9DB1 VA: 0xD9CB0
	// RVA: -1 Offset: -1
	public static bool IsValid<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D1190 Offset: 0x22D1291 VA: 0x22D1190
	|-PlayableExtensions.IsValid<Playable>
	|
	|-RVA: 0x22D11D0 Offset: 0x22D12D1 VA: 0x22D11D0
	|-PlayableExtensions.IsValid<ScriptPlayable<object>>
	|-PlayableExtensions.IsValid<ScriptPlayable<ActivationControlPlayable>>
	|-PlayableExtensions.IsValid<ScriptPlayable<TimeNotificationBehaviour>>
	|-PlayableExtensions.IsValid<ScriptPlayable<TimelinePlayable>>
	*/

	[ExtensionAttribute] // RVA: 0xD9CC0 Offset: 0xD9DC1 VA: 0xD9CC0
	// RVA: -1 Offset: -1
	public static void Destroy<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E80C0 Offset: 0x23E81C1 VA: 0x23E80C0
	|-PlayableExtensions.Destroy<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9CD0 Offset: 0xD9DD1 VA: 0xD9CD0
	// RVA: -1 Offset: -1
	public static PlayableGraph GetGraph<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8CC0 Offset: 0x34F8DC1 VA: 0x34F8CC0
	|-PlayableExtensions.GetGraph<AnimationMixerPlayable>
	|
	|-RVA: 0x34F8D00 Offset: 0x34F8E01 VA: 0x34F8D00
	|-PlayableExtensions.GetGraph<AnimationScriptPlayable>
	|
	|-RVA: 0x34F8D40 Offset: 0x34F8E41 VA: 0x34F8D40
	|-PlayableExtensions.GetGraph<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9CE0 Offset: 0xD9DE1 VA: 0xD9CE0
	[ObsoleteAttribute] // RVA: 0xD9CE0 Offset: 0xD9DE1 VA: 0xD9CE0
	// RVA: -1 Offset: -1
	public static void SetPlayState<U>(U playable, PlayState value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8B50 Offset: 0x23E8C51 VA: 0x23E8B50
	|-PlayableExtensions.SetPlayState<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9D30 Offset: 0xD9E31 VA: 0xD9D30
	// RVA: -1 Offset: -1
	public static PlayState GetPlayState<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8B80 Offset: 0x34F8C81 VA: 0x34F8B80
	|-PlayableExtensions.GetPlayState<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9D40 Offset: 0xD9E41 VA: 0xD9D40
	// RVA: -1 Offset: -1
	public static void Play<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E81C0 Offset: 0x23E82C1 VA: 0x23E81C0
	|-PlayableExtensions.Play<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9D50 Offset: 0xD9E51 VA: 0xD9D50
	// RVA: -1 Offset: -1
	public static void Pause<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8180 Offset: 0x23E8281 VA: 0x23E8180
	|-PlayableExtensions.Pause<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9D60 Offset: 0xD9E61 VA: 0xD9D60
	// RVA: -1 Offset: -1
	public static void SetSpeed<U>(U playable, double value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8DB0 Offset: 0x23E8EB1 VA: 0x23E8DB0
	|-PlayableExtensions.SetSpeed<AnimationMixerPlayable>
	|
	|-RVA: 0x23E8E00 Offset: 0x23E8F01 VA: 0x23E8E00
	|-PlayableExtensions.SetSpeed<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9D70 Offset: 0xD9E71 VA: 0xD9D70
	// RVA: -1 Offset: -1
	public static double GetSpeed<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21ABDE0 Offset: 0x21ABEE1 VA: 0x21ABDE0
	|-PlayableExtensions.GetSpeed<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9D80 Offset: 0xD9E81 VA: 0xD9D80
	// RVA: -1 Offset: -1
	public static void SetDuration<U>(U playable, double value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8250 Offset: 0x23E8351 VA: 0x23E8250
	|-PlayableExtensions.SetDuration<AnimationClipPlayable>
	|
	|-RVA: 0x23E82A0 Offset: 0x23E83A1 VA: 0x23E82A0
	|-PlayableExtensions.SetDuration<AnimationMixerPlayable>
	|
	|-RVA: 0x23E82F0 Offset: 0x23E83F1 VA: 0x23E82F0
	|-PlayableExtensions.SetDuration<AudioClipPlayable>
	|
	|-RVA: 0x23E8340 Offset: 0x23E8441 VA: 0x23E8340
	|-PlayableExtensions.SetDuration<Playable>
	|
	|-RVA: 0x23E8390 Offset: 0x23E8491 VA: 0x23E8390
	|-PlayableExtensions.SetDuration<ScriptPlayable<object>>
	|-PlayableExtensions.SetDuration<ScriptPlayable<TimeNotificationBehaviour>>
	*/

	[ExtensionAttribute] // RVA: 0xD9D90 Offset: 0xD9E91 VA: 0xD9D90
	// RVA: -1 Offset: -1
	public static double GetDuration<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21ABC20 Offset: 0x21ABD21 VA: 0x21ABC20
	|-PlayableExtensions.GetDuration<AnimationMixerPlayable>
	|
	|-RVA: 0x21ABC60 Offset: 0x21ABD61 VA: 0x21ABC60
	|-PlayableExtensions.GetDuration<Playable>
	|
	|-RVA: 0x21ABCA0 Offset: 0x21ABDA1 VA: 0x21ABCA0
	|-PlayableExtensions.GetDuration<ScriptPlayable<CinemachineShotPlayable>>
	|-PlayableExtensions.GetDuration<ScriptPlayable<object>>
	|-PlayableExtensions.GetDuration<ScriptPlayable<TransformTweenBehaviour>>
	*/

	[ExtensionAttribute] // RVA: 0xD9DA0 Offset: 0xD9EA1 VA: 0xD9DA0
	// RVA: -1 Offset: -1
	public static void SetTime<U>(U playable, double value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8E50 Offset: 0x23E8F51 VA: 0x23E8E50
	|-PlayableExtensions.SetTime<AnimationMixerPlayable>
	|
	|-RVA: 0x23E8EA0 Offset: 0x23E8FA1 VA: 0x23E8EA0
	|-PlayableExtensions.SetTime<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9DB0 Offset: 0xD9EB1 VA: 0xD9DB0
	// RVA: -1 Offset: -1
	public static double GetTime<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21ABE20 Offset: 0x21ABF21 VA: 0x21ABE20
	|-PlayableExtensions.GetTime<AnimationMixerPlayable>
	|
	|-RVA: 0x21ABE60 Offset: 0x21ABF61 VA: 0x21ABE60
	|-PlayableExtensions.GetTime<Playable>
	|
	|-RVA: 0x21ABEA0 Offset: 0x21ABFA1 VA: 0x21ABEA0
	|-PlayableExtensions.GetTime<ScriptPlayable<CinemachineShotPlayable>>
	|-PlayableExtensions.GetTime<ScriptPlayable<object>>
	|-PlayableExtensions.GetTime<ScriptPlayable<TransformTweenBehaviour>>
	*/

	[ExtensionAttribute] // RVA: 0xD9DC0 Offset: 0xD9EC1 VA: 0xD9DC0
	// RVA: -1 Offset: -1
	public static double GetPreviousTime<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x21ABDA0 Offset: 0x21ABEA1 VA: 0x21ABDA0
	|-PlayableExtensions.GetPreviousTime<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9DD0 Offset: 0xD9ED1 VA: 0xD9DD0
	// RVA: -1 Offset: -1
	public static void SetDone<U>(U playable, bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8200 Offset: 0x23E8301 VA: 0x23E8200
	|-PlayableExtensions.SetDone<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9DE0 Offset: 0xD9EE1 VA: 0xD9DE0
	// RVA: -1 Offset: -1
	public static bool IsDone<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D1150 Offset: 0x22D1251 VA: 0x22D1150
	|-PlayableExtensions.IsDone<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9DF0 Offset: 0xD9EF1 VA: 0xD9DF0
	// RVA: -1 Offset: -1
	public static void SetPropagateSetTime<U>(U playable, bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8C50 Offset: 0x23E8D51 VA: 0x23E8C50
	|-PlayableExtensions.SetPropagateSetTime<Playable>
	|
	|-RVA: 0x23E8CA0 Offset: 0x23E8DA1 VA: 0x23E8CA0
	|-PlayableExtensions.SetPropagateSetTime<ScriptPlayable<object>>
	|-PlayableExtensions.SetPropagateSetTime<ScriptPlayable<TimeNotificationBehaviour>>
	|-PlayableExtensions.SetPropagateSetTime<ScriptPlayable<TimelinePlayable>>
	*/

	[ExtensionAttribute] // RVA: 0xD9E00 Offset: 0xD9F01 VA: 0xD9E00
	// RVA: -1 Offset: -1
	public static void SetInputCount<U>(U playable, int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E84A0 Offset: 0x23E85A1 VA: 0x23E84A0
	|-PlayableExtensions.SetInputCount<AnimationMixerPlayable>
	|
	|-RVA: 0x23E84F0 Offset: 0x23E85F1 VA: 0x23E84F0
	|-PlayableExtensions.SetInputCount<AnimationScriptPlayable>
	|
	|-RVA: 0x23E8540 Offset: 0x23E8641 VA: 0x23E8540
	|-PlayableExtensions.SetInputCount<Playable>
	|
	|-RVA: 0x23E8590 Offset: 0x23E8691 VA: 0x23E8590
	|-PlayableExtensions.SetInputCount<ScriptPlayable<CinemachineMixer>>
	|-PlayableExtensions.SetInputCount<ScriptPlayable<object>>
	|-PlayableExtensions.SetInputCount<ScriptPlayable<TimeNotificationBehaviour>>
	*/

	[ExtensionAttribute] // RVA: 0xD9E10 Offset: 0xD9F11 VA: 0xD9E10
	// RVA: -1 Offset: -1
	public static int GetInputCount<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E550 Offset: 0x255E651 VA: 0x255E550
	|-PlayableExtensions.GetInputCount<AnimationMixerPlayable>
	|
	|-RVA: 0x255E590 Offset: 0x255E691 VA: 0x255E590
	|-PlayableExtensions.GetInputCount<AnimationScriptPlayable>
	|
	|-RVA: 0x255E5D0 Offset: 0x255E6D1 VA: 0x255E5D0
	|-PlayableExtensions.GetInputCount<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9E20 Offset: 0xD9F21 VA: 0xD9E20
	// RVA: -1 Offset: -1
	public static Playable GetInput<U>(U playable, int inputPort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8BC0 Offset: 0x34F8CC1 VA: 0x34F8BC0
	|-PlayableExtensions.GetInput<AnimationMixerPlayable>
	|
	|-RVA: 0x34F8C10 Offset: 0x34F8D11 VA: 0x34F8C10
	|-PlayableExtensions.GetInput<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9E30 Offset: 0xD9F31 VA: 0xD9E30
	// RVA: -1 Offset: -1
	public static void SetInputWeight<U>(U playable, int inputIndex, float weight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E86A0 Offset: 0x23E87A1 VA: 0x23E86A0
	|-PlayableExtensions.SetInputWeight<AnimationLayerMixerPlayable>
	|
	|-RVA: 0x23E8700 Offset: 0x23E8801 VA: 0x23E8700
	|-PlayableExtensions.SetInputWeight<AnimationMixerPlayable>
	|
	|-RVA: 0x23E8760 Offset: 0x23E8861 VA: 0x23E8760
	|-PlayableExtensions.SetInputWeight<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0x23E87C0 Offset: 0x23E88C1 VA: 0x23E87C0
	|-PlayableExtensions.SetInputWeight<AnimationOffsetPlayable>
	|
	|-RVA: 0x23E8820 Offset: 0x23E8921 VA: 0x23E8820
	|-PlayableExtensions.SetInputWeight<AnimationRemoveScalePlayable>
	|
	|-RVA: 0x23E8880 Offset: 0x23E8981 VA: 0x23E8880
	|-PlayableExtensions.SetInputWeight<AnimationScriptPlayable>
	|
	|-RVA: 0x23E89C0 Offset: 0x23E8AC1 VA: 0x23E89C0
	|-PlayableExtensions.SetInputWeight<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9E40 Offset: 0xD9F41 VA: 0xD9E40
	// RVA: -1 Offset: -1
	public static void SetInputWeight<U, V>(U playable, V input, float weight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E88E0 Offset: 0x23E89E1 VA: 0x23E88E0
	|-PlayableExtensions.SetInputWeight<AudioMixerPlayable, Playable>
	|
	|-RVA: 0x23E8950 Offset: 0x23E8A51 VA: 0x23E8950
	|-PlayableExtensions.SetInputWeight<Playable, Playable>
	|
	|-RVA: 0x23E8A20 Offset: 0x23E8B21 VA: 0x23E8A20
	|-PlayableExtensions.SetInputWeight<ScriptPlayable<object>, Playable>
	|-PlayableExtensions.SetInputWeight<ScriptPlayable<TimeNotificationBehaviour>, Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9E50 Offset: 0xD9F51 VA: 0xD9E50
	// RVA: -1 Offset: -1
	public static float GetInputWeight<U>(U playable, int inputIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25621A0 Offset: 0x25622A1 VA: 0x25621A0
	|-PlayableExtensions.GetInputWeight<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9E60 Offset: 0xD9F61 VA: 0xD9E60
	// RVA: -1 Offset: -1
	public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E7F20 Offset: 0x23E8021 VA: 0x23E7F20
	|-PlayableExtensions.ConnectInput<AnimationMixerPlayable, Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9E70 Offset: 0xD9F71 VA: 0xD9E70
	// RVA: -1 Offset: -1
	public static void ConnectInput<U, V>(U playable, int inputIndex, V sourcePlayable, int sourceOutputIndex, float weight) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E7F40 Offset: 0x23E8041 VA: 0x23E7F40
	|-PlayableExtensions.ConnectInput<AnimationMixerPlayable, Playable>
	|
	|-RVA: 0x23E8000 Offset: 0x23E8101 VA: 0x23E8000
	|-PlayableExtensions.ConnectInput<AnimationScriptPlayable, AnimatorControllerPlayable>
	*/

	[ExtensionAttribute] // RVA: 0xD9E80 Offset: 0xD9F81 VA: 0xD9E80
	// RVA: -1 Offset: -1
	public static void DisconnectInput<U>(U playable, int inputPort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8100 Offset: 0x23E8201 VA: 0x23E8100
	|-PlayableExtensions.DisconnectInput<AnimationMixerPlayable>
	*/

	[ExtensionAttribute] // RVA: 0xD9E90 Offset: 0xD9F91 VA: 0xD9E90
	// RVA: -1 Offset: -1
	public static int AddInput<U, V>(U playable, V sourcePlayable, int sourceOutputIndex, float weight = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E490 Offset: 0x255E591 VA: 0x255E490
	|-PlayableExtensions.AddInput<AnimationScriptPlayable, AnimatorControllerPlayable>
	*/

	[ExtensionAttribute] // RVA: 0xD9EA0 Offset: 0xD9FA1 VA: 0xD9EA0
	// RVA: -1 Offset: -1
	public static void SetTraversalMode<U>(U playable, PlayableTraversalMode mode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9050 Offset: 0x23E9151 VA: 0x23E9050
	|-PlayableExtensions.SetTraversalMode<ScriptPlayable<object>>
	|-PlayableExtensions.SetTraversalMode<ScriptPlayable<TimelinePlayable>>
	*/

	[ExtensionAttribute] // RVA: 0xD9EB0 Offset: 0xD9FB1 VA: 0xD9EB0
	// RVA: -1 Offset: -1
	internal static DirectorWrapMode GetTimeWrapMode<U>(U playable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8B40 Offset: 0x34F8C41 VA: 0x34F8B40
	|-PlayableExtensions.GetTimeWrapMode<Playable>
	*/

	[ExtensionAttribute] // RVA: 0xD9EC0 Offset: 0xD9FC1 VA: 0xD9EC0
	// RVA: -1 Offset: -1
	internal static void SetTimeWrapMode<U>(U playable, DirectorWrapMode value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E8EF0 Offset: 0x23E8FF1 VA: 0x23E8EF0
	|-PlayableExtensions.SetTimeWrapMode<Playable>
	|
	|-RVA: 0x23E8F40 Offset: 0x23E9041 VA: 0x23E8F40
	|-PlayableExtensions.SetTimeWrapMode<ScriptPlayable<object>>
	|-PlayableExtensions.SetTimeWrapMode<ScriptPlayable<TimeNotificationBehaviour>>
	*/
}

