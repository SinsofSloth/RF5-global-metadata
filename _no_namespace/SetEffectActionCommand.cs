public class SetEffectActionCommand : ActionCommandBase // TypeDefIndex: 6292
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x15BE90 Offset: 0x15BF91 VA: 0x15BE90
	private ParticleDestroy <ParticleDestroy>k__BackingField; // 0x80

	// Properties
	public EffectID UseEffectID { get; }
	public bool IsAutoDestroy { get; }
	public bool IsAttach { get; }
	public Vector3 Position { get; }
	public Vector3 Rotation { get; }
	private ParticleDestroy ParticleDestroy { get; set; }

	// Methods

	// RVA: 0x1C8AE80 Offset: 0x1C8AF81 VA: 0x1C8AE80
	public EffectID get_UseEffectID() { }

	// RVA: 0x1C8AF70 Offset: 0x1C8B071 VA: 0x1C8AF70
	public bool get_IsAutoDestroy() { }

	// RVA: 0x1C8AFA0 Offset: 0x1C8B0A1 VA: 0x1C8AFA0
	public bool get_IsAttach() { }

	// RVA: 0x1C8AFD0 Offset: 0x1C8B0D1 VA: 0x1C8AFD0
	public Vector3 get_Position() { }

	// RVA: 0x1C8AFF0 Offset: 0x1C8B0F1 VA: 0x1C8AFF0
	public Vector3 get_Rotation() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A8E0 Offset: 0x19A9E1 VA: 0x19A8E0
	// RVA: 0x1C8B010 Offset: 0x1C8B111 VA: 0x1C8B010
	private ParticleDestroy get_ParticleDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A8F0 Offset: 0x19A9F1 VA: 0x19A8F0
	// RVA: 0x1C8B020 Offset: 0x1C8B121 VA: 0x1C8B020
	private void set_ParticleDestroy(ParticleDestroy value) { }

	// RVA: 0x1C8B030 Offset: 0x1C8B131 VA: 0x1C8B030
	public void .ctor(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller) { }

	// RVA: 0x1C8B1B0 Offset: 0x1C8B2B1 VA: 0x1C8B1B0 Slot: 8
	public override void DoAction() { }

	// RVA: 0x1C8B280 Offset: 0x1C8B381 VA: 0x1C8B280 Slot: 11
	public override void ActionFinal() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A900 Offset: 0x19AA01 VA: 0x19A900
	// RVA: 0x1C8B320 Offset: 0x1C8B421 VA: 0x1C8B320
	private void <DoAction>b__15_0(ParticleSystem prefab) { }
}

