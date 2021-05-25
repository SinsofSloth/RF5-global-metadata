[DocumentationSortingAttribute] // RVA: 0x12ED60 Offset: 0x12EE61 VA: 0x12ED60
[Serializable]
public struct CinemachineBlendDefinition // TypeDefIndex: 4816
{
	// Fields
	[TooltipAttribute] // RVA: 0x134480 Offset: 0x134581 VA: 0x134480
	public CinemachineBlendDefinition.Style m_Style; // 0x0
	[TooltipAttribute] // RVA: 0x1344C0 Offset: 0x1345C1 VA: 0x1344C0
	public float m_Time; // 0x4
	public AnimationCurve m_CustomCurve; // 0x8
	private static AnimationCurve[] sStandardCurves; // 0x0

	// Properties
	public float BlendTime { get; }
	public AnimationCurve BlendCurve { get; }

	// Methods

	// RVA: 0xE080 Offset: 0xE181 VA: 0xE080
	public float get_BlendTime() { }

	// RVA: 0xE0A0 Offset: 0xE1A1 VA: 0xE0A0
	public void .ctor(CinemachineBlendDefinition.Style style, float time) { }

	// RVA: 0xE0C0 Offset: 0xE1C1 VA: 0xE0C0
	private void CreateStandardCurves() { }

	// RVA: 0xE0D0 Offset: 0xE1D1 VA: 0xE0D0
	public AnimationCurve get_BlendCurve() { }
}

