[RequiredByNativeCodeAttribute] // RVA: 0xE9C00 Offset: 0xE9D01 VA: 0xE9C00
[NativeHeaderAttribute] // RVA: 0xE9C00 Offset: 0xE9D01 VA: 0xE9C00
[NativeHeaderAttribute] // RVA: 0xE9C00 Offset: 0xE9D01 VA: 0xE9C00
[MovedFromAttribute] // RVA: 0xE9C00 Offset: 0xE9D01 VA: 0xE9C00
public struct AnimationStream // TypeDefIndex: 3535
{
	// Fields
	private uint m_AnimatorBindingsVersion; // 0x0
	private IntPtr constant; // 0x8
	private IntPtr input; // 0x10
	private IntPtr output; // 0x18
	private IntPtr workspace; // 0x20
	private IntPtr inputStreamAccessor; // 0x28
	private IntPtr animationHandleBinder; // 0x30

	// Properties
	internal uint animatorBindingsVersion { get; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x1C8B0 Offset: 0x1C9B1 VA: 0x1C8B0
	internal uint get_animatorBindingsVersion() { }

	// RVA: 0x1C8C0 Offset: 0x1C9C1 VA: 0x1C8C0
	public bool get_isValid() { }

	// RVA: 0x1C8D0 Offset: 0x1C9D1 VA: 0x1C8D0
	internal void CheckIsValid() { }
}

