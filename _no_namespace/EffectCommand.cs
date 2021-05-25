public class EffectCommand : ActionCommandBase // TypeDefIndex: 6178
{
	// Fields
	private EffectID _EffectID; // 0x80
	private bool IsParse; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x15BC50 Offset: 0x15BD51 VA: 0x15BC50
	private ParticleDestroy <ParticleDestroy>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x15BC60 Offset: 0x15BD61 VA: 0x15BC60
	private float <FinishTime>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x15BC70 Offset: 0x15BD71 VA: 0x15BC70
	private Vector3 <OffsetPos>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x15BC80 Offset: 0x15BD81 VA: 0x15BC80
	private Vector3 <OffsetRote>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x15BC90 Offset: 0x15BD91 VA: 0x15BC90
	private Vector3 <OffsetScale>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x15BCA0 Offset: 0x15BDA1 VA: 0x15BCA0
	private Transform <TargetTransform>k__BackingField; // 0xB8

	// Properties
	private EffectID EffectID { get; }
	public bool IsAutoDestroy { get; }
	public bool IsAttach { get; }
	public override float Duration { get; }
	public bool IsDestroyImmediate { get; }
	public bool IsAutoVelocity { get; }
	private ParticleDestroy ParticleDestroy { get; set; }
	private float FinishTime { get; set; }
	private Vector3 OffsetPos { get; set; }
	private Vector3 OffsetRote { get; set; }
	private Vector3 OffsetScale { get; set; }
	private Transform TargetTransform { get; set; }

	// Methods

	// RVA: 0x2015AA0 Offset: 0x2015BA1 VA: 0x2015AA0
	private EffectID get_EffectID() { }

	// RVA: 0x2015B20 Offset: 0x2015C21 VA: 0x2015B20
	public bool get_IsAutoDestroy() { }

	// RVA: 0x2015B40 Offset: 0x2015C41 VA: 0x2015B40
	public bool get_IsAttach() { }

	// RVA: 0x2015B60 Offset: 0x2015C61 VA: 0x2015B60
	public void .ctor(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller) { }

	// RVA: 0x2015C60 Offset: 0x2015D61 VA: 0x2015C60 Slot: 4
	public override float get_Duration() { }

	// RVA: 0x2015C80 Offset: 0x2015D81 VA: 0x2015C80
	public bool get_IsDestroyImmediate() { }

	// RVA: 0x2015CA0 Offset: 0x2015DA1 VA: 0x2015CA0
	public bool get_IsAutoVelocity() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A6E0 Offset: 0x19A7E1 VA: 0x19A6E0
	// RVA: 0x2015CD0 Offset: 0x2015DD1 VA: 0x2015CD0
	private ParticleDestroy get_ParticleDestroy() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A6F0 Offset: 0x19A7F1 VA: 0x19A6F0
	// RVA: 0x2015CE0 Offset: 0x2015DE1 VA: 0x2015CE0
	private void set_ParticleDestroy(ParticleDestroy value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A700 Offset: 0x19A801 VA: 0x19A700
	// RVA: 0x2015CF0 Offset: 0x2015DF1 VA: 0x2015CF0
	private float get_FinishTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A710 Offset: 0x19A811 VA: 0x19A710
	// RVA: 0x2015D00 Offset: 0x2015E01 VA: 0x2015D00
	private void set_FinishTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A720 Offset: 0x19A821 VA: 0x19A720
	// RVA: 0x2015D10 Offset: 0x2015E11 VA: 0x2015D10
	private Vector3 get_OffsetPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A730 Offset: 0x19A831 VA: 0x19A730
	// RVA: 0x2015D20 Offset: 0x2015E21 VA: 0x2015D20
	private void set_OffsetPos(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A740 Offset: 0x19A841 VA: 0x19A740
	// RVA: 0x2015D30 Offset: 0x2015E31 VA: 0x2015D30
	private Vector3 get_OffsetRote() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A750 Offset: 0x19A851 VA: 0x19A750
	// RVA: 0x2015D40 Offset: 0x2015E41 VA: 0x2015D40
	private void set_OffsetRote(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A760 Offset: 0x19A861 VA: 0x19A760
	// RVA: 0x2015D50 Offset: 0x2015E51 VA: 0x2015D50
	private Vector3 get_OffsetScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A770 Offset: 0x19A871 VA: 0x19A770
	// RVA: 0x2015D60 Offset: 0x2015E61 VA: 0x2015D60
	private void set_OffsetScale(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x19A780 Offset: 0x19A881 VA: 0x19A780
	// RVA: 0x2015D70 Offset: 0x2015E71 VA: 0x2015D70
	private Transform get_TargetTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A790 Offset: 0x19A891 VA: 0x19A790
	// RVA: 0x2015D80 Offset: 0x2015E81 VA: 0x2015D80
	private void set_TargetTransform(Transform value) { }

	// RVA: 0x2015D90 Offset: 0x2015E91 VA: 0x2015D90 Slot: 8
	public override void DoAction() { }

	// RVA: 0x2016090 Offset: 0x2016191 VA: 0x2016090 Slot: 10
	public override void EndAction() { }

	// RVA: 0x20160E0 Offset: 0x20161E1 VA: 0x20160E0 Slot: 11
	public override void ActionFinal() { }

	[CompilerGeneratedAttribute] // RVA: 0x19A7A0 Offset: 0x19A8A1 VA: 0x19A7A0
	// RVA: 0x2016220 Offset: 0x2016321 VA: 0x2016220
	private void <DoAction>b__39_0(ParticleSystem prefab) { }
}

