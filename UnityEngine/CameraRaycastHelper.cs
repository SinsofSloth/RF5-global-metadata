[NativeHeaderAttribute] // RVA: 0xF9840 Offset: 0xF9941 VA: 0xF9840
internal class CameraRaycastHelper // TypeDefIndex: 3632
{
	// Methods

	[FreeFunctionAttribute] // RVA: 0xF98C0 Offset: 0xF99C1 VA: 0xF98C0
	// RVA: 0x1BDB5B0 Offset: 0x1BDB6B1 VA: 0x1BDB5B0
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunctionAttribute] // RVA: 0xF9900 Offset: 0xF9A01 VA: 0xF9900
	// RVA: 0x1BDB690 Offset: 0x1BDB791 VA: 0x1BDB690
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1BDB620 Offset: 0x1BDB721 VA: 0x1BDB620
	private static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }

	// RVA: 0x1BDB700 Offset: 0x1BDB801 VA: 0x1BDB700
	private static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask) { }
}

