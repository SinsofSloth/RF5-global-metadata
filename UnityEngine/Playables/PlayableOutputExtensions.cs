[ExtensionAttribute] // RVA: 0xC8DE0 Offset: 0xC8EE1 VA: 0xC8DE0
public static class PlayableOutputExtensions // TypeDefIndex: 3358
{
	// Methods

	[ExtensionAttribute] // RVA: 0xDAE40 Offset: 0xDAF41 VA: 0xDAE40
	// RVA: -1 Offset: -1
	public static void SetReferenceObject<U>(U output, Object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9320 Offset: 0x23E9421 VA: 0x23E9320
	|-PlayableOutputExtensions.SetReferenceObject<PlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0xDAE50 Offset: 0xDAF51 VA: 0xDAE50
	// RVA: -1 Offset: -1
	public static void SetUserData<U>(U output, Object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9570 Offset: 0x23E9671 VA: 0x23E9570
	|-PlayableOutputExtensions.SetUserData<PlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0xDAE60 Offset: 0xDAF61 VA: 0xDAE60
	// RVA: -1 Offset: -1
	public static Playable GetSourcePlayable<U>(U output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34F8C60 Offset: 0x34F8D61 VA: 0x34F8C60
	|-PlayableOutputExtensions.GetSourcePlayable<AnimationPlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0xDAE70 Offset: 0xDAF71 VA: 0xDAE70
	// RVA: -1 Offset: -1
	public static void SetSourcePlayable<U, V>(U output, V value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9370 Offset: 0x23E9471 VA: 0x23E9370
	|-PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationMixerPlayable>
	|
	|-RVA: 0x23E9400 Offset: 0x23E9501 VA: 0x23E9400
	|-PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, AnimationScriptPlayable>
	*/

	[ExtensionAttribute] // RVA: 0xDAE80 Offset: 0xDAF81 VA: 0xDAE80
	// RVA: -1 Offset: -1
	public static void SetSourcePlayable<U, V>(U output, V value, int port) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9490 Offset: 0x23E9591 VA: 0x23E9490
	|-PlayableOutputExtensions.SetSourcePlayable<AnimationPlayableOutput, Playable>
	|
	|-RVA: 0x23E9500 Offset: 0x23E9601 VA: 0x23E9500
	|-PlayableOutputExtensions.SetSourcePlayable<PlayableOutput, Playable>
	*/

	[ExtensionAttribute] // RVA: 0xDAE90 Offset: 0xDAF91 VA: 0xDAE90
	// RVA: -1 Offset: -1
	public static int GetSourceOutputPort<U>(U output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x255E610 Offset: 0x255E711 VA: 0x255E610
	|-PlayableOutputExtensions.GetSourceOutputPort<AnimationPlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0xDAEA0 Offset: 0xDAFA1 VA: 0xDAEA0
	// RVA: -1 Offset: -1
	public static void SetWeight<U>(U output, float value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E95C0 Offset: 0x23E96C1 VA: 0x23E95C0
	|-PlayableOutputExtensions.SetWeight<AnimationPlayableOutput>
	|
	|-RVA: 0x23E9610 Offset: 0x23E9711 VA: 0x23E9610
	|-PlayableOutputExtensions.SetWeight<PlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0xDAEB0 Offset: 0xDAFB1 VA: 0xDAEB0
	// RVA: -1 Offset: -1
	public static void PushNotification<U>(U output, Playable origin, INotification notification, object context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E92B0 Offset: 0x23E93B1 VA: 0x23E92B0
	|-PlayableOutputExtensions.PushNotification<PlayableOutput>
	*/

	[ExtensionAttribute] // RVA: 0xDAEC0 Offset: 0xDAFC1 VA: 0xDAEC0
	// RVA: -1 Offset: -1
	public static void AddNotificationReceiver<U>(U output, INotificationReceiver receiver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E9260 Offset: 0x23E9361 VA: 0x23E9260
	|-PlayableOutputExtensions.AddNotificationReceiver<PlayableOutput>
	*/
}

