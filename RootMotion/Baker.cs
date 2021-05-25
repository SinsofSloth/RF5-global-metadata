[HelpURLAttribute] // RVA: 0x143D70 Offset: 0x143E71 VA: 0x143D70
[AddComponentMenu] // RVA: 0x143D70 Offset: 0x143E71 VA: 0x143D70
public abstract class Baker : MonoBehaviour // TypeDefIndex: 6060
{
	// Fields
	[TooltipAttribute] // RVA: 0x144490 Offset: 0x144591 VA: 0x144490
	[RangeAttribute] // RVA: 0x144490 Offset: 0x144591 VA: 0x144490
	public int frameRate; // 0x18
	[TooltipAttribute] // RVA: 0x1444F0 Offset: 0x1445F1 VA: 0x1444F0
	[RangeAttribute] // RVA: 0x1444F0 Offset: 0x1445F1 VA: 0x1444F0
	public float keyReductionError; // 0x1C
	[TooltipAttribute] // RVA: 0x144550 Offset: 0x144651 VA: 0x144550
	public Baker.Mode mode; // 0x20
	[TooltipAttribute] // RVA: 0x144590 Offset: 0x144691 VA: 0x144590
	public AnimationClip[] animationClips; // 0x28
	[TooltipAttribute] // RVA: 0x1445D0 Offset: 0x1446D1 VA: 0x1445D0
	public string[] animationStates; // 0x30
	[TooltipAttribute] // RVA: 0x144610 Offset: 0x144711 VA: 0x144610
	public bool loop; // 0x38
	[TooltipAttribute] // RVA: 0x144650 Offset: 0x144751 VA: 0x144650
	public string saveToFolder; // 0x40
	[TooltipAttribute] // RVA: 0x144690 Offset: 0x144791 VA: 0x144690
	public string appendName; // 0x48
	[TooltipAttribute] // RVA: 0x1446D0 Offset: 0x1447D1 VA: 0x1446D0
	public string saveName; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x144710 Offset: 0x144811 VA: 0x144710
	private bool <isBaking>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x144720 Offset: 0x144821 VA: 0x144720
	private float <bakingProgress>k__BackingField; // 0x5C
	[SerializeField] // RVA: 0x144730 Offset: 0x144831 VA: 0x144730
	[HideInInspector] // RVA: 0x144730 Offset: 0x144831 VA: 0x144730
	public Animator animator; // 0x60
	[SerializeField] // RVA: 0x144770 Offset: 0x144871 VA: 0x144770
	[HideInInspector] // RVA: 0x144770 Offset: 0x144871 VA: 0x144770
	public PlayableDirector director; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x1447B0 Offset: 0x1448B1 VA: 0x1447B0
	private float <clipLength>k__BackingField; // 0x70

	// Properties
	public bool isBaking { get; set; }
	public float bakingProgress { get; set; }
	protected float clipLength { get; set; }

	// Methods

	[ContextMenu] // RVA: 0x144B10 Offset: 0x144C11 VA: 0x144B10
	// RVA: 0x1A44DE0 Offset: 0x1A44EE1 VA: 0x1A44DE0
	private void OpenUserManual() { }

	[ContextMenu] // RVA: 0x144B50 Offset: 0x144C51 VA: 0x144B50
	// RVA: 0x1A44E30 Offset: 0x1A44F31 VA: 0x1A44E30
	private void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x144B90 Offset: 0x144C91 VA: 0x144B90
	// RVA: 0x1A44E80 Offset: 0x1A44F81 VA: 0x1A44E80
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x144BD0 Offset: 0x144CD1 VA: 0x144BD0
	// RVA: 0x1A44ED0 Offset: 0x1A44FD1 VA: 0x1A44ED0
	private void ASThread() { }

	[CompilerGeneratedAttribute] // RVA: 0x144C10 Offset: 0x144D11 VA: 0x144C10
	// RVA: 0x1A44F20 Offset: 0x1A45021 VA: 0x1A44F20
	public bool get_isBaking() { }

	[CompilerGeneratedAttribute] // RVA: 0x144C20 Offset: 0x144D21 VA: 0x144C20
	// RVA: 0x1A44F30 Offset: 0x1A45031 VA: 0x1A44F30
	private void set_isBaking(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x144C30 Offset: 0x144D31 VA: 0x144C30
	// RVA: 0x1A44F40 Offset: 0x1A45041 VA: 0x1A44F40
	public float get_bakingProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x144C40 Offset: 0x144D41 VA: 0x144C40
	// RVA: 0x1A44F50 Offset: 0x1A45051 VA: 0x1A44F50
	private void set_bakingProgress(float value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract Transform GetCharacterRoot() { }

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void OnStartBaking() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnSetLoopFrame(float time) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract void OnSetCurves(ref AnimationClip clip) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OnSetKeyframes(float time, bool lastFrame) { }

	[CompilerGeneratedAttribute] // RVA: 0x144C50 Offset: 0x144D51 VA: 0x144C50
	// RVA: 0x1A44F60 Offset: 0x1A45061 VA: 0x1A44F60
	protected float get_clipLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x144C60 Offset: 0x144D61 VA: 0x144C60
	// RVA: 0x1A44F70 Offset: 0x1A45071 VA: 0x1A44F70
	private void set_clipLength(float value) { }

	// RVA: 0x1A44F80 Offset: 0x1A45081 VA: 0x1A44F80
	public void BakeClip() { }

	// RVA: 0x1A44F90 Offset: 0x1A45091 VA: 0x1A44F90
	public void StartBaking() { }

	// RVA: 0x1A44FA0 Offset: 0x1A450A1 VA: 0x1A44FA0
	public void StopBaking() { }

	// RVA: 0x1A44FB0 Offset: 0x1A450B1 VA: 0x1A44FB0
	protected void .ctor() { }
}

