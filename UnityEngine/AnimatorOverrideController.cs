[NativeHeaderAttribute] // RVA: 0xE8BE0 Offset: 0xE8CE1 VA: 0xE8BE0
[NativeHeaderAttribute] // RVA: 0xE8BE0 Offset: 0xE8CE1 VA: 0xE8BE0
[DefaultMemberAttribute] // RVA: 0xE8BE0 Offset: 0xE8CE1 VA: 0xE8BE0
[UsedByNativeCodeAttribute] // RVA: 0xE8BE0 Offset: 0xE8CE1 VA: 0xE8BE0
public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 3489
{
	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Properties
	public RuntimeAnimatorController runtimeAnimatorController { get; set; }
	public AnimationClip Item { get; set; }
	public AnimationClip Item { get; set; }
	public int overridesCount { get; }
	[ObsoleteAttribute] // RVA: 0xEE5F0 Offset: 0xEE6F1 VA: 0xEE5F0
	public AnimationClipPair[] clips { get; set; }

	// Methods

	// RVA: 0x1AFD890 Offset: 0x1AFD991 VA: 0x1AFD890
	public void .ctor() { }

	// RVA: 0x1AFDA00 Offset: 0x1AFDB01 VA: 0x1AFDA00
	public void .ctor(RuntimeAnimatorController controller) { }

	[FreeFunctionAttribute] // RVA: 0xEC060 Offset: 0xEC161 VA: 0xEC060
	// RVA: 0x1AFD9B0 Offset: 0x1AFDAB1 VA: 0x1AFD9B0
	private static void Internal_Create(AnimatorOverrideController self, RuntimeAnimatorController controller) { }

	[NativeMethodAttribute] // RVA: 0xEC0A0 Offset: 0xEC1A1 VA: 0xEC0A0
	// RVA: 0x1AFDAB0 Offset: 0x1AFDBB1 VA: 0x1AFDAB0
	public RuntimeAnimatorController get_runtimeAnimatorController() { }

	[NativeMethodAttribute] // RVA: 0xEC0E0 Offset: 0xEC1E1 VA: 0xEC0E0
	// RVA: 0x1AFDB00 Offset: 0x1AFDC01 VA: 0x1AFDB00
	public void set_runtimeAnimatorController(RuntimeAnimatorController value) { }

	// RVA: 0x1AFDB50 Offset: 0x1AFDC51 VA: 0x1AFDB50
	public AnimationClip get_Item(string name) { }

	// RVA: 0x1AFDC10 Offset: 0x1AFDD11 VA: 0x1AFDC10
	public void set_Item(string name, AnimationClip value) { }

	[NativeMethodAttribute] // RVA: 0xEC120 Offset: 0xEC221 VA: 0xEC120
	// RVA: 0x1AFDBB0 Offset: 0x1AFDCB1 VA: 0x1AFDBB0
	private AnimationClip Internal_GetClipByName(string name, bool returnEffectiveClip) { }

	[NativeMethodAttribute] // RVA: 0xEC160 Offset: 0xEC261 VA: 0xEC160
	// RVA: 0x1AFDC70 Offset: 0x1AFDD71 VA: 0x1AFDC70
	private void Internal_SetClipByName(string name, AnimationClip clip) { }

	// RVA: 0x1AFDCD0 Offset: 0x1AFDDD1 VA: 0x1AFDCD0
	public AnimationClip get_Item(AnimationClip clip) { }

	// RVA: 0x1AFDD90 Offset: 0x1AFDE91 VA: 0x1AFDD90
	public void set_Item(AnimationClip clip, AnimationClip value) { }

	// RVA: 0x1AFDD30 Offset: 0x1AFDE31 VA: 0x1AFDD30
	private AnimationClip GetClip(AnimationClip originalClip, bool returnEffectiveClip) { }

	// RVA: 0x1AFDDF0 Offset: 0x1AFDEF1 VA: 0x1AFDDF0
	private void SetClip(AnimationClip originalClip, AnimationClip overrideClip, bool notify) { }

	// RVA: 0x1AFDE60 Offset: 0x1AFDF61 VA: 0x1AFDE60
	private void SendNotification() { }

	// RVA: 0x1AFDEB0 Offset: 0x1AFDFB1 VA: 0x1AFDEB0
	private AnimationClip GetOriginalClip(int index) { }

	// RVA: 0x1AFDF00 Offset: 0x1AFE001 VA: 0x1AFDF00
	private AnimationClip GetOverrideClip(AnimationClip originalClip) { }

	[NativeMethodAttribute] // RVA: 0xEC1A0 Offset: 0xEC2A1 VA: 0xEC1A0
	// RVA: 0x1AFDF50 Offset: 0x1AFE051 VA: 0x1AFDF50
	public int get_overridesCount() { }

	// RVA: 0x1AFDFA0 Offset: 0x1AFE0A1 VA: 0x1AFDFA0
	public void GetOverrides(List<KeyValuePair<AnimationClip, AnimationClip>> overrides) { }

	// RVA: 0x1AFE170 Offset: 0x1AFE271 VA: 0x1AFE170
	public void ApplyOverrides(IList<KeyValuePair<AnimationClip, AnimationClip>> overrides) { }

	// RVA: 0x1AFE3E0 Offset: 0x1AFE4E1 VA: 0x1AFE3E0
	public AnimationClipPair[] get_clips() { }

	// RVA: 0x1AFE5E0 Offset: 0x1AFE6E1 VA: 0x1AFE5E0
	public void set_clips(AnimationClipPair[] value) { }

	[NativeConditionalAttribute] // RVA: 0xEC1E0 Offset: 0xEC2E1 VA: 0xEC1E0
	// RVA: 0x1AFE6C0 Offset: 0x1AFE7C1 VA: 0x1AFE6C0
	internal void PerformOverrideClipListCleanup() { }

	[RequiredByNativeCodeAttribute] // RVA: 0xEC220 Offset: 0xEC321 VA: 0xEC220
	[NativeConditionalAttribute] // RVA: 0xEC220 Offset: 0xEC321 VA: 0xEC220
	// RVA: 0x1AFE710 Offset: 0x1AFE811 VA: 0x1AFE710
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }
}

