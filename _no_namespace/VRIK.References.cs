[Serializable]
public class VRIK.References // TypeDefIndex: 9449
{
	// Fields
	public Transform root; // 0x10
	public Transform pelvis; // 0x18
	public Transform spine; // 0x20
	[TooltipAttribute] // RVA: 0x1963D0 Offset: 0x1964D1 VA: 0x1963D0
	public Transform chest; // 0x28
	[TooltipAttribute] // RVA: 0x196410 Offset: 0x196511 VA: 0x196410
	public Transform neck; // 0x30
	public Transform head; // 0x38
	[TooltipAttribute] // RVA: 0x196450 Offset: 0x196551 VA: 0x196450
	public Transform leftShoulder; // 0x40
	public Transform leftUpperArm; // 0x48
	public Transform leftForearm; // 0x50
	public Transform leftHand; // 0x58
	[TooltipAttribute] // RVA: 0x196490 Offset: 0x196591 VA: 0x196490
	public Transform rightShoulder; // 0x60
	public Transform rightUpperArm; // 0x68
	public Transform rightForearm; // 0x70
	public Transform rightHand; // 0x78
	[TooltipAttribute] // RVA: 0x1964D0 Offset: 0x1965D1 VA: 0x1964D0
	public Transform leftThigh; // 0x80
	[TooltipAttribute] // RVA: 0x196510 Offset: 0x196611 VA: 0x196510
	public Transform leftCalf; // 0x88
	[TooltipAttribute] // RVA: 0x196550 Offset: 0x196651 VA: 0x196550
	public Transform leftFoot; // 0x90
	[TooltipAttribute] // RVA: 0x196590 Offset: 0x196691 VA: 0x196590
	public Transform leftToes; // 0x98
	[TooltipAttribute] // RVA: 0x1965D0 Offset: 0x1966D1 VA: 0x1965D0
	public Transform rightThigh; // 0xA0
	[TooltipAttribute] // RVA: 0x196610 Offset: 0x196711 VA: 0x196610
	public Transform rightCalf; // 0xA8
	[TooltipAttribute] // RVA: 0x196650 Offset: 0x196751 VA: 0x196650
	public Transform rightFoot; // 0xB0
	[TooltipAttribute] // RVA: 0x196690 Offset: 0x196791 VA: 0x196690
	public Transform rightToes; // 0xB8

	// Properties
	public bool isFilled { get; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x2927050 Offset: 0x2927151 VA: 0x2927050
	public Transform[] GetTransforms() { }

	// RVA: 0x2926980 Offset: 0x2926A81 VA: 0x2926980
	public bool get_isFilled() { }

	// RVA: 0x29264F0 Offset: 0x29265F1 VA: 0x29264F0
	public bool get_isEmpty() { }

	// RVA: 0x2925FA0 Offset: 0x29260A1 VA: 0x2925FA0
	public static bool AutoDetectReferences(Transform root, out VRIK.References references) { }

	// RVA: 0x2927040 Offset: 0x2927141 VA: 0x2927040
	public void .ctor() { }
}

