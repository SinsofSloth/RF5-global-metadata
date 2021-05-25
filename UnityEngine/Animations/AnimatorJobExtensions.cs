[NativeHeaderAttribute] // RVA: 0xE9F30 Offset: 0xEA031 VA: 0xE9F30
[StaticAccessorAttribute] // RVA: 0xE9F30 Offset: 0xEA031 VA: 0xE9F30
[ExtensionAttribute] // RVA: 0xE9F30 Offset: 0xEA031 VA: 0xE9F30
[NativeHeaderAttribute] // RVA: 0xE9F30 Offset: 0xEA031 VA: 0xE9F30
[NativeHeaderAttribute] // RVA: 0xE9F30 Offset: 0xEA031 VA: 0xE9F30
[NativeHeaderAttribute] // RVA: 0xE9F30 Offset: 0xEA031 VA: 0xE9F30
[MovedFromAttribute] // RVA: 0xE9F30 Offset: 0xEA031 VA: 0xE9F30
[NativeHeaderAttribute] // RVA: 0xE9F30 Offset: 0xEA031 VA: 0xE9F30
public static class AnimatorJobExtensions // TypeDefIndex: 3540
{
	// Methods

	[ExtensionAttribute] // RVA: 0xED0A0 Offset: 0xED1A1 VA: 0xED0A0
	// RVA: 0x1AF24F0 Offset: 0x1AF25F1 VA: 0x1AF24F0
	public static TransformStreamHandle BindStreamTransform(Animator animator, Transform transform) { }

	[ExtensionAttribute] // RVA: 0xED0B0 Offset: 0xED1B1 VA: 0xED0B0
	// RVA: 0x1AF25C0 Offset: 0x1AF26C1 VA: 0x1AF25C0
	public static TransformSceneHandle BindSceneTransform(Animator animator, Transform transform) { }

	[ExtensionAttribute] // RVA: 0xED0C0 Offset: 0xED1C1 VA: 0xED0C0
	// RVA: 0x1AF2680 Offset: 0x1AF2781 VA: 0x1AF2680
	public static PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, Type type, string property) { }

	[ExtensionAttribute] // RVA: 0xED0D0 Offset: 0xED1D1 VA: 0xED0D0
	// RVA: 0x1AF2700 Offset: 0x1AF2801 VA: 0x1AF2700
	public static PropertySceneHandle BindSceneProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference) { }

	// RVA: 0x1AF2560 Offset: 0x1AF2661 VA: 0x1AF2560
	private static void InternalBindStreamTransform(Animator animator, Transform transform, out TransformStreamHandle transformStreamHandle) { }

	// RVA: 0x1AF2620 Offset: 0x1AF2721 VA: 0x1AF2620
	private static void InternalBindSceneTransform(Animator animator, Transform transform, out TransformSceneHandle transformSceneHandle) { }

	// RVA: 0x1AF2790 Offset: 0x1AF2891 VA: 0x1AF2790
	private static void InternalBindSceneProperty(Animator animator, Transform transform, Type type, string property, bool isObjectReference, out PropertySceneHandle propertySceneHandle) { }
}

